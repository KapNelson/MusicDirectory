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
    public partial class AddMusicianForm : Form
    {
        MusicDirectoryContext db = new MusicDirectoryContext();
        public AddMusicianForm()
        {
            InitializeComponent();
        }

        private void addMusicianButton_Click(object sender, EventArgs e)
        {
            int numberOfRowInserted = db.Database.ExecuteSqlCommand("INSERT INTO Musician (FullName,DateOFBirth) VALUES ('"+nameTextBox.Text+"','"+Convert.ToDateTime(ageTextBox.Text)+"')");
            AddPerformerForm.instance.AddMusician(nameTextBox.Text);
            AddParticipationForm.instance.UpdateListView();
            //AddParticipationForm.instance.UpdateListView();
            MessageBox.Show("Музыкант успешно добавлен!");
            this.Close();
        }
    }
}
