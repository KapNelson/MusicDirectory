using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class MenuDiskForm : Form
    {
        public static MenuDiskForm instance;
        MusicDirectoryContext db = new MusicDirectoryContext();
        public MenuDiskForm()
        {
            InitializeComponent();
            instance = this;
        }

        public void UpdateQuantity()
        {
            int plus = Convert.ToInt32(diskListView.SelectedItems[0].SubItems[5].Text) + 1;
            int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Disk SET NumberOfTracks=" + Convert.ToString(plus)
                       + " WHERE BatchNumber=" + diskListView.SelectedItems[0].Text + ";");

            diskListView.SelectedItems[0].SubItems[5].Text = Convert.ToString(plus);

            progressBar.Value++;
        }

        private void PrintDisk()
        {
            var disk = db.Database.SqlQuery<Disk>("SELECT * FROM Disk;");
            foreach (var el in disk)
            {
                string[] str = new string[]
                {
                    Convert.ToString(el.BatchNumber),
                    el.DiskName,
                    el.Manufacturer,
                    Convert.ToString(el.ReleaseDate),
                    Convert.ToString(el.Circulation),
                    Convert.ToString(el.NumberOfTracks)
                };
                ListViewItem listViewItem = new ListViewItem(str);
                diskListView.Items.Add(listViewItem);
            }
        }

        private void MenuDiskForm_Load(object sender, EventArgs e)
        {
            progressBar.Maximum = 70;
            progressBar.Step = 1;
            progressBar.Value = 0;

            PrintDisk();

            var album = db.Database.SqlQuery<Album>("SELECT * FROM Album;");
            foreach (var el in album)
            {
                string[] str = new string[]
                {
                    Convert.ToString(el.ID_Album),
                    el.AlbumTitle, 
                    Convert.ToString(el.AlbumRecYear)
                };
                ListViewItem listViewItem = new ListViewItem(str);
                albumListView.Items.Add(listViewItem);
            }
        }

        private void addTrackButton_Click(object sender, EventArgs e)
        {
            if (mixRadioButton.Checked)
            {
                AddTrackForm form = new AddTrackForm(batchNumTextBox.Text);
                form.Show();
            }
        }

        private void deleteTrackButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mixRadioButton.Checked)
                {
                    int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Mixed WHERE ID_Track='" + trackListView.SelectedItems[0].Text + "';");
                    trackListView.SelectedItems[0].Remove();
                    progressBar.Value--;

                    int numberOfRowUpdated1 = db.Database.ExecuteSqlCommand("UPDATE Disk SET NumberOfTracks=NumberOfTracks-1 WHERE BatchNumber=" + diskListView.SelectedItems[0].Text + ";");
                    int minus = Convert.ToInt32(diskListView.SelectedItems[0].SubItems[5].Text) - 1;
                    diskListView.SelectedItems[0].SubItems[5].Text = Convert.ToString(minus);

                    MessageBox.Show("Трек успешно удалён!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Disk
        private void addDiskButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(batchNumTextBox.Text, out int result1) && DateTime.TryParse(dateTextBox.Text, out DateTime result2) && int.TryParse(circulTextBox.Text, out int result3))
                {
                    int count = 0;

                    if (albumRadioButton.Checked)
                    {
                        var track = db.Track;
                        foreach (var el in track)
                        {
                            if (el.ID_Album == Convert.ToInt32(albumListView.SelectedItems[0].Text))
                                count++;
                        }
                    }

                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("INSERT INTO Disk (BatchNumber,DiskName,Manufacturer,ReleaseDate,Circulation,NumberOfTracks) VALUES ("
                        + batchNumTextBox.Text + ",'"
                        + nameTextBox.Text + "','"
                        + makerTextBox.Text + "','"
                        + dateTextBox.Text + "',"
                        + circulTextBox.Text + ","
                        + Convert.ToString(count) + ");");

                    if (albumRadioButton.Checked)
                    {
                        int numberOfRowUpdated2 = db.Database.ExecuteSqlCommand("INSERT INTO Alyubomin (BatchNumber,ID_Album) VALUES ("
                        + batchNumTextBox.Text + ","
                        + albumListView.SelectedItems[0].Text + ");");
                    }

                    diskListView.Items.Clear();
                    PrintDisk();

                    MessageBox.Show("Диск успешно добавлен!");
                }
                else
                {
                    MessageBox.Show("Вы ввели некорректные данные!\nПовторите попытку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void updateDiskButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.TryParse(batchNumTextBox.Text, out int result1) && DateTime.TryParse(dateTextBox.Text, out DateTime result2) && int.TryParse(circulTextBox.Text, out int result3))
                {
                    int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Disk SET BatchNumber=" + batchNumTextBox.Text 
                        + ", DiskName='" + nameTextBox.Text 
                        + "', Manufacturer='" + makerTextBox.Text 
                        + "', ReleaseDate='" + dateTextBox.Text
                        + "', Circulation=" + circulTextBox.Text
                        + " WHERE BatchNumber=" + diskListView.SelectedItems[0].Text + ";");

                     diskListView.SelectedItems[0].SubItems[0].Text = batchNumTextBox.Text;
                     diskListView.SelectedItems[0].SubItems[1].Text = nameTextBox.Text;
                     diskListView.SelectedItems[0].SubItems[2].Text = makerTextBox.Text;
                     diskListView.SelectedItems[0].SubItems[3].Text = dateTextBox.Text;
                     diskListView.SelectedItems[0].SubItems[4].Text = circulTextBox.Text;

                    MessageBox.Show("Диск успешно обновлён!");
                }
                else
                {
                    MessageBox.Show("Вы ввели некорректные данные!\nПовторите попытку!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void deleteDiskButton_Click(object sender, EventArgs e)
        {
            try
            {
                int numberOfRowDeleted = db.Database.ExecuteSqlCommand("DELETE FROM Disk WHERE BatchNumber='" + diskListView.SelectedItems[0].Text + "';");
                diskListView.SelectedItems[0].Remove();

                MessageBox.Show("Диск успешно удалён!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void diskListView_Click(object sender, EventArgs e)
        {
            trackListView.Items.Clear();

            var disk = db.Database.SqlQuery<Disk>("SELECT * FROM Disk WHERE BatchNumber=" + diskListView.SelectedItems[0].Text + ";");
            var mix = db.Mixed;
            var alyubomin = db.Alyubomin;
            foreach (var el in disk)
            {
                progressBar.Value = el.NumberOfTracks;
            }
            foreach (var el in mix)
            {
                if (el.BatchNumber == Convert.ToInt32(diskListView.SelectedItems[0].Text))
                {
                    string[] str = new string[]
                    {
                        Convert.ToString(el.NumOnDisk),
                        Convert.ToString(el.Track.ID_Track),
                        el.Track.NameOfTrack,
                        el.Track.Performer.ArtistName,
                        Convert.ToString(el.Track.TrackRecYear)
                    };
                    ListViewItem listViewItem = new ListViewItem(str);
                    trackListView.Items.Add(listViewItem);
                    mixRadioButton.Checked = true;
                }
            }
            foreach (var el in alyubomin)
            {
                if (el.BatchNumber == Convert.ToInt32(diskListView.SelectedItems[0].Text))
                {                    
                    var track = db.Track;
                    foreach (var el2 in track)
                    {
                        if (el2.ID_Album == el.ID_Album)
                        {
                            string[] str = new string[]
                            {
                                Convert.ToString(el2.AlbumNumber),
                                Convert.ToString(el2.ID_Track),
                                el2.NameOfTrack,
                                el2.Performer.ArtistName,
                                Convert.ToString(el2.TrackRecYear)
                            };
                            ListViewItem listViewItem = new ListViewItem(str);
                            trackListView.Items.Add(listViewItem);
                        }
                    }
                    albumRadioButton.Checked = true;
                }
            }

            batchNumTextBox.Text = diskListView.SelectedItems[0].SubItems[0].Text;
            nameTextBox.Text = diskListView.SelectedItems[0].SubItems[1].Text;
            makerTextBox.Text = diskListView.SelectedItems[0].SubItems[2].Text;
            dateTextBox.Text = diskListView.SelectedItems[0].SubItems[3].Text;
            circulTextBox.Text = diskListView.SelectedItems[0].SubItems[4].Text;       
        }

        private void statisticButton_Click(object sender, EventArgs e)
        {
            DiskStatisticsForm form = new DiskStatisticsForm();
            form.Show();
        }
    }
}
