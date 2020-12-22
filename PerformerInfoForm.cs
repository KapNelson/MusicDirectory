using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class PerformerInfoForm : Form
    {
        private Track curTrack;
        public PerformerInfoForm(Track t)
        {
            InitializeComponent();
            curTrack = t;
        }

        private void PerformerInfoForm_Load(object sender, EventArgs e)
        {
            nameLabel.Text = curTrack.Performer.ArtistName;
            countryLabel.Text = curTrack.Performer.Country;
            bool band = true;

            MusicDirectoryContext db = new MusicDirectoryContext();
            var part = db.Participation;
            var solo = db.Solo;

            foreach (var el in solo)
            {
                if (el.ID_Artist == curTrack.ID_Artist)
                {
                    typeLabel.Text = "сольный";
                    Musician musician = db.Musician.Find(el.ID_Musician);
                    string[] str = new string[]
                    {
                        musician.FullName,
                        Convert.ToString(musician.DateOfBirth),
                    };
                    ListViewItem listViewItem = new ListViewItem(str);
                    musicianListView.Items.Add(listViewItem);
                    band = false;
                    break;
                }
            }

            if (band)
            {
                typeLabel.Text = "группа";
                foreach (var el in part)
                {
                    if (el.ID_Artist == curTrack.ID_Artist)
                    {
                        Musician musician = db.Musician.Find(el.ID_Musician);
                        string[] str = new string[]
                        {
                        musician.FullName,
                        Convert.ToString(musician.DateOfBirth),
                        Convert.ToString(el.YearOfEntry),
                        Convert.ToString(el.YearOfLeaving),
                        el.Role
                        };
                        ListViewItem listViewItem = new ListViewItem(str);
                        musicianListView.Items.Add(listViewItem);
                    }
                }
            }
        }
    }
}
