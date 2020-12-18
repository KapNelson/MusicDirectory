using System;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
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

        //private void addPerformerButton_Click(object sender, EventArgs e)
        //{
        //    AddPerformerForm form = new AddPerformerForm();
        //    var musician = db.Musician;
        //    foreach (Musician m in musician)
        //    {
        //        AddPerformerForm.instance.AddMusician(m.FullName);
        //    }
        //    form.Show();
        //}

        //private void addGenreButton_Click(object sender, EventArgs e)
        //{
        //    AddGenreForm form = new AddGenreForm();
        //    form.Show();
        //}

        //private void addAlbumButton_Click(object sender, EventArgs e)
        //{
        //    AddAlbumForm form = new AddAlbumForm();
        //    form.Show();
        //}
        private void PrintAldum()
        {
            var albums = db.Database.SqlQuery<Album>("SELECT * FROM Album");
            foreach (var el in albums)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear), Convert.ToString(el.NumOfTracks) };
                ListViewItem listViewItem = new ListViewItem(str);
                albumListView.Items.Add(listViewItem);
            }
        }
        private void PrintGenre()
        {
            var genre = db.Database.SqlQuery<Genre>("SELECT * FROM Genre");
            foreach (var el in genre)
            {
                genreListBox.Items.Add(el.GenreName);
            }
        }
        private void PrintMusInstr()
        {
            var musInstr = db.Database.SqlQuery<MusInstruments>("SELECT * FROM MusInstruments");
            foreach (var el in musInstr)
            {
                musInstrListBox.Items.Add(el.MusInstrumentName);
                musInstrAllComboBox.Items.Add(el.MusInstrumentName);
            }
        }
        private void PrintMusician()
        {
            var musician = db.Database.SqlQuery<Musician>("SELECT * FROM Musician");
            foreach (var el in musician)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Musician), el.FullName, Convert.ToString(el.DateOfBirth) };
                ListViewItem listViewItem = new ListViewItem(str);
                musicianListView.Items.Add(listViewItem);
            }
        }
        private void PrintPlayOn(string id_musician)
        {
            var playOn = db.PlayOn;
            foreach (PlayOn el in playOn)
            {
                if(el.ID_Musician == Convert.ToInt32(id_musician))
                    musInstrMusListBox.Items.Add(el.MusInstrumentName);
            }
        }
        private void PrintPerformer()
        {
            var performer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer");
            foreach (var el in performer)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Artist), el.ArtistName, el.Country };
                ListViewItem listViewItem = new ListViewItem(str);
                performerListView.Items.Add(listViewItem);
            }
        }
        private void PrintParticipation(string id_performer)
        {
            int id_band = 0;
            bool b = false;
            var solo = db.Solo;
            foreach (Solo el in solo)
            {
                if(el.ID_Artist == Convert.ToInt32(id_performer))
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Musician), el.Musician.FullName, "сольный", "сольный" };
                    ListViewItem listViewItem = new ListViewItem(str);
                    musPerListView.Items.Add(listViewItem);
                    numPerTextBox.Text = "сольный";
                }
            }

            var band = db.Band;
            foreach (Band el in band)
            {
                if (el.ID_Artist == Convert.ToInt32(id_performer))
                {
                    id_band = el.ID_Artist;
                    b = true;
                }
            }

            if(b)
            {
                var part = db.Participation;
                foreach (Participation el in part)
                {
                    if (el.ID_Artist == id_band)
                    {
                        string[] str = new string[] { Convert.ToString(el.ID_Musician), el.Musician.FullName, Convert.ToString(el.YearOfEntry), Convert.ToString(el.YearOfLeaving) };
                        ListViewItem listViewItem = new ListViewItem(str);
                        musPerListView.Items.Add(listViewItem);
                        numPerTextBox.Text = Convert.ToString(el.Band.NumOfParticipants);
                    }
                }
            }
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
            PrintAldum();
            PrintGenre();
            PrintMusInstr();
            PrintMusician();
            PrintPerformer();
        }
        //Users
        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Users WHERE Login='" + usersListView.SelectedItems[0].Text + "';");
            usersListView.SelectedItems[0].Remove();
            MessageBox.Show("Пользователь успешно удалён!");
        }

        //Album

        private void addAlbumButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(yearRecAlbumTextBox.Text, out int result1) && int.TryParse(numAlbumTextBox.Text, out int result2))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Album (AlbumTitle,AlbumRecYear,NumOfTracks) VALUES ('" + nameAlbumTextBox.Text +
                        "'," + yearRecAlbumTextBox.Text + "," + numAlbumTextBox.Text + ");");

                    albumListView.Items.Clear();
                    PrintAldum();

                    MessageBox.Show("Альбом успешно добавлен!");
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

        private void deleteAlbumButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Album WHERE ID_Album='" + albumListView.SelectedItems[0].Text + "';");
                albumListView.SelectedItems[0].Remove();
                MessageBox.Show("Альбом успешно удалён!");
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


        //Genre
        private void addGenreButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Genre (GenreName) VALUES ('" + genreTextBox2.Text +"');");

                genreListBox.Items.Clear();
                PrintGenre();

                MessageBox.Show("Жанр успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteGenreButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Genre WHERE GenreName='" + genreTextBox2.Text + "';");
                genreListBox.Items.Clear();
                PrintGenre();

                MessageBox.Show("Жанр успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void genreListBox_Click(object sender, EventArgs e)
        {
            genreTextBox2.Text = genreListBox.Text;
        }

        //MusInstruments
        private void addMusInstrButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO MusInstruments (MusInstrumentName) VALUES ('" + musInstrTextBox.Text + "');");

                musInstrListBox.Items.Clear();
                musInstrAllComboBox.Items.Clear();
                PrintMusInstr();

                MessageBox.Show("Муз.инструмент успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMusInstrButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM MusInstruments WHERE MusInstrumentName='" + musInstrTextBox.Text + "';");
                musInstrListBox.Items.Clear();
                musInstrAllComboBox.Items.Clear();
                musInstrMusListBox.Items.Remove(musInstrTextBox.Text);
                PrintMusInstr();

                MessageBox.Show("Муз.инструмент успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musInstrListBox_Click(object sender, EventArgs e)
        {
            musInstrTextBox.Text = musInstrListBox.Text;
        }

        //Musician
        private void addMusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(dateMusTextBox.Text, out DateTime result))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Musician (FullName,DateOfBirth) VALUES ('" + nameMusTextBox.Text +
                        "','" + dateMusTextBox.Text + "');");

                    musicianListView.Items.Clear();
                    PrintMusician();

                    MessageBox.Show("Музыкант успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Вы ввели не дату в поле для даты!\nПовторите попытку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateMusButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (DateTime.TryParse(dateMusTextBox.Text, out DateTime result))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Musician SET FullName='" + nameMusTextBox.Text +
                                    "', DateOfBirth='" + dateMusTextBox.Text +
                                    "' WHERE ID_Musician=" + musicianListView.SelectedItems[0].Text + ";");

                    musicianListView.SelectedItems[0].SubItems[1].Text = nameMusTextBox.Text;
                    musicianListView.SelectedItems[0].SubItems[2].Text = dateMusTextBox.Text;

                    MessageBox.Show("Музыкант успешно обновлён!");
                }
                else
                {
                    MessageBox.Show("Вы ввели не дату в поле для даты!\nПовторите попытку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteMusButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Musician WHERE ID_Musician='" + musicianListView.SelectedItems[0].Text + "';");
                musicianListView.SelectedItems[0].Remove();
                MessageBox.Show("Музыкант успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void musicianListView_Click(object sender, EventArgs e)
        {
            nameMusTextBox.Text = musicianListView.SelectedItems[0].SubItems[1].Text;
            dateMusTextBox.Text = musicianListView.SelectedItems[0].SubItems[2].Text;
            musInstrMusListBox.Items.Clear();
            PrintPlayOn(musicianListView.SelectedItems[0].Text);
        }

        //PlayOn
        private void addPlayOnButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO PlayOn (ID_Musician,MusInstrumentName) VALUES (" + musicianListView.SelectedItems[0].Text + ",'"+ musInstrAllComboBox.Text +"');");

                musInstrMusListBox.Items.Add(musInstrAllComboBox.Text);

                MessageBox.Show("Муз.инструмент успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePlayOnButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM PlayOn WHERE MusInstrumentName='" + musInstrMusListBox.Text + "' AND ID_Musician=" + musicianListView.SelectedItems[0].Text + ";");
                musInstrMusListBox.Items.Remove(musInstrAllComboBox.Text);

                MessageBox.Show("Муз.инструмент успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Performer
        private void addPerformerButton2_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Performer (ArtistName,Country) VALUES ('" + namePerTextBox.Text +
                "','" + countryTextBox.Text + "');");

                performerListView.Items.Clear();
                PrintPerformer();

                int id_performer = 0;
                var lastPer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer WHERE ID_Artist=(SELECT MAX(ID_Artist) FROM Performer);");

                foreach (var el in lastPer)
                {
                    id_performer = el.ID_Artist;
                }

                if (soloRadioButton.Checked)
                {
                    int numberOfRowUpdated2 = db.Database.ExecuteSqlCommand("INSERT INTO Solo (ID_Artist,ID_Musician) VALUES (" + Convert.ToString(id_performer) + ",NULL);");
                }
                else
                {
                    if (int.TryParse(numPerTextBox.Text, out int result))
                    {
                        int numberOfRowUpdated3 = db.Database.ExecuteSqlCommand("INSERT INTO Band (ID_Artist,NumOfParticipants) VALUES (" + Convert.ToString(id_performer) + "," + numPerTextBox.Text + ");");
                    }
                    else
                    {
                        MessageBox.Show("Вы ввели не число в числовое поле!\nПовторите попытку!");
                    }
                }

                MessageBox.Show("Исполнитель успешно добавлен!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updatePerformerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Performer SET ArtistName='" + namePerTextBox.Text +
                                "', Country='" + countryTextBox.Text +
                                "' WHERE ID_Artist=" + performerListView.SelectedItems[0].Text + ";");

                performerListView.SelectedItems[0].SubItems[1].Text = namePerTextBox.Text;
                performerListView.SelectedItems[0].SubItems[2].Text = countryTextBox.Text;

                MessageBox.Show("Исполнитель успешно обновлён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deletePerformerButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Performer WHERE ID_Artist='" + performerListView.SelectedItems[0].Text + "';");
                performerListView.SelectedItems[0].Remove();
                MessageBox.Show("Исполнитель успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void performerListView_Click(object sender, EventArgs e)
        {
            namePerTextBox.Text = performerListView.SelectedItems[0].SubItems[1].Text;
            countryTextBox.Text = performerListView.SelectedItems[0].SubItems[2].Text;
            musPerListView.Items.Clear();
            PrintParticipation(performerListView.SelectedItems[0].Text);
        }

        //Band/Solo/Participation
        private void addPartButton_Click(object sender, EventArgs e)
        {

        }

        private void deletePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Participation WHERE ID_Musician='" + musPerListView.SelectedItems[0].Text + "' AND ID_Artist=" + performerListView.SelectedItems[0].Text + ";");
                musPerListView.SelectedItems[0].Remove();

                MessageBox.Show("Музыкант успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
// MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
