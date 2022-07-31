using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYS
{
    public partial class RolSec : Form
    {
        public RolSec()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HastaGiris hgiris = new HastaGiris();
            hgiris.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DoktorGiris dr = new DoktorGiris();
            dr.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SekreterGiris sg = new SekreterGiris();
            sg.Show();
            this.Hide();
        }
    }
}
