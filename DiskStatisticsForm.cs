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

        private void QuantityDisk()
        {
            var query = from data in db.Disk
                         group data by data.Manufacturer into result
                        select new { Name = result.Key, Count = result.Count() };
            foreach (var c in query)
            {
                quantityDiskСhart.Series["Кол-во дисков"].Points.AddXY(c.Name, c.Count);
            }
        }

        private void SumCirculation()
        {
            var query = from data in db.Disk
                        group data by data.Manufacturer into result
                        select new
                        {
                            Name = result.Key,
                            Summa = result.Sum(i => i.Circulation)
                        };
            foreach (var c in query)
            {
                sumCirculationChart.Series["Сумарный тираж"].Points.AddXY(c.Name, c.Summa);
            }
        }

        private void SumTrack()
        {
            var query = from data in db.Disk
                        group data by data.Manufacturer into result
                        select new
                        {
                            Name = result.Key,
                            Summa = result.Sum(i => i.NumberOfTracks)
                        };
            foreach (var c in query)
            {
                sumTrackChart.Series["Сумма треков"].Points.AddXY(c.Name, c.Summa);
            }
        }

        private void YearRelease()
        {
            var query = from data in db.Disk
                        group data by data.ReleaseDate.Year into result
                        select new { Name = result.Key, Count = result.Count() };

            //yearChart.ChartAreas[0].AxisX.Minimum = 2000;
            //yearChart.ChartAreas[0].AxisX.Maximum = 2021;
            yearChart.ChartAreas[0].AxisX.Interval = 1;

            foreach (var c in query)
            {
                yearChart.Series["Выпущенные диски"].Points.AddXY(c.Name, c.Count);
            }
        }


        private void DiskStatisticsForm_Load(object sender, EventArgs e)
        {
            QuantityDisk();
            SumCirculation();
            SumTrack();
            YearRelease();
        }
    }
}
