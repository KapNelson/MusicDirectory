using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class AddParticipationForm : Form
    {
        MusicDirectoryContext db = new MusicDirectoryContext();
        int idPerformer;
        public AddParticipationForm(int id)
        {
            InitializeComponent();
            idPerformer = id;
        }
        private void addInBandButton_Click(object sender, EventArgs e)
        {
            int numberOfRowInserted = db.Database.ExecuteSqlCommand("INSERT INTO Participation (ID_Artist,ID_Musician,YearOfEntry,YearOfLeaving,Role) VALUES (" + Convert.ToString(idPerformer) + "," + Convert.ToString(musicianListView.SelectedItems[0].Text) + "," + entryTextBox.Text + "," + leavingTextBox.Text + ",'" + roleTextBox.Text + "')");
            int numberOfRowUpdated = db.Database.ExecuteSqlCommand("UPDATE Band SET NumOfParticipants=NumOfParticipants+1 WHERE ID_Artist=" + Convert.ToString(idPerformer) + ";");
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
    }
}
