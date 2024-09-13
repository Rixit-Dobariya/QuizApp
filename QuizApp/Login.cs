using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizApp.database_files;

namespace QuizApp
{
    public partial class Login : UserControl
    {
        Users users;
        public Login()
        {
            InitializeComponent();
            users = new Users();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            MainForm mainForm = (MainForm)FindForm();
            
            if (users.ValidateAdmin(username, password))
            {
                mainForm.LoadUserControl(new MainAdmin());
                mainForm.LoadHeaderUserControl(new AdminHeader());
            }
            else if (users.ValidateUser(username, password))
            {
                MessageBox.Show("True");
            }
            else
            {
                MessageBox.Show("False");
            }
        }
    }
}
