using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityProjeUygulama
{
    public partial class FormIstatistik : Form
    {
        public FormIstatistik()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FoormIstatistik_Load(object sender, EventArgs e)
        {
            label2.Text = db.Tbl_Kategoriler.Count().ToString();
            label3.Text = db.Tbl_Urunler.Count().ToString();
            label5.Text = db.Tbl_Musteriler.Count(x => x.DURUM == true).ToString();
            label7.Text = db.Tbl_Musteriler.Count(x => x.DURUM == false).ToString();
            label13.Text = db.Tbl_Urunler.Sum(y =>y.STOK).ToString();
            label21.Text = db.Tbl_Satislar.Sum(z => z.FIYAT).ToString()+" TL";
            label11.Text = (from x in db.Tbl_Urunler orderby x.FIYAT descending select x.URUNAD).FirstOrDefault().ToString();
            label9.Text = (from x in db.Tbl_Urunler orderby x.FIYAT ascending select x.URUNAD).FirstOrDefault().ToString();
            label15.Text = db.Tbl_Urunler.Count(a => a.KATEGORI == 1).ToString();
            label23.Text = (from x in db.Tbl_Musteriler select x.SEHIR).Distinct().Count().ToString();
            label19.Text = db.MARKAGETIR1().FirstOrDefault().ToString();
            label17.Text = db.Tbl_Urunler.Count(x => x.URUNAD =="Buzdolabı").ToString();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
}
