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
    public partial class frmMusteriler : Form
    {
        public frmMusteriler()
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
            //gridMusteri.AutoGenerateColumns = false;
            DataTable dt = db.Fill("SELECT * FROM tblMusteri");
            gridMusteri.DataSource = dt;
        }
        #endregion

        private void frmMusteriler_Load(object sender, EventArgs e)
        {
            dataGetir();
        }
    }
}
