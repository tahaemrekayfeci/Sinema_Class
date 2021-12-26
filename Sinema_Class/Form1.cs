using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sinema_Class
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        sinema s = new sinema();
        private void btn_yarat_Click(object sender, EventArgs e)
        {
            s.koltuk = int.Parse(txt_koltukyarat.Text);
            s.sayi = s.sayi + s.koltuk;
        }

        private void btn_satis_Click(object sender, EventArgs e)
        {
            if (rdb_indirimlialis.Checked == true)
            {
                s.indirimalis = true;
            }
            else
            {
                s.indirimalis = false;
            }
            s.biletsatis();

        }

        private void btn_iptal_Click(object sender, EventArgs e)
        {
            if (rdb_indirimliiptal.Checked == true)
            {
                s.indirimiptal = true;
            }
            else
            {
                s.indirimiptal = false;
            }
            s.biletiptal();
           
        }

        private void btn_bakiye_Click(object sender, EventArgs e)
        {
            s.bakiyesorgula();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.boskoltuksorgula();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
