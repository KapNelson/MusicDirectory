using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class AddTrackForm : Form
    {
        MusicDirectoryContext db = new MusicDirectoryContext();
        private string id_disk;
        public AddTrackForm(string id_disk)
        {
            this.id_disk = id_disk;
            InitializeComponent();
        }
        private void AddTrackForm_Load(object sender, EventArgs e)
        {
            var track = db.Track;
            foreach (Track el in track)
            {
                if (el.ID_Album != null)
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), el.Album.AlbumTitle, Convert.ToString(el.AlbumNumber), el.GenreName, el.Duration };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackListView.Items.Add(listViewItem);
                }
                else
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), "сольный", Convert.ToString(el.AlbumNumber), el.GenreName, el.Duration };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackListView.Items.Add(listViewItem);
                }
            }
        }

        private void addTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Mixed (BatchNumber,ID_Track) VALUES ("
                    + id_disk + ","
                    + trackListView.SelectedItems[0].Text + ");");

                MenuDiskForm.instance.UpdateQuantity();

                MessageBox.Show("Трек успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
