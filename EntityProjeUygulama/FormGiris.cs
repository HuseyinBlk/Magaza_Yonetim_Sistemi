﻿using System;
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
    public partial class FormGiris : Form
    {
        public FormGiris()
        {
            InitializeComponent();
        }

        DbEntityUrunEntities db = new DbEntityUrunEntities();
        private void FormGiriş_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.Tbl_Admin where x.ADMINAD == textBox1.Text && x.ADMINSIFRE == textBox2.Text select x;

            if (sorgu.Any())
            {
                FormAnaSayfa anaSayfa = new FormAnaSayfa();
                anaSayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
                textBox1.Text = "";
                textBox2.Text = "";
            }
        }
    }
}
