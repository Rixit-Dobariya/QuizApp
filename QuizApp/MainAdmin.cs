using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp
{
    public partial class MainAdmin : UserControl
    {
        public MainAdmin()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminQuizes());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminDashboard());
        }
        public void LoadUserControl(UserControl userControl)
        {
            guna2Panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(userControl);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AdminUsers());
        }

        private void MainAdmin_Load(object sender, EventArgs e)
        {

        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            LoadUserControl(new AddQuiz());
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {

        }
    }
}
