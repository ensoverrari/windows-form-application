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
    public partial class BransEkleSil : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        
        public BransEkleSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand bekle = new SqlCommand("insert into Brans_tbl (BransAd) values (@b1)", bgl.baglanti());
            bekle.Parameters.AddWithValue("@b1", cbbranseklesilbrans.Text);
            bekle.ExecuteNonQuery();
            MessageBox.Show("Branş ekleme işlemi başarıyla tamamlanmıştır");
        }

        private void BransEkleSil_Load(object sender, EventArgs e)
        {
            //datagridde branşları listeleme
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Brans_tbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branş cbsine branşları çekme
            SqlCommand branscek = new SqlCommand("select BransAd from Brans_Tbl", bgl.baglanti());
            SqlDataReader dr2 = branscek.ExecuteReader();
            while (dr2.Read())
            {
               cbbranseklesilbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand branssil = new SqlCommand("delete from Brans_tbl where BransAd=@p1", bgl.baglanti());
            branssil.Parameters.AddWithValue("@p1", cbbranseklesilbrans.Text);
            branssil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş silme işlemi başarıyla tamamlanmıştır.");
        }

        private void cbbranseklesilbrans_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand brguncelle = new SqlCommand("update Brans_tbl set BransAd=@p1 where BransID=@p2", bgl.baglanti());
            brguncelle.Parameters.AddWithValue("@p1", cbbranseklesilbrans.Text);
            brguncelle.Parameters.AddWithValue("@p2", tbbranseklesilbransid.Text);
            brguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş bilgileri güncellenmiştir");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbbranseklesilbransid.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            cbbranseklesilbrans.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
