using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using NAudio.Wave;

namespace MusicDirectory
{
    public partial class MenuUserForm : Form
    {
        //[System.Runtime.InteropServices.DllImport("winmm.dll")]
        //private static extern Boolean PlaySound(string lpszName, int hModule, int dwFlags);
        //WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        WaveOut waveOut = new WaveOut();
        private bool p = true;
        private bool myPlaylist = false;
        public static MenuUserForm instance;
        MusicDirectoryContext db = new MusicDirectoryContext();

        public MenuUserForm()
        {
            InitializeComponent();
            instance = this;
        }
        private void MenuUserForm_Load(object sender, EventArgs e)
        {
            var track = db.Track.OrderBy(p => p.NameOfTrack);

            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }

            sortComboBox.SelectedItem = "Название";
        }

        public void GropePerformer(int id_performer)
        {
            trackListView.Items.Clear();
            var track = db.Track.Where(p => p.ID_Artist == id_performer).OrderBy(p => p.NameOfTrack);
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }

        public void GropeGenre(string genre)
        {
            trackListView.Items.Clear();
            var track = db.Track.Where(p => p.GenreName == genre).OrderBy(p => p.NameOfTrack);
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }

        public void GropeAlbum(int id_album)
        {
            trackListView.Items.Clear();
            var track = db.Track.Where(p => p.ID_Album == id_album).OrderBy(p => p.NameOfTrack);
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }

        public void GropeYear(int year)
        {
            trackListView.Items.Clear();
            var track = db.Track.Where(p => p.TrackRecYear == year).OrderBy(p => p.NameOfTrack);
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }

        public void GropeBetweenYear(int first_year, int second_year)
        {
            trackListView.Items.Clear();
            var track = db.Track.Where(p => p.TrackRecYear >= first_year && p.TrackRecYear <= second_year).OrderBy(p => p.NameOfTrack);
            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            //WMP.URL = @"D:\Projects\VisualStudioProdjects\MusicDirectory\Resources\Music\" + trackListView.SelectedItems[0].SubItems[2].Text + " - "+ trackListView.SelectedItems[0].SubItems[1].Text + ".mp3";
            //WMP.controls.play();
            p = true;

            var track = db.Track;
            foreach (var el in track)
            {
                if (el.ID_Track == Convert.ToInt32(trackListView.SelectedItems[0].Text))
                {
                    var bytes = el.Audio;

                    Stream s = new MemoryStream(bytes);
                    WaveStream blockAlignedStream = new BlockAlignReductionStream(WaveFormatConversionStream.CreatePcmStream(new Mp3FileReader(s)));
                    waveOut.Init(blockAlignedStream);
                    waveOut.Play();
                    break;
                }
            }
            int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Track SET NumberOfPlays=NumberOfPlays+1 WHERE ID_Track=" + trackListView.SelectedItems[0].Text + ";");
            var t = db.Track.Find(Convert.ToInt32(trackListView.SelectedItems[0].Text));
            trackListView.SelectedItems[0].SubItems[4].Text = Convert.ToString(++t.NumberOfPlays);
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (p)
            {
                waveOut.Pause();
                p = false;
            }
            else
            {
                waveOut.Play();
                p = true;
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            TrackInfoForm form = new TrackInfoForm();
            var track = db.Track;

            foreach (Track el in track)
            {
                if (Convert.ToInt32(trackListView.SelectedItems[0].Text) == el.ID_Track)
                {
                    TrackInfoForm.instance.InfoTrack(el);
                    break;
                }
            }
            form.Show();
        }

        private void playlistButton_Click(object sender, EventArgs e)
        {
            try 
            {
                trackListView.Items.Clear();
                if (myPlaylist == false)
                {
                    playlistButton.Text = "Все треки";
                    addPlaylistButton.Text = "Удалить из плейлиста";
                    var playlist = db.Playlist;

                    foreach (Playlist el in playlist)
                    {
                        if (el.Login == LoginForm.instance.GetUser())
                        {
                            string[] str = new string[] { Convert.ToString(el.Track.ID_Track) ,el.Track.NameOfTrack, el.Track.Performer.ArtistName, Convert.ToString(el.Track.TrackRecYear), Convert.ToString(el.Track.NumberOfPlays) };
                            ListViewItem listViewItem = new ListViewItem(str);
                            trackListView.Items.Add(listViewItem);
                        }
                    }
                    myPlaylist = true;
                }
                else
                {
                    playlistButton.Text = "Мой плейлист";
                    addPlaylistButton.Text = "Добавить в мой плейлист";
                    var track = db.Track.OrderBy(p=>p.NameOfTrack);

                    foreach (Track el in track)
                    {
                        string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                        ListViewItem listViewItem = new ListViewItem(str);
                        trackListView.Items.Add(listViewItem);
                    }
                    myPlaylist = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}

        private void addPlaylistButton_Click(object sender, EventArgs e)
        {
            try 
            {
                var track = db.Track;
                if (myPlaylist == false)
                {
                    foreach (Track el in track)
                    {
                        if (trackListView.SelectedItems[0].Text == Convert.ToString(el.ID_Track))
                        {
                            Playlist newTrack = new Playlist
                            {
                                ID_Track = el.ID_Track,
                                Login = LoginForm.instance.GetUser()
                            };
                            db.Playlist.Add(newTrack);
                            MessageBox.Show("Трек успешно добавлен в плейлист!");
                            break;
                        }
                    }
                    db.SaveChanges();
                }
                else
                {
                    int id_track = 0;
                    foreach (Track el in track)
                    {
                        if (trackListView.SelectedItems[0].Text == Convert.ToString(el.ID_Track))
                        {
                            id_track = el.ID_Track;
                            break;
                        }
                    }
                    trackListView.SelectedItems[0].Remove();
                    int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Playlist WHERE ID_Track=" + Convert.ToString(id_track) + " AND Login='" + LoginForm.instance.GetUser() + "';");
                    MessageBox.Show("Трек успешно удалён из плейлиста!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (myPlaylist == false)
                {
                    trackListView.Items.Clear();
                    string sortType = sortComboBox.Text;
                    switch (sortType)
                    {
                        case "Название":
                            var trackName = db.Track.OrderBy(p => p.NameOfTrack);
                            foreach (Track el in trackName)
                            {
                                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                                ListViewItem listViewItem = new ListViewItem(str);
                                trackListView.Items.Add(listViewItem);
                            }
                            break;
                        case "Исполнитель":
                            var trackPer = db.Track.OrderBy(p => p.Performer.ArtistName);
                            foreach (Track el in trackPer)
                            {
                                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                                ListViewItem listViewItem = new ListViewItem(str);
                                trackListView.Items.Add(listViewItem);
                            }
                            break;
                        case "Год выпуска":
                            var trackYear = db.Track.OrderBy(p => p.TrackRecYear);
                            foreach (Track el in trackYear)
                            {
                                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                                ListViewItem listViewItem = new ListViewItem(str);
                                trackListView.Items.Add(listViewItem);
                            }
                            break;
                        case "Прослушано":
                            var trackPlay = db.Track.OrderByDescending(p => p.NumberOfPlays);
                            foreach (Track el in trackPlay)
                            {
                                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear), Convert.ToString(el.NumberOfPlays) };
                                ListViewItem listViewItem = new ListViewItem(str);
                                trackListView.Items.Add(listViewItem);
                            }
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void groupeButton_Click(object sender, EventArgs e)
        {
            if (myPlaylist == false)
            {
                GroupeTrackForm form = new GroupeTrackForm();
                form.Show();
            }
        }
    }
}
