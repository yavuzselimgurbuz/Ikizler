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
    public partial class UrunEkle : Form
    {
        public UrunEkle()
        {
            InitializeComponent();
        }
        #region Class Tanımlamaları
        DbClass db = new DbClass();
        Classes.Ekranlar ekran = new Classes.Ekranlar();
        Classes.MesajKutusu mesaj = new Classes.MesajKutusu();
        #endregion

        #region Fonksiyonlar
        void dataGetir()
        {
            gridUrun.AutoGenerateColumns = false;
            DataTable dt = db.Fill("SELECT * FROM tblUrun");
            gridUrun.DataSource = dt;
        }
        #endregion

        private void UrunEkle_Load(object sender, EventArgs e)
        {
            dataGetir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            db.ExecuteNonQuery("INSERT INTO tblUrun(barkodNo,urunAdi,cinsi) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')");
            dataGetir();
        }


    }
}
