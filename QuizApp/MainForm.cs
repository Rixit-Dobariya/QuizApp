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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserControl(new Login());
            LoadHeaderUserControl(new LoginHeader());
        }
        public void LoadUserControl(UserControl userControl)
        {
            guna2Panel1.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            guna2Panel1.Controls.Add(userControl);
        }
        public void LoadHeaderUserControl(UserControl userControl)
        {
            guna2Panel2.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            guna2Panel2.Controls.Add(userControl);
        }


    }
}
