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
    public partial class SekreterPanel : Form
    {
        SqlBaglanti bgl = new SqlBaglanti();
        public string sekretertc;
        public SekreterPanel()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SekreterPanel_Load(object sender, EventArgs e)
        {
            //sekreter bilgi çekme
            lblsekretertc.Text = sekretertc;
            SqlCommand komut = new SqlCommand("select SekreterAdSoyad from Sekreter_tbl where SekreterTC=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblsekretertc.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblsekreteradsoyad.Text = dr[0].ToString();
            }
            bgl.baglanti().Close();

            //branş cbsine branş tblden branşları çekme
            SqlCommand branscek = new SqlCommand("select BransAd from Brans_Tbl", bgl.baglanti());
            SqlDataReader dr2 = branscek.ExecuteReader();
            while (dr2.Read())
            {
                cbsekreterpanelrandevubrans.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();

            //doktor cbsine doktor tblsinden doktor çekme


            //branşları datagride aktarma
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select BransID as SıraNo,BransAd from Brans_tbl", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //doktorları datagride aktarma
            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select DoktorID as SıraNo,(DoktorAd+' '+DoktorSoyad) as DrAdSoyad,DoktorBrans from Doktor_tbl", bgl.baglanti());
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;

        }

        private void cbsekreterpanelrandevudoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbsekreterpanelrandevubrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbsekreterpanelrandevudoktor.Items.Clear();

            SqlCommand doktorekle = new SqlCommand("Select DoktorAd,DoktorSoyad from Doktor_tbl where DoktorBrans=@p1", bgl.baglanti());
            doktorekle.Parameters.AddWithValue("@p1", cbsekreterpanelrandevubrans.Text);
            SqlDataReader dr = doktorekle.ExecuteReader();
            while (dr.Read())
            {
                cbsekreterpanelrandevudoktor.Items.Add(dr[0] + " " + dr[1]);
            }
            bgl.baglanti().Close();
        }

        private void btnsekreterpanelbransekle_Click(object sender, EventArgs e)
        {
            BransEkleSil bes = new BransEkleSil();
            bes.Show();
        }

        private void btnsekreterpanelrandevukaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutkaydet = new SqlCommand("insert into Randevu_tbl (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) values (@r1,@r2,@r3,@r4)", bgl.baglanti());
            komutkaydet.Parameters.AddWithValue("@r1", mtbsekreterpanelrandevutarih.Text);
            komutkaydet.Parameters.AddWithValue("@r2", mtbsekreterpanelrandevusaat.Text);
            komutkaydet.Parameters.AddWithValue("@r3", cbsekreterpanelrandevubrans.Text);
            komutkaydet.Parameters.AddWithValue("@r4", cbsekreterpanelrandevudoktor.Text);
            komutkaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturulmuştur.");
        }

        private void btnsekreterpanelduyuruolustur_Click(object sender, EventArgs e)
        {
            SqlCommand duyuruolustur = new SqlCommand("insert into Duyuru_tbl (Duyuru) values (@d1)", bgl.baglanti());
            duyuruolustur.Parameters.AddWithValue("@d1", rtbsekreterpanelduyuru.Text);
            duyuruolustur.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru başarıyla oluşturulmuştur.");
            rtbsekreterpanelduyuru.Clear();
        }

        private void btnsekreterpaneldoktorekle_Click(object sender, EventArgs e)
        {
            DoktorEkleSil dreklesil = new DoktorEkleSil();
            dreklesil.Show();
        }

        private void btnsekreterpanelrandevulistele_Click(object sender, EventArgs e)
        {
            RandevuListesi gecis = new RandevuListesi();
            gecis.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Duyurular duy = new Duyurular();
            duy.Show();
        }
    }
}
