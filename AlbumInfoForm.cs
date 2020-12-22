using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class AlbumInfoForm : Form
    {
        private Track curTrack;
        public AlbumInfoForm(Track t)
        {
            InitializeComponent();
            curTrack = t;
        }

        private void AlbumInfoForm_Load(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            var track = db.Track;

            foreach (Track el in track)
            {
                if (el.ID_Track == curTrack.ID_Track)
                {
                    nameLabel.Text = el.Album.AlbumTitle;
                    yearLabel.Text = Convert.ToString(el.Album.AlbumRecYear);
                    numLabel.Text = Convert.ToString(el.Album.NumOfTracks);
                    break;
                }
            }
        }
    }
}
