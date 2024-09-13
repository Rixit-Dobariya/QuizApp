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
            users.AddUsers(username, password);
            MessageBox.Show("You have successfully registered");

            txtName.Text = "";
            txtPassword.Text = "";
            MainForm mainForm = (MainForm)FindForm();
            mainForm.LoadUserControl(new Login());
        }
    }
}
