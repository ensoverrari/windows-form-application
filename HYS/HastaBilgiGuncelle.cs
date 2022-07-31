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
    public partial class HastaBilgiGuncelle : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public HastaBilgiGuncelle()
        {
            InitializeComponent();
        }
        public string TCno;
        private void HastaBilgiGuncelle_Load(object sender, EventArgs e)
        {
            mtbhastagüncelletc.Text = TCno;
            SqlCommand komut = new SqlCommand("select * from Hasta_tbl where HastaTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", mtbhastagüncelletc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                tbhastagüncellead.Text = dr[1].ToString();
                tbhastagüncellesoyad.Text = dr[2].ToString();
                mtbhastagüncelletc.Text = dr[3].ToString();
                mtbhastagüncelletel.Text = dr[4].ToString();
                tbhastagüncellesifre.Text = dr[5].ToString();
                cbhastagüncellecinsiyet.Text = dr[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("update Hasta_tbl set HastaAd=@p1,HastaSoyad=@p2,HastaTel=@p3,HastaSifre=@p4 where HastaTC=@p5", bgl.baglanti());
            komut1.Parameters.AddWithValue("@p1", tbhastagüncellead.Text);
            komut1.Parameters.AddWithValue("@p2", tbhastagüncellesoyad.Text);
            komut1.Parameters.AddWithValue("@p3", mtbhastagüncelletel.Text);
            komut1.Parameters.AddWithValue("@p4", tbhastagüncellesifre.Text);
            komut1.Parameters.AddWithValue("@p5", mtbhastagüncelletc.Text);
            komut1.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz başarıyla güncellenmiştir.");
            this.Hide();

        }
    }
}
