using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HYS
{
    public partial class HastaneDetayRandevu : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        
        public HastaneDetayRandevu()
        {
            InitializeComponent();
        }
        public string tc;
        private void HastaneDetayRandevu_Load(object sender, EventArgs e)
        {
            lblhastadetaytc.Text = tc;

            //ad soyad çekme
            SqlCommand komut = new SqlCommand("select HastaAd,HastaSoyad from Hasta_tbl where HastaTC=@h1", bgl.baglanti());
            komut.Parameters.AddWithValue("@h1", lblhastadetaytc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblhastadetayad.Text = dr[0].ToString();
                lblhastadetaysoyad.Text = dr[1].ToString();
            }
            bgl.baglanti().Close();

            //randavu geçmişi çekme
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevu_tbl where HastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //branş comboboxına veritabanından bilgi çekme
            SqlCommand branscek = new SqlCommand("select BransAd from Brans_Tbl", bgl.baglanti());
            SqlDataReader dr2 = branscek.ExecuteReader();
            while (dr2.Read())
            {
                cbhastadetaybrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            
            
        }

        private void cbhastadetaybrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbhastadetaydoktor.Items.Clear();
            SqlCommand doktorcek = new SqlCommand("select DoktorAd,DoktorSoyad from Doktor_tbl where DoktorBrans=@db1", bgl.baglanti());
            doktorcek.Parameters.AddWithValue("@db1", cbhastadetaybrans.Text);
            SqlDataReader dr3 = doktorcek.ExecuteReader();
            while (dr3.Read())
            {
                cbhastadetaydoktor.Items.Add(dr3[0] + " " + dr3[1]);
            }
            bgl.baglanti().Close();
        }

        private void cbhastadetaydoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from Randevu_tbl where RandevuBrans='" + cbhastadetaybrans.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView2.DataSource = dt;

        }

        private void lnklblhastakayitbilgigüncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaBilgiGuncelle bg = new HastaBilgiGuncelle();
            bg.TCno = lblhastadetaytc.Text;
            bg.Show();
            
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            tbhastadetayid.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cbhastadetaybrans.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
            cbhastadetaydoktor.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
