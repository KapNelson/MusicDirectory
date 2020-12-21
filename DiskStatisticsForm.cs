using System;
using System.Windows.Forms;
using System.Linq;

namespace MusicDirectory
{
    public partial class DiskStatisticsForm : Form
    {
        MusicDirectoryContext db = new MusicDirectoryContext();
        public DiskStatisticsForm()
        {
            InitializeComponent();
        }

        private void DiskStatisticsForm_Load(object sender, EventArgs e)
        {
            var groups = from p in db.Disk
                         group p by p.Manufacturer into g
                         select new { Name = g.Key, Count = g.Count() };
            foreach (var c in groups)
            {
                quantityDiskСhart.Series["Кол-во дисков"].Points.AddXY(c.Name, c.Count);
            }
        }
    }
}
