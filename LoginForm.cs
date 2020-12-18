using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        private string currUser;
        private MusicDirectoryContext db = new MusicDirectoryContext();
        public string GetUser()
        {
            return currUser;
        }
        public LoginForm()
        {
            InitializeComponent();
            instance = this;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string loginUser = loginTextBox.Text;
            string passUser = passwordTextBox.Text;
            bool connect = false;

            var users = db.Database.SqlQuery<Users>("SELECT * FROM Users");      
            
            foreach (Users el in users)
            {
                if(loginUser == el.Login && passUser == el.Password)
                {
                    string role = el.Admin;
                    switch (role)
                    {
                        case "Пользователь":
                            MenuUserForm form1 = new MenuUserForm();
                            currUser = loginUser;
                            form1.Show();
                            break;
                        case "Администратор":
                            MenuAdminForm form2 = new MenuAdminForm();
                            form2.Show();
                            break;
                        case "Производитель":
                            MenuDiskForm form3 = new MenuDiskForm();
                            form3.Show();
                            break;
                    }                  
                    connect = true;
                }
            }  
            if(!connect)
            {
                MessageBox.Show("Вы ввели неверный логин или пароль!\nПовторите попытку!");
            }
        }

        private void regButton_Click(object sender, EventArgs e)
        {
            RegForm form = new RegForm();
            form.Show();
        }
    }
}
