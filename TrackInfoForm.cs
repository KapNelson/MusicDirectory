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
    public partial class TrackInfoForm : Form
    {
        public static TrackInfoForm instance;
        private int numTrack;
        public TrackInfoForm()
        {
            InitializeComponent();
            instance = this;
        }
        public void InfoTrack(int t)
        {
            numTrack = t;
            MusicDirectoryContext db = new MusicDirectoryContext();
            var track = db.Track;

            foreach (Track el in track)
            {
                if (el.ID_Track == numTrack)
                {
                    nameLabel.Text = el.NameOfTrack;
                    performerLabel.Text = el.Performer.ArtistName;
                    yearLabel.Text = Convert.ToString(el.TrackRecYear);
                    durationLabel.Text = el.Duration;
                    albumLabel.Text = el.Album.AlbumTitle;
                    numLabel.Text = Convert.ToString(el.AlbumNumber);
                    genreLabel.Text = el.GenreName;
                }
            }
        }
    }
}
