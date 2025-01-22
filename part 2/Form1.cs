using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace part_2
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPass.Text)) {
                MessageBox.Show("enter your email or passowrd in the field ");
                return;
            }
            using (SqlConnection conn = Database.GetConnection()) {
                conn.Open();
                string query = "select role_id,username from users where username=@username and password=@password";
                using (SqlCommand cmd = new SqlCommand(query, conn)) { 
                cmd.Parameters.AddWithValue("@username",txtEmail.Text);
                cmd.Parameters.AddWithValue("@password",txtPass.Text);
                    using (SqlDataReader reader = cmd.ExecuteReader()) {
                        if (reader.Read()) {
                            int Roleid = reader.GetInt32(0);
                            string Username = reader.GetString(1);
                            this.Hide();
                            if (Roleid == 1)
                            {
                                AdminForm adminForm = new AdminForm(Username);
                                adminForm.Show();
                            }
                            else if (Roleid == 2) {
                                UserForm userForm = new UserForm(Username);
                                userForm.Show();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Invalid your email or password, please try again");
                        }
                    }
                }
            }
        }

        private void ChPass_CheckedChanged(object sender, EventArgs e)
        {
            
            if (ChPass.Checked) {
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtPass.UseSystemPasswordChar = true;
            }

        }
    }
}
