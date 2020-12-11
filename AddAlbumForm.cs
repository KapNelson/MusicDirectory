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
    public partial class AddAlbumForm : Form
    {
        public AddAlbumForm()
        {
            InitializeComponent();
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            Album newAlbum = new Album { AlbumTitle = nameTextBox.Text, AlbumRecYear = Convert.ToInt32(yearRecTextBox.Text), NumOfTracks = Convert.ToInt32(numTextBox.Text) };
            db.Album.Add(newAlbum);
            db.SaveChanges();
            MenuAdminForm.instance.AddAlbum(nameTextBox.Text);
            MessageBox.Show("Альбом успешно добавлен!");
        }
    }
}