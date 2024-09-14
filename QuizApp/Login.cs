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

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
            MainForm mainForm = (MainForm)FindForm();
            if (username.Equals(""))
            {
                errorMessage1.Text = "Username can't be empty!";
            }
            else if (username.Length < 5)
            {
                errorMessage1.Text = "Username can't be shorter than 5 letters!";
            }
            else if (username.Length > 50)
            {
                errorMessage1.Text = "Username can't be lengthier than 50 letters!";
            }
            else
            {
                errorMessage1.Text = "";
            }

            if (password.Equals(""))
            {
                errorMessage2.Text = "Password can't be empty!";
            }
            else if (password.Length < 6)
            {
                errorMessage2.Text = "password can't be shorter than 6 letters!";
            }
            else if (password.Length > 50)
            {
                errorMessage2.Text = "password can't be lengthier than 50 letters!";
            }
            else
            {
                errorMessage2.Text = "";
            }

            if(errorMessage1.Text.Equals("") && errorMessage2.Text.Equals(""))
            {
                if (users.ValidateAdmin(username, password))
                {
                    errorMessage1.Text = "";
                    errorMessage2.Text = "";
                    mainForm.LoadUserControl(new MainAdmin());
                    mainForm.LoadHeaderUserControl(new AdminHeader());
                }
                else if (users.ValidateUser(username, password))
                {
                    errorMessage1.Text = "";
                    errorMessage2.Text = "";
                    MessageBox.Show("True");
                }
                else
                {
                    errorMessage1.Text = "";
                    errorMessage2.Text = "";
                    MessageBox.Show("Either password or username is wrong!");
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            mainForm.LoadUserControl(new Register());
        }
    }
}
