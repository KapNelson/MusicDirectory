using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class MenuAdminForm : Form
    {
        public static MenuAdminForm instance;
        MusicDirectoryContext db = new MusicDirectoryContext();
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
        public MenuAdminForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void addTrackButton_Click(object sender, EventArgs e)
        {
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
            AddPerformerForm form = new AddPerformerForm();
            var musician = db.Musician;
            foreach (Musician m in musician)
            {
                AddPerformerForm.instance.AddMusician(m.FullName);
            }
            form.Show();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            AddGenreForm form = new AddGenreForm();
            form.Show();
        }

        private void addAlbumButton_Click(object sender, EventArgs e)
        {
            AddAlbumForm form = new AddAlbumForm();
            form.Show();
        }
        private void MenuAdminForm_Load(object sender, EventArgs e)
        {           
            var performer = db.Performer;
            var genre = db.Genre;
            var album = db.Album;
            foreach (Performer p in performer)
            {
                AddPerformer(p.ArtistName);
            }
            foreach (Genre g in genre)
            {
                AddGenre(g.GenreName);
            }
            foreach (Album a in album)
            {
               AddAlbum(a.AlbumTitle);
            }
            var users = db.Database.SqlQuery<Users>("SELECT * FROM Users");
            foreach (var el in users)
            {
                string[] str = new string[] { el.Login, el.Password, Convert.ToString(el.Admin) };
                ListViewItem listViewItem = new ListViewItem(str);
                usersListView.Items.Add(listViewItem); 
            }
            var albums = db.Database.SqlQuery<Album>("SELECT * FROM Album");
            foreach (var el in albums)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear), Convert.ToString(el.NumOfTracks) };
                ListViewItem listViewItem = new ListViewItem(str);
                albumListView.Items.Add(listViewItem);
            }
        }
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Users WHERE Login='" + usersListView.SelectedItems[0].Text + "';");
            usersListView.SelectedItems[0].Remove();
            MessageBox.Show("Пользователь успешно удалён!");
        }

        private void deleteAlbumButton_Click(object sender, EventArgs e)
        {
            int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Album WHERE ID_Album='" + albumListView.SelectedItems[0].Text + "';");
            albumListView.SelectedItems[0].Remove();
            MessageBox.Show("Альбом успешно удалён!");
        }

        private void updateAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(yearRecAlbumTextBox.Text, out int result1)&&int.TryParse(numAlbumTextBox.Text, out int result2))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Album SET AlbumTitle='" + nameAlbumTextBox.Text +
                                    "', AlbumRecYear=" + yearRecAlbumTextBox.Text + ", NumOfTracks=" + numAlbumTextBox.Text +
                                    " WHERE ID_Album=" + albumListView.SelectedItems[0].Text + ";");

                    albumListView.SelectedItems[0].SubItems[1].Text = nameAlbumTextBox.Text;
                    albumListView.SelectedItems[0].SubItems[2].Text = yearRecAlbumTextBox.Text;
                    albumListView.SelectedItems[0].SubItems[3].Text = numAlbumTextBox.Text;

                    MessageBox.Show("Альбом успешно обновлён!");
                }
                else
                {
                    MessageBox.Show("Вы ввели не число в числовое поле!\nПовторите попытку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void albumListView_Click(object sender, EventArgs e)
        {
            nameAlbumTextBox.Text = albumListView.SelectedItems[0].SubItems[1].Text;
            yearRecAlbumTextBox.Text = albumListView.SelectedItems[0].SubItems[2].Text;
            numAlbumTextBox.Text = albumListView.SelectedItems[0].SubItems[3].Text;
        }
    }
}
// MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
