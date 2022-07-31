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
    public partial class DoktorEkleSil : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public DoktorEkleSil()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand drekle = new SqlCommand("insert into Doktor_tbl (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTC,DoktorSifre) values (@dr1,@dr2,@dr3,@dr4,@dr5)", bgl.baglanti());
            drekle.Parameters.AddWithValue("@dr1", tbdoktoreklesilad.Text);
            drekle.Parameters.AddWithValue("@dr2", tbdoktoreklesilsoyad.Text);
            drekle.Parameters.AddWithValue("@dr3", cbdoktoreklesilbrans.Text);
            drekle.Parameters.AddWithValue("@dr4", mtbdoktoreklesiltc.Text);
            drekle.Parameters.AddWithValue("@dr5", tbdoktoreklesilsifre.Text);
            drekle.ExecuteNonQuery();
            bgl.baglanti().Close();            
            MessageBox.Show("Doktor ekleme işlemi tamamlanmıştır.");
            tbdoktoreklesilad.Clear();
            tbdoktoreklesilsoyad.Clear();
            cbdoktoreklesilbrans.SelectedItem = 0;
            mtbdoktoreklesiltc.Clear();
            tbdoktoreklesilsifre.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlCommand drsil = new SqlCommand("delete from Doktor_tbl where DoktorTC=@p1", bgl.baglanti());
            drsil.Parameters.AddWithValue("@p1", mtbdoktoreklesiltc.Text);
            drsil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor şutlama işlemi başarıyla tamamlanmıştır.Gol.");
        }

        private void DoktorEkleSil_Load(object sender, EventArgs e)
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select * from Doktor_tbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView1.DataSource = dt1;

            //branş cbsine branşları çekme
            SqlCommand branscek = new SqlCommand("select BransAd from Brans_Tbl", bgl.baglanti());
            SqlDataReader dr2 = branscek.ExecuteReader();
            while (dr2.Read())
            {
                cbdoktoreklesilbrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();
        }

        //fare ile seçilen hücrenin satır bilgilerini datagride taşıma işlemi
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            tbdoktoreklesilad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            tbdoktoreklesilsoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            mtbdoktoreklesiltc.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            cbdoktoreklesilbrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            tbdoktoreklesilsifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand drguncelle = new SqlCommand("update Doktor_tbl set DoktorAd=@p1,DoktorSoyad=@p2,DoktorBrans=@p3,DoktorSifre=@p5 where DoktorTC=@p4", bgl.baglanti());
            drguncelle.Parameters.AddWithValue("@p1", tbdoktoreklesilad.Text);
            drguncelle.Parameters.AddWithValue("@p2", tbdoktoreklesilsoyad.Text);
            drguncelle.Parameters.AddWithValue("@p3", cbdoktoreklesilbrans.Text);
            drguncelle.Parameters.AddWithValue("@p4", mtbdoktoreklesiltc.Text);
            drguncelle.Parameters.AddWithValue("@p5", tbdoktoreklesilsifre.Text);
            drguncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor bilgileri güncellenmiştir.");
        }
    }
}
