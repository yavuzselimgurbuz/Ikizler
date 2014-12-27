using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakip.Classes
{
    class MesajKutusu
    {
        public void basarili(string islem)
        {
            MessageBox.Show(islem + " işlemi başarıyla tamamlandı.","Başarılı!!",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
        public void basarısız(string islem)
        {
            MessageBox.Show(islem + " işlemi tamamlanamadı.", "Başarısız!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
