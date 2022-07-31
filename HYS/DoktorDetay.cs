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
    public partial class DoktorDetay : Form
    {
        public string drtc;
        public DoktorDetay()
        {
            InitializeComponent();
        }

        private void DoktorDetay_Load(object sender, EventArgs e)
        {
            lbldoktordetaydoktortc.Text = drtc;
        }
    }
}
