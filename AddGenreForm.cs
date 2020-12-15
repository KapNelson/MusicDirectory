using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class AddGenreForm : Form
    {
        public AddGenreForm()
        {
            InitializeComponent();
        }

        private void addGenreButton_Click(object sender, EventArgs e)
        {
            MusicDirectoryContext db = new MusicDirectoryContext();
            Genre newGenre = new Genre { GenreName = genreTextBox.Text };
            db.Genre.Add(newGenre);
            db.SaveChanges();
            MenuAdminForm.instance.AddGenre(genreTextBox.Text);
            MessageBox.Show("Жанр успешно добавлен!");
        }
    }
}
