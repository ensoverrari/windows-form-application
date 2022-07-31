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
    public partial class HastaKayit : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        
        
        public HastaKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand hkayit = new SqlCommand("insert into Hasta_tbl (HastaAd,HastaSoyad,HastaTC,HastaTel,HastaSifre,HastaCinsiyet) values (@h1,@h2,@h3,@h4,@h5,@h6)", bgl.baglanti());
            hkayit.Parameters.AddWithValue("@h1", tbhastakayitad.Text);
            hkayit.Parameters.AddWithValue("@h2", tbhastakayitsoyad.Text);
            hkayit.Parameters.AddWithValue("@h3", mtbhastakayittc.Text);
            hkayit.Parameters.AddWithValue("@h4", mtbhastakayittel.Text);
            hkayit.Parameters.AddWithValue("@h5",tbhastakayitsifre.Text);
            hkayit.Parameters.AddWithValue("@h6", cbhastakayitcinsiyet.SelectedItem);
            hkayit.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleştirilmiştir.");
            this.Hide();
        }
    }
}
