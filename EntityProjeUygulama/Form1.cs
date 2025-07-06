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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        public void Listele()
        {
            var kategoriler = db.Tbl_Kategoriler.ToList();
            dataGridView1.DataSource = kategoriler;
        }
        private void listelebttn_Click(object sender, EventArgs e)
        {
            Listele();
        }

        private void eklebttn_Click(object sender, EventArgs e)
        {
            Tbl_Kategoriler t = new Tbl_Kategoriler();    
            t.KATEGORIAD = adtxtbox.Text;
            db.Tbl_Kategoriler.Add(t);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori Eklendi.");
            

        }

        private void silbttn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxtbox.Text);
            var ktgr = db.Tbl_Kategoriler.Find(id);
            db.Tbl_Kategoriler.Remove(ktgr);
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori Silindi");
        }

        private void güncellebttn_Click(object sender, EventArgs e)
        {
            int id = int.Parse(idtxtbox.Text);
            var ktgr = db.Tbl_Kategoriler.Find(id);
            ktgr.KATEGORIAD = adtxtbox.Text;
            db.SaveChanges();
            Listele();
            MessageBox.Show("Kategori Güncellendi.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            idtxtbox.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            adtxtbox.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }
    }
}
