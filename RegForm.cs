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
            bool admin = adminCheckBox.Checked;
            bool c = false;

            Database.MusicDirectoryContext db = new Database.MusicDirectoryContext();
            
            var users = db.Users;

            foreach (Database.Users el in users)
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
                    Database.Users newUser = new Database.Users { Login = loginUser, Password = passUser, Admin = admin };
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
