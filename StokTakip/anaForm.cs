using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }
        #region Class Tanımlamaları
        DbClass db = new DbClass();
        Classes.Ekranlar ekran = new Classes.Ekranlar();
        Classes.MesajKutusu mesaj = new Classes.MesajKutusu();
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.urunEkle();
            
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void stokEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.stokEkle();
        }

        private void müşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.musteri();
        }

        private void satışİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.satis();
        }

        private void müşterilerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ekran.musteriler();
        }

        private void günlükRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.gunluk();
        }

        private void aylıkRaporToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ekran.aylik();
        }
    }
}
