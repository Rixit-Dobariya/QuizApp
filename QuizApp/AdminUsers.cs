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
using System.Data;

namespace QuizApp
{
    public partial class AdminUsers : UserControl
    {
        Users users;
        public AdminUsers()
        {
            InitializeComponent();
            users = new Users();
            LoadUsers();
        }
        void LoadUsers()
        {
            DataSet ds = users.GetUsers("Admin");
            foreach(DataRow dr in ds.Tables[0].Rows)
            {
                guna2DataGridView1.Rows.Add(dr["UserId"], dr["Username"], dr["Password"],"Update","Delete");
            }
        }
    }
}
