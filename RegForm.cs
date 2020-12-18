using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        private void addUserButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginTextBox.Text;
            string passUser = passwordTextBox.Text;
            string repassUser = repasswordTextBox.Text;
            string roleUser = roleComboBox.Text;
            bool c = false;

            MusicDirectoryContext db = new MusicDirectoryContext();
            
            var users = db.Users;

            foreach (Users el in users)
            {
                if (loginUser == el.Login)
                {
                    MessageBox.Show("Пользователь с таким логином уже существует!\nПовторите попытку!");
                    c = true;
                }
            }
            if(!c)
            {
                if (passUser == repassUser)
                {
                    Users newUser = new Users { Login = loginUser, Password = passUser, Admin = roleUser };
                    db.Users.Add(newUser);
                    db.SaveChanges();
                    this.Close();
                    MessageBox.Show("Пользователь успешно зарегестрирован!");
                }
                else
                {
                    MessageBox.Show("Пароли не совпадают!\nПовторите попытку!");
                }
            }
        }
    }
}
