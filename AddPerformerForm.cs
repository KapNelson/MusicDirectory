using System;
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
                db.SaveChanges();
            }
            else
            {
                Band newBand = new Band { ID_Artist = id_performer, NumOfParticipants = Convert.ToInt32(numTextBox.Text) };
                db.Band.Add(newBand);
                db.SaveChanges();
                AddParticipationForm form = new AddParticipationForm(newBand.ID_Artist);
                form.Show();
            }
            MenuAdminForm.instance.AddPerformer(nameTextBox.Text);
        }

        private void addMusicianButton_Click(object sender, EventArgs e)
        {
            AddMusicianForm form = new AddMusicianForm();
            form.Show();
        }
    }
}
