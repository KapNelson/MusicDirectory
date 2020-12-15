using System;
using System.Windows.Forms;

namespace MusicDirectory
{
    public partial class LoginForm : Form
    {
        public static LoginForm instance;
        private string currUser;
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

            MusicDirectoryContext db = new MusicDirectoryContext();

            var users = db.Users;
            
            foreach (Users el in users)
            {
                if(loginUser == el.Login && passUser == el.Password)
                {
                    if (!el.Admin)
                    {
                        MenuUserForm form = new MenuUserForm();
                        currUser = loginUser;
                        form.Show();
                    }
                    else
                    {
                        MenuAdminForm form = new MenuAdminForm();
                        form.Show();
                    }
                    connect = true;
                    break;
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
