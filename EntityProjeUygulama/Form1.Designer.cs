namespace EntityProjeUygulama
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.adtxtbox = new System.Windows.Forms.TextBox();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.listelebttn = new System.Windows.Forms.Button();
            this.eklebttn = new System.Windows.Forms.Button();
            this.silbttn = new System.Windows.Forms.Button();
            this.güncellebttn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kategori ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(22, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kategori Adı:";
            // 
            // adtxtbox
            // 
            this.adtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.adtxtbox.Location = new System.Drawing.Point(127, 61);
            this.adtxtbox.Name = "adtxtbox";
            this.adtxtbox.Size = new System.Drawing.Size(100, 26);
            this.adtxtbox.TabIndex = 2;
            // 
            // idtxtbox
            // 
            this.idtxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.idtxtbox.Location = new System.Drawing.Point(127, 23);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.Size = new System.Drawing.Size(100, 26);
            this.idtxtbox.TabIndex = 3;
            // 
            // listelebttn
            // 
            this.listelebttn.Location = new System.Drawing.Point(26, 115);
            this.listelebttn.Name = "listelebttn";
            this.listelebttn.Size = new System.Drawing.Size(75, 23);
            this.listelebttn.TabIndex = 4;
            this.listelebttn.Text = "Listele";
            this.listelebttn.UseVisualStyleBackColor = true;
            this.listelebttn.Click += new System.EventHandler(this.listelebttn_Click);
            // 
            // eklebttn
            // 
            this.eklebttn.Location = new System.Drawing.Point(107, 115);
            this.eklebttn.Name = "eklebttn";
            this.eklebttn.Size = new System.Drawing.Size(75, 23);
            this.eklebttn.TabIndex = 5;
            this.eklebttn.Text = "Ekle";
            this.eklebttn.UseVisualStyleBackColor = true;
            this.eklebttn.Click += new System.EventHandler(this.eklebttn_Click);
            // 
            // silbttn
            // 
            this.silbttn.Location = new System.Drawing.Point(107, 144);
            this.silbttn.Name = "silbttn";
            this.silbttn.Size = new System.Drawing.Size(75, 23);
            this.silbttn.TabIndex = 6;
            this.silbttn.Text = "Sil";
            this.silbttn.UseVisualStyleBackColor = true;
            this.silbttn.Click += new System.EventHandler(this.silbttn_Click);
            // 
            // güncellebttn
            // 
            this.güncellebttn.Location = new System.Drawing.Point(26, 144);
            this.güncellebttn.Name = "güncellebttn";
            this.güncellebttn.Size = new System.Drawing.Size(75, 23);
            this.güncellebttn.TabIndex = 7;
            this.güncellebttn.Text = "Güncelle";
            this.güncellebttn.UseVisualStyleBackColor = true;
            this.güncellebttn.Click += new System.EventHandler(this.güncellebttn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(251, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(528, 155);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 187);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.güncellebttn);
            this.Controls.Add(this.silbttn);
            this.Controls.Add(this.eklebttn);
            this.Controls.Add(this.listelebttn);
            this.Controls.Add(this.idtxtbox);
            this.Controls.Add(this.adtxtbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox adtxtbox;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.Button listelebttn;
        private System.Windows.Forms.Button eklebttn;
        private System.Windows.Forms.Button silbttn;
        private System.Windows.Forms.Button güncellebttn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

