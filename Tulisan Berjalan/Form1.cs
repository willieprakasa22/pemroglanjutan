using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tulisan_Berjalan
{
    public partial class frmTulisanBerjalan : Form
    {
        public frmTulisanBerjalan()
        {
            InitializeComponent();
        }

       
       

        private void btnKeluar_Click_1(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            lblAnimasi.Left -= 10;
            if (lblAnimasi.Left < -lblAnimasi.Width) lblAnimasi.Left = this.Width;
        }
    }
    }

