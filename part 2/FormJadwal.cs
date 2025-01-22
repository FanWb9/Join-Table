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
using System.Data.Common;

namespace part_2
{
    public partial class FormJadwal : Form
    {
        public FormJadwal()
        {
            InitializeComponent();
        }

        private void FormJadwal_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable jadwal = GetJadwal();
                DgJadwal.DataSource = jadwal;
                DgJadwal.Columns["NamaDokter"].HeaderText = "Nama Dokter";
                DgJadwal.Columns["Spesialis"].HeaderText = "Spesialis";
                DgJadwal.Columns["Hari"].HeaderText = "Hari Praktek";
                DgJadwal.Columns["JamMulai"].HeaderText = "Mulai";
                DgJadwal.Columns["JamSelesai"].HeaderText = "Selesai";
                DgJadwal.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Terjadi kesahalan ");
            }
        }
        private DataTable GetJadwal()
        {
            string query = "Select NamaDokter,Spesialis,Hari,JamMulai,JamSelesai from DokterJadwal";
            using (SqlConnection conn = Database.GetConnection())
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "select NamaDokter,Spesialis,Hari,JamMulai,JamSelesai from DokterJadwal where NamaDokter like @search or Hari like @search";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search", "%"+txtSearch.Text+"%");
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgJadwal.DataSource = dt;
                    }
                }
            }
        }

        private void DgJadwal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) { 
                DataGridViewRow row = DgJadwal.Rows[e.RowIndex];

                TxtDoc.Text = row.Cells["NamaDokter"].Value.ToString(); 
                TxtSpe.Text = row.Cells["Spesialis"].Value.ToString();
                TxtHar.Text = row.Cells["Hari"].Value.ToString() ;  
                TxtMul.Text = row.Cells["JamMulai"].Value.ToString() ;
                TxtSel.Text = row.Cells["JamSelesai"].Value.ToString();

                TxtDoc.ReadOnly = true;
                TxtHar.ReadOnly = true;
                TxtMul.ReadOnly = true;
                TxtSel.ReadOnly = true;
                TxtSpe.ReadOnly = true;

            }
        }
    }
}
