using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sinema_Class
{
    internal class sinema
    {
        public int koltuk,sayi,bakiye;
        public bool indirimalis, indirimiptal;
        public void biletsatis()
        {
            if (indirimiptal == true)
            {
                bakiye = bakiye + 50;
                koltuk = koltuk + 1;
            }
            else
            {
                bakiye = bakiye + 100;
                koltuk = koltuk - 1;
            }
            
        }
        public void biletiptal()
        {
            if (indirimiptal==true)
            {
                bakiye = bakiye - 50;
                koltuk = koltuk + 1;
            }
            else
            {
                bakiye = bakiye - 100;
                koltuk = koltuk + 1;
            }
            
        }
        public void boskoltuksorgula()
        {
            System.Windows.Forms.MessageBox.Show(koltuk.ToString());
        }
        public void bakiyesorgula()
        {
            System.Windows.Forms.MessageBox.Show(bakiye.ToString());
        }
    }
}
