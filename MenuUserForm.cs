using System;
using System.Linq;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class MenuUserForm : Form
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern Boolean PlaySound(string lpszName, int hModule, int dwFlags);
        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        private bool p = true;
        private bool myPlaylist = false;
        MusicDirectoryContext db = new MusicDirectoryContext();

        public MenuUserForm()
        {
            InitializeComponent();
        }
        private void MenuUserForm_Load(object sender, EventArgs e)
        {
            var track = db.Track.OrderBy(p => p.NameOfTrack);

            foreach (Track el in track)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
                ListViewItem listViewItem = new ListViewItem(str);
                trackListView.Items.Add(listViewItem);
            }

            sortComboBox.SelectedItem = "Название";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            WMP.URL = @"D:\Projects\VisualStudioProdjects\MusicDirectory\Resources\Music\" + trackListView.SelectedItems[0].SubItems[2].Text + " - "+ trackListView.SelectedItems[0].SubItems[1].Text + ".mp3";
            WMP.controls.play();
            p = true;
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (p)
            {
                WMP.controls.pause();
                p = false;
            }
            else
            {
                WMP.controls.play();
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
                            string[] str = new string[] { Convert.ToString(el.Track.ID_Track) ,el.Track.NameOfTrack, el.Track.Performer.ArtistName, Convert.ToString(el.Track.TrackRecYear) };
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
                    var track = db.Track;

                    foreach (Track el in track)
                    {
                        string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
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
                        if (trackListView.SelectedItems[0].Text == el.NameOfTrack)
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
                        if (trackListView.SelectedItems[0].Text == el.NameOfTrack)
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
                trackListView.Items.Clear();
                string sortType = sortComboBox.Text;
                switch (sortType)
                {
                    case "Название":
                        var trackName = db.Track.OrderBy(p => p.NameOfTrack);
                        foreach (Track el in trackName)
                        {
                            string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
                            ListViewItem listViewItem = new ListViewItem(str);
                            trackListView.Items.Add(listViewItem);
                        }
                        break;
                    case "Исполнитель":
                        var trackPer = db.Track.OrderBy(p => p.Performer.ArtistName);
                        foreach (Track el in trackPer)
                        {
                            string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
                            ListViewItem listViewItem = new ListViewItem(str);
                            trackListView.Items.Add(listViewItem);
                        }
                        break;
                    case "Год выпуска":
                        var trackYear = db.Track.OrderBy(p => p.TrackRecYear);
                        foreach (Track el in trackYear)
                        {
                            string[] str = new string[] { Convert.ToString(el.ID_Track), el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
                            ListViewItem listViewItem = new ListViewItem(str);
                            trackListView.Items.Add(listViewItem);
                        }
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
