using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class MenuAdminForm : Form
    {
        public static MenuAdminForm instance;
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
            MusicDirectoryContext db = new MusicDirectoryContext();

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
            MusicDirectoryContext db = new MusicDirectoryContext();
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

        private SqlConnection sqlConnection = null;
        private SqlCommandBuilder sqlBuilder = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private bool newRowAdding = false;
        public void LoadDataTrack()
        {
            try 
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Command] FROM Track", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Track");
                trackDataGridView.DataSource = dataSet.Tables["Track"];

                for (int i = 0; i < trackDataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    trackDataGridView[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadDataTrack()
        {
            try
            {
                dataSet.Tables["Track"].Clear();

                sqlDataAdapter.Fill(dataSet, "Track");
                trackDataGridView.DataSource = dataSet.Tables["Track"];

                for (int i = 0; i < trackDataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    trackDataGridView[8, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*public void LoadDataUsers()
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter("SELECT *, 'Delete' AS [Command] FROM Users", sqlConnection);
                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);
                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();
                sqlDataAdapter.Fill(dataSet, "Users");
                usersDataGridView.DataSource = dataSet.Tables["Users"];

                for (int i = 0; i < usersDataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    usersDataGridView[3, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ReloadDataUsers()
        {
            try
            {
                dataSet.Tables["Users"].Clear();

                sqlDataAdapter.Fill(dataSet, "Users");
                usersDataGridView.DataSource = dataSet.Tables["Users"];

                for (int i = 0; i < usersDataGridView.Rows.Count; i++)
                {
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    trackDataGridView[3, i] = linkCell;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/
        private void MenuAdminForm_Load(object sender, EventArgs e)
        {
           
            string connectionString = "data source=DESKTOP-0NEUOAJ;initial catalog=MusicDirectory;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework";
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            
            MusicDirectoryContext db = new MusicDirectoryContext();
            
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
           
            LoadDataTrack();
            //LoadDataUsers();
        }

        private void trackDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if(e.ColumnIndex == 8)
                {
                    string task = trackDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();

                    if(task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            trackDataGridView.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["Track"].Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(dataSet, "Track");
                        }
                    }
                    else if(task == "Insert")
                    {
                        if (MessageBox.Show("Добавить новую строку?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = trackDataGridView.Rows.Count - 2;
                            DataRow row = dataSet.Tables["Track"].NewRow();

                            row["NameOfTrack"] = trackDataGridView.Rows[rowIndex].Cells["NameOfTrack"].Value;
                            row["TrackRecYear"] = trackDataGridView.Rows[rowIndex].Cells["TrackRecYear"].Value;
                            row["ID_Artist"] = trackDataGridView.Rows[rowIndex].Cells["ID_Artist"].Value;
                            row["Duration"] = trackDataGridView.Rows[rowIndex].Cells["Duration"].Value;
                            row["AlbumNumber"] = trackDataGridView.Rows[rowIndex].Cells["AlbumNumber"].Value;
                            row["GenreName"] = trackDataGridView.Rows[rowIndex].Cells["GenreName"].Value;
                            row["ID_Album"] = trackDataGridView.Rows[rowIndex].Cells["ID_Album"].Value;

                            dataSet.Tables["Track"].Rows.Add(row);
                            dataSet.Tables["Track"].Rows.RemoveAt(dataSet.Tables["Track"].Rows.Count - 1);
                            trackDataGridView.Rows.RemoveAt(trackDataGridView.Rows.Count - 2);
                            trackDataGridView.Rows[e.RowIndex].Cells[8].Value = "Delete";

                            sqlDataAdapter.Update(dataSet, "Track");
                            newRowAdding = false;
                        }
                    }
                    else if(task == "Update")
                    {
                        if (MessageBox.Show("Обновить строку?", "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int r = e.RowIndex;

                            dataSet.Tables["Track"].Rows[r]["NameOfTrack"] = trackDataGridView.Rows[r].Cells["NameOfTrack"].Value;
                            dataSet.Tables["Track"].Rows[r]["TrackRecYear"] = trackDataGridView.Rows[r].Cells["TrackRecYear"].Value;
                            dataSet.Tables["Track"].Rows[r]["ID_Artist"] = trackDataGridView.Rows[r].Cells["ID_Artist"].Value;
                            dataSet.Tables["Track"].Rows[r]["Duration"] = trackDataGridView.Rows[r].Cells["Duration"].Value;
                            dataSet.Tables["Track"].Rows[r]["AlbumNumber"] = trackDataGridView.Rows[r].Cells["AlbumNumber"].Value;
                            dataSet.Tables["Track"].Rows[r]["GenreName"] = trackDataGridView.Rows[r].Cells["GenreName"].Value;
                            dataSet.Tables["Track"].Rows[r]["ID_Album"] = trackDataGridView.Rows[r].Cells["ID_Album"].Value;

                            sqlDataAdapter.Update(dataSet, "Track");

                            trackDataGridView.Rows[e.RowIndex].Cells[8].Value = "Delete";
                        }
                    }

                    ReloadDataTrack();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if(newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = trackDataGridView.Rows.Count - 2;
                    DataGridViewRow row = trackDataGridView.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    trackDataGridView[8, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex = trackDataGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = trackDataGridView.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    trackDataGridView[8, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackDataGridView_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            e.Control.KeyPress -= new KeyPressEventHandler(Column_KeyPress);

            if(trackDataGridView.CurrentCell.ColumnIndex == 2 || trackDataGridView.CurrentCell.ColumnIndex == 4 || trackDataGridView.CurrentCell.ColumnIndex == 6 || trackDataGridView.CurrentCell.ColumnIndex == 7)
            {
                TextBox textBox = e.Control as TextBox;

                if(textBox != null)
                {
                    textBox.KeyPress += new KeyPressEventHandler(Column_KeyPress);
                }
            }
        }

        private void Column_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void reloadTrackButton_Click(object sender, EventArgs e)
        {
            ReloadDataTrack();
        }

       /* private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 8)
                {
                    string task = usersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                    if (task == "Delete")
                    {
                        if (MessageBox.Show("Удалить эту строку?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = e.RowIndex;
                            usersDataGridView.Rows.RemoveAt(rowIndex);
                            dataSet.Tables["Users"].Rows[rowIndex].Delete();
                            sqlDataAdapter.Update(dataSet, "Users");
                        }
                    }
                    else if (task == "Insert")
                    {
                        if (MessageBox.Show("Добавить новую строку?", "Добавление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int rowIndex = usersDataGridView.Rows.Count - 2;
                            DataRow row = dataSet.Tables["Users"].NewRow();

                            row["Login"] = usersDataGridView.Rows[rowIndex].Cells["Login"].Value;
                            row["Password"] = usersDataGridView.Rows[rowIndex].Cells["Password"].Value;
                            row["Admin"] = usersDataGridView.Rows[rowIndex].Cells["Admin"].Value;

                            dataSet.Tables["Users"].Rows.Add(row);
                            dataSet.Tables["Users"].Rows.RemoveAt(dataSet.Tables["Users"].Rows.Count - 1);
                            usersDataGridView.Rows.RemoveAt(usersDataGridView.Rows.Count - 2);
                            usersDataGridView.Rows[e.RowIndex].Cells[3].Value = "Delete";

                            sqlDataAdapter.Update(dataSet, "Users");
                            newRowAdding = false;
                        }
                    }
                    else if (task == "Update")
                    {
                        if (MessageBox.Show("Обновить строку?", "Обновление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            int r = e.RowIndex;

                            dataSet.Tables["Users"].Rows[r]["Login"] = usersDataGridView.Rows[r].Cells["Login"].Value;
                            dataSet.Tables["Users"].Rows[r]["Password"] = usersDataGridView.Rows[r].Cells["Password"].Value;
                            dataSet.Tables["Users"].Rows[r]["Admin"] = usersDataGridView.Rows[r].Cells["Admin"].Value;

                            sqlDataAdapter.Update(dataSet, "Users");

                            usersDataGridView.Rows[e.RowIndex].Cells[3].Value = "Delete";
                        }
                    }

                    ReloadDataUsers();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    newRowAdding = true;
                    int lastRow = usersDataGridView.Rows.Count - 2;
                    DataGridViewRow row = usersDataGridView.Rows[lastRow];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    usersDataGridView[3, lastRow] = linkCell;
                    row.Cells["Command"].Value = "Insert";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void usersDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (newRowAdding == false)
                {
                    int rowIndex =usersDataGridView.SelectedCells[0].RowIndex;

                    DataGridViewRow editingRow = usersDataGridView.Rows[rowIndex];
                    DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                    usersDataGridView[3, rowIndex] = linkCell;
                    editingRow.Cells["Command"].Value = "Update";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reloadUsersButton_Click(object sender, EventArgs e)
        {
            ReloadDataUsers();
        }*/
    }
}
