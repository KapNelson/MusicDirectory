using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class MenuAdminForm : Form
    {
        public static MenuAdminForm instance;
        MusicDirectoryContext db = new MusicDirectoryContext();
        
        public MenuAdminForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void MenuAdminForm_Load(object sender, EventArgs e)
        {           
            var users = db.Database.SqlQuery<Users>("SELECT * FROM Users");
            foreach (var el in users)
            {
                string[] str = new string[] { el.Login, el.Password, Convert.ToString(el.Admin) };
                ListViewItem listViewItem = new ListViewItem(str);
                usersListView.Items.Add(listViewItem); 
            }

            PrintTrack();
            PrintAlbum();
            PrintGenre();
            PrintMusInstr();
            PrintMusician();
            PrintPerformer();

            var performer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer");
            foreach (var el in performer)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Artist), el.ArtistName };
                ListViewItem listViewItem = new ListViewItem(str);
                trackPerListView.Items.Add(listViewItem);
            }
            var genre = db.Database.SqlQuery<Genre>("SELECT * FROM Genre");
            foreach (var el in genre)
            {
                trackGenreListBox.Items.Add(el.GenreName);
            }
            var album = db.Database.SqlQuery<Album>("SELECT * FROM Album");
            foreach (var el in album)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackAlbumListView.Items.Add(listViewItem);
            }
        }
        private void PrintTrack()
        {
            var track = db.Track;
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), el.Album.AlbumTitle, Convert.ToString(el.AlbumNumber), el.GenreName, el.Duration };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }
        private void PrintAlbum()
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
                string[] str1 = new string[] { Convert.ToString(el.ID_Musician), el.FullName, Convert.ToString(el.DateOfBirth) };
                ListViewItem listViewItem1 = new ListViewItem(str1);
                musicianListView.Items.Add(listViewItem1);

                string[] str2 = new string[] { Convert.ToString(el.ID_Musician), el.FullName, Convert.ToString(el.DateOfBirth) };
                ListViewItem listViewItem2 = new ListViewItem(str2);
                soloMusListView.Items.Add(listViewItem2);
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
        private void PrintSolo(int id_musician)
        {
            var musician = db.Musician;
            foreach (Musician el in musician)
            {
                if (el.ID_Musician == Convert.ToInt32(id_musician))
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Musician), el.FullName, "сольный", "сольный", "сольный" };
                    ListViewItem listViewItem = new ListViewItem(str);
                    musPerListView.Items.Add(listViewItem);
                    numPerTextBox.Text = "сольный";
                }
            }
        }
        private void PrintParticipation(string id_performer)
        {
            var part = db.Participation;
            foreach (Participation el in part)
            {
                if (el.ID_Artist == Convert.ToInt32(id_performer))
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Musician), el.Musician.FullName, Convert.ToString(el.YearOfEntry), Convert.ToString(el.YearOfLeaving), el.Role };
                    ListViewItem listViewItem = new ListViewItem(str);
                    musPerListView.Items.Add(listViewItem);
                    numPerTextBox.Text = Convert.ToString(el.Band.NumOfParticipants);
                }
            }

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
                    PrintAlbum();

                    trackAlbumListView.Items.Clear();
                    var album = db.Database.SqlQuery<Album>("SELECT * FROM Album");
                    foreach (var el in album)
                    {
                        string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear) };
                        ListViewItem listViewItem = new ListViewItem(str);
                        trackAlbumListView.Items.Add(listViewItem);
                    }

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

                trackAlbumListView.Items.Clear();
                var album = db.Database.SqlQuery<Album>("SELECT * FROM Album");
                foreach (var el in album)
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Album), el.AlbumTitle, Convert.ToString(el.AlbumRecYear) };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackAlbumListView.Items.Add(listViewItem);
                }

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

                trackGenreListBox.Items.Clear();
                var genre = db.Database.SqlQuery<Genre>("SELECT * FROM Genre");
                foreach (var el in genre)
                {
                    trackGenreListBox.Items.Add(el.GenreName);
                }

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

                genreListBox.Items.Remove(genreTextBox2.Text);

                trackGenreListBox.Items.Remove(genreTextBox2.Text);

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
                    soloMusListView.Items.Clear();
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

                trackPerListView.Items.Clear();
                var performer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer");
                foreach (var el in performer)
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Artist), el.ArtistName };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackPerListView.Items.Add(listViewItem);
                }

                int id_performer = 0;
                var lastPer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer WHERE ID_Artist=(SELECT MAX(ID_Artist) FROM Performer);");

                foreach (var el in lastPer)
                {
                    id_performer = el.ID_Artist;
                }

                if (soloRadioButton.Checked)
                {
                    int numberOfRowUpdated2 = db.Database.ExecuteSqlCommand("INSERT INTO Solo (ID_Artist,ID_Musician) VALUES (" + Convert.ToString(id_performer) + "," + soloMusListView.SelectedItems[0].Text + ");");
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

                trackPerListView.Items.Clear();
                var performer = db.Database.SqlQuery<Performer>("SELECT * FROM Performer");
                foreach (var el in performer)
                {
                    string[] str = new string[] { Convert.ToString(el.ID_Artist), el.ArtistName };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackPerListView.Items.Add(listViewItem);
                }

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

            var solo = db.Solo;
            bool isSolo = false;
            foreach (Solo el in solo)
            {
                if (el.ID_Artist == Convert.ToInt32(performerListView.SelectedItems[0].Text))
                {
                    PrintSolo(Convert.ToInt32(el.ID_Musician));
                    isSolo = true;
                }
            }
            if(!isSolo)
            {
                PrintParticipation(performerListView.SelectedItems[0].Text);
            }
        }

        //Band/Solo/Participation
        private void addPartButton_Click(object sender, EventArgs e)
        {
            AddParticipationForm form = new AddParticipationForm(Convert.ToInt32(performerListView.SelectedItems[0].Text));
            form.Show();
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

        //Track
        private void addTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(yearRecTextBox.Text, out int result1) && int.TryParse(numTextBox.Text, out int result2))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Track (NameOfTrack, ID_Artist, TrackRecYear, ID_Album, AlbumNumber, GenreName, Duration) VALUES ('" 
                        + nameTextBox.Text + "'," 
                        + trackPerListView.SelectedItems[0].Text + "," 
                        + yearRecTextBox.Text + ","
                        + trackAlbumListView.SelectedItems[0].Text + ","
                        + numTextBox.Text + ",'" 
                        + genreTextBox.Text + "','" 
                        + durationTextBox.Text + "');");

                    trackListView.Items.Clear();
                    PrintTrack();


                    MessageBox.Show("Трек успешно добавлен!");
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

        private void updateTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(yearRecTextBox.Text, out int result1) && int.TryParse(numTextBox.Text, out int result2))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Track SET NameOfTrack='" + nameTextBox.Text
                        + "', ID_Artist=" + trackPerListView.SelectedItems[0].Text
                        + ", TrackRecYear=" + yearRecTextBox.Text 
                        + ", ID_Album=" + trackAlbumListView.SelectedItems[0].Text 
                        + ", AlbumNumber=" + numTextBox.Text 
                        + ", GenreName='" + genreTextBox.Text
                        + "', Duration='" + durationTextBox.Text
                        + "' WHERE ID_Track=" + trackListView.SelectedItems[0].Text + ";");

                     trackListView.SelectedItems[0].SubItems[1].Text = nameTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[2].Text = performerTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[3].Text = yearRecTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[4].Text = albumTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[5].Text = numTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[6].Text = genreTextBox.Text;
                     trackListView.SelectedItems[0].SubItems[7].Text = durationTextBox.Text;

                    MessageBox.Show("Трек успешно обновлён!");
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

        private void deleteTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Track WHERE ID_Track='" + trackListView.SelectedItems[0].Text + "';");
                trackListView.SelectedItems[0].Remove();

                MessageBox.Show("Трек успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackListView_Click(object sender, EventArgs e)
        {
            nameTextBox.Text = trackListView.SelectedItems[0].SubItems[1].Text;
            performerTextBox.Text = trackListView.SelectedItems[0].SubItems[2].Text;
            yearRecTextBox.Text = trackListView.SelectedItems[0].SubItems[3].Text;
            albumTextBox.Text = trackListView.SelectedItems[0].SubItems[4].Text;
            numTextBox.Text = trackListView.SelectedItems[0].SubItems[5].Text;
            genreTextBox.Text = trackListView.SelectedItems[0].SubItems[6].Text;
            durationTextBox.Text = trackListView.SelectedItems[0].SubItems[7].Text;
        }

        private void trackPerListView_Click(object sender, EventArgs e)
        {
            performerTextBox.Text = trackPerListView.SelectedItems[0].SubItems[1].Text;

        }

        private void trackGenreListBox_Click(object sender, EventArgs e)
        {
            genreTextBox.Text = trackGenreListBox.Text;
        }

        private void trackAlbumListView_Click(object sender, EventArgs e)
        {
            albumTextBox.Text = trackAlbumListView.SelectedItems[0].SubItems[1].Text;
        }
    }
}
// MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
