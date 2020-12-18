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
    public partial class AddParticipationForm : Form
    {
        public static AddParticipationForm instance;
        MusicDirectoryContext db = new MusicDirectoryContext();
        int idPerformer;
        public AddParticipationForm(int id)
        {
            InitializeComponent();
            idPerformer = id;
        }
        public void UpdateListView()
        {
            musicianListView.Items.Clear();
            var musician = db.Database.SqlQuery<Musician>("SELECT * FROM Musician");
            foreach (var el in musician)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Musician), el.FullName };
                ListViewItem listViewItem = new ListViewItem(str);
                musicianListView.Items.Add(listViewItem);
            }
        }

        private void addInBandButton_Click(object sender, EventArgs e)
        {
            int numberOfRowInserted = db.Database.ExecuteSqlCommand("INSERT INTO Participation (ID_Artist,ID_Musician,YearOfEntry,YearOfLeaving) VALUES (" + Convert.ToString(idPerformer) + "," + Convert.ToString(musicianListView.SelectedItems[0].Text) + "," + entryTextBox.Text + "," + leavingTextBox.Text + ")");
            MessageBox.Show("Музыкант успешно добавлен в группу!");
        }

        private void AddParticipationForm_Load(object sender, EventArgs e)
        {
            var musician = db.Database.SqlQuery<Musician>("SELECT * FROM Musician");
            foreach (var el in musician)
            {
                string[] str = new string[] { Convert.ToString(el.ID_Musician), el.FullName };
                ListViewItem listViewItem = new ListViewItem(str);
                musicianListView.Items.Add(listViewItem);
            }
        }

        private void addPerformerButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Исполнитель успешно добавлен!");
        }
    }
}
