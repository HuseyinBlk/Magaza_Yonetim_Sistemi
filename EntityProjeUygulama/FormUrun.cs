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
    public partial class FormUrun : Form
    {
        public FormUrun()
        {
            InitializeComponent();
        }
        DbEntityUrunEntities db = new DbEntityUrunEntities();   

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void listelebttn_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = (from x in db.Tbl_Urunler select new
            {
                x.URUNID,
                x.URUNAD,
                x.MARKA,
                x.STOK,
                x.FIYAT,
                x.Tbl_Kategoriler.KATEGORIAD,
                x.DURUM
            }).ToList();
        }

        private void eklebttn_Click(object sender, EventArgs e)
        {
            Tbl_Urunler urun = new Tbl_Urunler();
            urun.URUNAD = adTxt.Text;
            urun.MARKA = markaTxt.Text;
            urun.STOK = short.Parse(stokTxt.Text);
            urun.KATEGORI = int.Parse(comboBox1.Text);
            urun.FIYAT = decimal.Parse(fiyatTxt.Text);
            urun.DURUM = true;
            db.Tbl_Urunler.Add(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün Sisteme Kaydedildi.");

        }

        private void silbttn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtxt.Text);
            var urun = db.Tbl_Urunler.Find(x);
            db.Tbl_Urunler.Remove(urun);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla silindi.");
        }

        private void guncellebttn_Click(object sender, EventArgs e)
        {
            int x = int.Parse(idtxt.Text);
            var urun = db.Tbl_Urunler.Find(x);
            urun.URUNAD = adTxt.Text;
            urun.MARKA = markaTxt.Text;
            urun.STOK = short.Parse(stokTxt.Text);
            db.SaveChanges();
            MessageBox.Show("Ürün başarıyla güncellendi.");
        }

        private void FormUrun_Load(object sender, EventArgs e)
        {
            var kategoriler = (from x in db.Tbl_Kategoriler
                               select new
                               { x.KATEGORIID, 
                                 x.KATEGORIAD }
                               ).ToList();

            comboBox1.ValueMember = "KATEGORIID";
            comboBox1.DisplayMember = "KATEGORIAD";
            comboBox1.DataSource = kategoriler;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idtxt.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adTxt.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            markaTxt.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            stokTxt.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            fiyatTxt.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            DurumTxt.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
            comboBox1.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }
    }
}
