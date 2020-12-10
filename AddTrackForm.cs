using System;
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
    public partial class AddTrackForm : Form
    {
        public static AddTrackForm instance;
        public void AddPerformer(string performer)
        {
            performerComboBox.Items.Add(performer);
        }
        public void AddGenre(string genre)
        {
            genreComboBox.Items.Add(genre);
        }
        public void AddAlbum(string album)
        {
            albumComboBox.Items.Add(album);
        }
        public AddTrackForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void addTrackButton_Click(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();

            var performer = db.Performer;
            int id_performer = 0;
            var album = db.Album;
            int id_album = 0;

            foreach (Performer el in performer)
            {
                if (performerComboBox.Text == el.ArtistName)
                    id_performer = el.ID_Artist;
            }
            foreach (Album el in album)
            {
                if (albumComboBox.Text == el.AlbumTitle)
                    id_album = el.ID_Album;
            }

            Track newTrack = new Track 
            {
                NameOfTrack = nameTextBox.Text,
                TrackRecYear = Convert.ToInt32(yearRecTextBox.Text),
                Duration = durationTextBox.Text, 
                AlbumNumber = Convert.ToInt32(numTextBox.Text), 
                GenreName = genreComboBox.Text, 
                ID_Album = id_album, 
                ID_Artist = id_performer            
            };
            db.Track.Add(newTrack);
            db.SaveChanges();
            MessageBox.Show("Трек успешно добавлен!");
        }

        private void addPerformerButton_Click(object sender, EventArgs e)
        {

        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.Show();
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {

        }
    }
}
