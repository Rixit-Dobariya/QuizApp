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
    public partial class LoginHeader : UserControl
    {
        public LoginHeader()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            mainForm.LoadUserControl(new Login());
        }


        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)FindForm();
            mainForm.LoadUserControl(new Register());
        }
    }
}
