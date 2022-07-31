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
    public partial class DoktorGiris : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public DoktorGiris()
        {
            InitializeComponent();
        }

        private void btndoktorgiris_Click(object sender, EventArgs e)
        {
            SqlCommand drgiris = new SqlCommand("select * from Doktor_tbl where DoktorTC=@p1 and DoktorSifre=@p2", bgl.baglanti());
            drgiris.Parameters.AddWithValue("@p1", mtbdoktorgiristc.Text);
            drgiris.Parameters.AddWithValue("@p2", tbdoktorgirissifre.Text);
            SqlDataReader dr = drgiris.ExecuteReader();
            if (dr.Read())
            {
                DoktorDetay dd = new DoktorDetay();
                dd.drtc = mtbdoktorgiristc.Text;
                dd.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("TC ya da Şifre yanlış.Gene dene");
            }
            bgl.baglanti().Close();
        }

        private void DoktorGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
