using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class TrackInfoForm : Form
    {
        public static TrackInfoForm instance;
        private Track curTrack;
        public TrackInfoForm()
        {
            InitializeComponent();
            instance = this;
        }
        public void InfoTrack(Track t)
        {
            curTrack = t;
            MusicDirectoryContext db = new MusicDirectoryContext();
            var track = db.Track;

            foreach (Track el in track)
            {
                if (el.ID_Track == curTrack.ID_Track)
                {
                    nameLabel.Text = el.NameOfTrack;
                    performerLabel.Text = el.Performer.ArtistName;
                    yearLabel.Text = Convert.ToString(el.TrackRecYear);
                    durationLabel.Text = el.Duration;
                    albumLabel.Text = el.Album.AlbumTitle;
                    numLabel.Text = Convert.ToString(el.AlbumNumber);
                    genreLabel.Text = el.GenreName;
                    break;
                }
            }
        }

        private void infoAlbumButton_Click(object sender, EventArgs e)
        {
            AlbumInfoForm form = new AlbumInfoForm(curTrack);
            form.Show();
        }

        private void infoPerformerButton_Click(object sender, EventArgs e)
        {
            PerformerInfoForm form = new PerformerInfoForm(curTrack);
            form.Show();
        }

        private void findDiskButton_Click(object sender, EventArgs e)
        {
            DiskInfoForm form = new DiskInfoForm(curTrack);
            form.Show();
        }
    }
}
