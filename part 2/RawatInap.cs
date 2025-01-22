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
   
    public partial class RawatInap : Form
    {
      
        private bool _isUpdate = false;
        private int Updte;
        public RawatInap()
        {
            InitializeComponent();
        }

        private void DgRaw_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void ViewRawatInap()
        {
            using (SqlConnection conn = Database.GetConnection())
            {
                conn.Open();
                string query = "Select Pasien.Nama as 'Nama Pasien',Kamar.NamaKamar as'Nama Kamar',kamar.TipeKamar as 'Tipe Kamar',kamar.Harga as 'Harga Kamar',RawatInap.TanggalMasuk as 'Tanggal masuk',RawatInap.TanggalKeluar as 'Tanggal Keluar' From RawatInap Inner Join pasien on RawatInap.IdPasien = Pasien.id Inner Join kamar on RawatInap.IdKamar = kamar.id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgRaw.DataSource = dt;

                    }
                }
            }
            btnInser.Enabled = true;
            btnCan.Enabled = true;
            btnUp.Enabled = true;
            btnSav.Enabled = false;
            btnCan.Enabled = false;

            txtHr.Enabled = false;
            txtName.Enabled = false;
            txtNmK.Enabled = false; 
            txtTk.Enabled = false;
            tgIn.Enabled = false;
            TgOut.Enabled = false;
        }

        private void opentxt()
        {
            txtTk.Enabled = true;
            txtNmK.Enabled=true;
            txtHr.Enabled=true;
            txtName.Enabled=true;
            tgIn.Enabled=true;
            TgOut.Enabled=true;
        }

        private void RawatInap_Load(object sender, EventArgs e)
        {
            ViewRawatInap();
         
        }

        private void txtSear_TextChanged(object sender, EventArgs e)
        {
            using (SqlConnection conn = Database.GetConnection()) { 
                conn.Open();
                string query = @"
                SELECT 
                    Pasien.Nama AS 'Nama Pasien',
                    Kamar.NamaKamar AS 'Nama Kamar',
                    kamar.TipeKamar AS 'Tipe Kamar',
                    kamar.Harga AS 'Harga Kamar',
                    RawatInap.TanggalMasuk AS 'Tanggal Masuk',
                    RawatInap.TanggalKeluar AS 'Tanggal Keluar'
                FROM 
                    RawatInap
                INNER JOIN 
                    Pasien ON RawatInap.IdPasien = Pasien.Id
                INNER JOIN 
                    Kamar ON RawatInap.IdKamar = Kamar.Id
                WHERE 
                    Pasien.Nama LIKE @search OR
                    Kamar.NamaKamar LIKE @search";

                using(SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@search","%"+txtSear.Text+"%");
                    using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        da.Fill(dt);
                        DgRaw.DataSource = dt;
                    }
                }
            }

        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            btnCan.Enabled = true;
            btnSav.Enabled = true;
            btnDel.Enabled = false;
            btnInser.Enabled = false;
            btnUp.Enabled = false;
            opentxt();
          
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnCan.Enabled = true;
            btnSav.Enabled = true;
            btnDel.Enabled = false;
            btnInser.Enabled = false;
            btnUp.Enabled = false;
            opentxt();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            btnCan.Enabled = true;
            btnSav.Enabled = true;
            btnDel.Enabled = false;
            btnInser.Enabled = false;
            btnUp.Enabled = false;
            opentxt();
        }

        private void btnCan_Click(object sender, EventArgs e)
        {
            btnCan.Enabled = false;
            btnSav.Enabled = false;
            btnDel.Enabled = true;
            btnInser.Enabled = true;
            btnUp.Enabled = true;
            ViewRawatInap();
           
        }

        private void btnSav_Click(object sender, EventArgs e)
        {
            btnCan.Enabled = false;
            btnSav.Enabled = false;
            btnDel.Enabled = true;
            btnInser.Enabled = true;
            btnUp.Enabled = true;
            ViewRawatInap();
        }
    }
}
