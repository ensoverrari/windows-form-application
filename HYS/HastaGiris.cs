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
    
    public partial class HastaGiris : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        
        public HastaGiris()
        {
            InitializeComponent();
        }

        private void btnhastagiris_Click(object sender, EventArgs e)
        {
            SqlCommand hg = new SqlCommand("Select * from Hasta_Tbl where HastaTC=@h1 and HastaSifre=@h2", bgl.baglanti());
            hg.Parameters.AddWithValue("@h1", mtbhastagiristc.Text);
            hg.Parameters.AddWithValue("@h2", tbhastagirissifre.Text);
            SqlDataReader dr = hg.ExecuteReader();
            if (dr.Read())
            {
                HastaneDetayRandevu hdr = new HastaneDetayRandevu();
                hdr.tc = mtbhastagiristc.Text;
                hdr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC yada Şifre!");
            }
            bgl.baglanti().Close();
        }

        private void lnklblhastagirisuyeol_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            HastaKayit hk = new HastaKayit();
            hk.Show();

        }
    }
}
