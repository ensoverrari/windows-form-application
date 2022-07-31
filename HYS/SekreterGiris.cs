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
    public partial class SekreterGiris : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        
        public SekreterGiris()
        {
            InitializeComponent();
        }

        private void btnsekretergiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from Sekreter_tbl where SekreterTC=@p1 and SekreterSifre=@p2", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbsekretergiristc.Text);
            komut.Parameters.AddWithValue("@p2", tbsekretergirissifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                SekreterPanel sp = new SekreterPanel();
                sp.sekretertc = mtbsekretergiristc.Text;
                sp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC ya da Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
