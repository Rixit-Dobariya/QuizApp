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
    public partial class Register : UserControl
    {
        Users users;
        public Register()
        {
            InitializeComponent();
            users = new Users();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtName.Text;
            string password = txtPassword.Text;
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
            //database validation
            if (errorMessage1.Text.Equals("") && errorMessage2.Text.Equals(""))
            {
                if (users.ValidateUsername(username))
                {
                    errorMessage1.Text = "Username is already taken!";
                }
                else
                {
                    users.AddUsers(username, password);
                    MessageBox.Show("You have successfully registered");

                    txtName.Text = "";
                    txtPassword.Text = "";
                    MainForm mainForm = (MainForm)FindForm();
                    mainForm.LoadUserControl(new Login());
                }
            }
            
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            mainForm.LoadUserControl(new Login());
        }
        
    }
}
