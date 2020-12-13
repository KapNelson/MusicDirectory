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
    public partial class MenuUserForm : Form
    {
        [System.Runtime.InteropServices.DllImport("winmm.dll")]
        private static extern Boolean PlaySound(string lpszName, int hModule, int dwFlags);
        WMPLib.WindowsMediaPlayer WMP = new WMPLib.WindowsMediaPlayer();
        bool p = true;
        public MenuUserForm()
        {
            InitializeComponent();
        }

        private void MenuUserForm_Load(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            var track = db.Track;

            foreach(Track el in track)
            {
                string[] str = new string[] { el.NameOfTrack, el.Performer.ArtistName, Convert.ToString(el.TrackRecYear) };
                ListViewItem listViewItem = new ListViewItem(str);
                //listViewItem.Tag = el;
                trackListView.Items.Add(listViewItem);
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            WMP.URL = @"D:\Projects\VisualStudioProdjects\MusicDirectory\Resources\Music\" + trackListView.SelectedItems[0].Text +".mp3";
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

            MusicDirectoryContext db = new MusicDirectoryContext();
            var track = db.Track;

            foreach (Track el in track)
            {
                if (trackListView.SelectedItems[0].Text == el.NameOfTrack)
                    TrackInfoForm.instance.InfoTrack(el.ID_Track);
            }
            form.Show();
        }
    }
}
