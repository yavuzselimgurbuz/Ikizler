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
    public partial class frmStok : Form
    {
        public frmStok()
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
            //gridStok.AutoGenerateColumns = false;
            DataTable dt = db.Fill("SELECT * FROM tblStok");
            gridStok.DataSource = dt;
        }
        #endregion

        private void frmStok_Load(object sender, EventArgs e)
        {
            dataGetir();
        }
    }
}
