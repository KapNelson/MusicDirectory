﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class AddPerformerForm : Form
    {
        public static AddPerformerForm instance;
        public void AddMusician(string musiciam)
        {
            musicianComboBox.Items.Add(musiciam);
        }
        public AddPerformerForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void addPerformerButton_Click(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            Performer newPerformer = new Performer { ArtistName = nameTextBox.Text, Country = countryTextBox.Text };
            db.Performer.Add(newPerformer);
            db.SaveChanges();

            var musician = db.Musician;
            int id_musician = 0;
            var performer = db.Performer;
            int id_performer = 0;

            foreach (Musician el in musician)
            {
                if (musicianComboBox.Text == el.FullName)
                    id_musician = el.ID_Musician;
            }
            foreach (Performer el in performer)
            {
                if (newPerformer.ArtistName == el.ArtistName)
                    id_performer = el.ID_Artist;
            }
            if (soloRadioButton.Checked)
            {    
                Solo newSolo = new Solo { ID_Artist = id_performer, ID_Musician = id_musician };
                db.Solo.Add(newSolo);
            }
            else
            {
                Band newBand = new Band { ID_Artist = id_performer, NumOfParticipants = Convert.ToInt32(numTextBox.Text) };
                db.Band.Add(newBand);
            }
            MenuAdminForm.instance.AddPerformer(nameTextBox.Text);
            db.SaveChanges();
            MessageBox.Show("Исполнитель успешно добавлен!");
        }
    }
}