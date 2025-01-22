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
    public partial class AdminForm : Form
    {
        private string _username;
        public AdminForm(string username)
        {
            InitializeComponent();
            _username = username;

            name.Text = $"Welcome, {_username}";
            time.Interval = 1000;
            time.Tick += time_Tick;
            time.Start();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void time_Tick(object sender, EventArgs e)
        {
            txtJam.Text = DateTime.Now.ToString("yyyy:MM:dd , HH:mm:ss");
        }

        private void BtnJad_Click(object sender, EventArgs e)
        {
            FormJadwal formJadwal = new FormJadwal();
            formJadwal.Show();
            this.Hide();
        }

        private void BtnRaw_Click(object sender, EventArgs e)
        {
            RawatInap rawatInap = new RawatInap();
            rawatInap.Show();
            this.Hide();
        }
    }
}
