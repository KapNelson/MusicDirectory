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
    public partial class GroupeTrackForm : Form
    {
        MusicDirectoryContext db = new MusicDirectoryContext();
        public GroupeTrackForm()
        {
            InitializeComponent();
        }

        private void GroupeTrackForm_Load(object sender, EventArgs e)
        {
            var performer = db.Performer.OrderBy(p => p.ArtistName);

            foreach (var el in performer)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Artist), el.ArtistName };
                ListViewItem listViewItem = new ListViewItem(str);
                trackPerListView.Items.Add(listViewItem);
            }

            var genre = db.Genre.OrderBy(p => p.GenreName);

            foreach (var el in genre)
            {
                trackGenreListBox.Items.Add(el.GenreName);
            }

            var album = db.Album.OrderBy(p => p.AlbumTitle);

            foreach (var el in album)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackAlbumListView.Items.Add(listViewItem);
            }
        }

        private void groupeButton_Click(object sender, EventArgs e)
        {
            try
            {
                string sortType = groupeComboBox.Text;
                switch (sortType)
                {
                    case "Исполнитель":
                        MenuUserForm.instance.GropePerformer(Convert.ToInt32(trackPerListView.SelectedItems[0].Text));
                        break;
                    case "Жанр":
                        MenuUserForm.instance.GropeGenre(trackGenreListBox.Text);
                        break;
                    case "Альбом":
                        MenuUserForm.instance.GropeAlbum(Convert.ToInt32(trackAlbumListView.SelectedItems[0].Text));
                        break;
                    case "Год выпуска":
                        MenuUserForm.instance.GropeYear(Convert.ToInt32(yearTextBox.Text));
                        break;
                    case "Период времени":
                        MenuUserForm.instance.GropeBetweenYear(Convert.ToInt32(yearFirstTextBox.Text), Convert.ToInt32(yearSecondTextBox.Text));
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
