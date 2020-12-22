using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class DiskInfoForm : Form
    {
        private Track curTrack;
        public DiskInfoForm(Track t)
        {
            InitializeComponent();
            curTrack = t;
        }

        private void DiskInfoForm_Load(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            var mixed = db.Mixed;
            var alyubomin = db.Alyubomin;

            foreach (var el in alyubomin)
            {
                if(el.ID_Album == curTrack.ID_Album)
                {
                    Disk disk = db.Disk.Find(el.BatchNumber);
                    string[] str = new string[]
                    {
                        Convert.ToString(disk.BatchNumber),
                        disk.DiskName,
                        disk.Manufacturer,
                        Convert.ToString(disk.ReleaseDate),
                        Convert.ToString(disk.Circulation),
                        Convert.ToString(disk.NumberOfTracks)
                    };
                    ListViewItem listViewItem = new ListViewItem(str);
                    diskListView.Items.Add(listViewItem);
                }
            }

            foreach (var el in mixed)
            {
                if (el.ID_Track == curTrack.ID_Track)
                {
                    Disk disk = db.Disk.Find(el.BatchNumber);
                    string[] str = new string[]
                    {
                        Convert.ToString(disk.BatchNumber),
                        disk.DiskName,
                        disk.Manufacturer,
                        Convert.ToString(disk.ReleaseDate),
                        Convert.ToString(disk.Circulation),
                        Convert.ToString(disk.NumberOfTracks)
                    };
                    ListViewItem listViewItem = new ListViewItem(str);
                    diskListView.Items.Add(listViewItem);
                }
            }
        }
    }
}
