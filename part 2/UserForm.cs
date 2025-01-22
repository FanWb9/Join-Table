using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace part_2
{
    public partial class UserForm : Form
    {
        private string _username;
        public UserForm(string username)
        {
            InitializeComponent();
            _username = username;
            tol.Text = $"welcome,{_username}";
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }
    }
}
