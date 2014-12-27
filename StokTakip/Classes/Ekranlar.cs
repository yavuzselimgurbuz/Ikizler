using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StokTakip.Classes
{
    class Ekranlar
    {
        public void urunEkle()
        {
            UrunEkle urun = new UrunEkle();
            urun.ShowDialog();
        }
        public void stokEkle()
        {
            frmStok stok = new frmStok();
            stok.ShowDialog();
        }
        public void musteri()
        {
            frmMusteri musteri = new frmMusteri();
            musteri.ShowDialog();
        }
        public void satis()
        {
            satis satis = new satis();
            satis.ShowDialog();
        }
        public void musteriler()
        {
            frmMusteriler musteriler = new frmMusteriler();
            musteriler.ShowDialog();
        }
        public void gunluk()
        {
            frmGunluksatis gunluksatis = new frmGunluksatis();
            gunluksatis.ShowDialog();
        }
        public void aylik()
        {
            frmAyliksatis ayliksatis = new frmAyliksatis();
            ayliksatis.ShowDialog();
        }
    }
}
