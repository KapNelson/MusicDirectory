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
    public partial class MenuAdminForm : Form
    {
        public MenuAdminForm()
        {
            InitializeComponent();
        }

        private void addTrackButton_Click(object sender, EventArgs e)
        {
            AddTrackForm form = new AddTrackForm();
            MusicDirectoryContext db = new MusicDirectoryContext();
            var performer = db.Performer;
            var genre = db.Genre;
            var album = db.Album;

            foreach (Performer el in performer)
            {
                AddTrackForm.instance.AddPerformer(el.ArtistName);
            }
            foreach (Genre el in genre)
            {
                AddTrackForm.instance.AddGenre(el.GenreName);
            }
            foreach (Album el in album)
            {
                AddTrackForm.instance.AddAlbum(el.AlbumTitle);
            }

            form.Show();
        }
    }
}
