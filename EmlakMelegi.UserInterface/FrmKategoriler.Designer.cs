namespace EmlakMelegi.UserInterface
{
    partial class FrmKategoriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKategoriler));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_kaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_sil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_guncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_temizle = new System.Windows.Forms.ToolStripButton();
            this.dataGridView_kategori = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_kategoriAdi = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kategori)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_kaydet,
            this.toolStripButton_sil,
            this.toolStripButton_guncelle,
            this.toolStripButton_temizle});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(369, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton_kaydet
            // 
            this.toolStripButton_kaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_kaydet.Image")));
            this.toolStripButton_kaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_kaydet.Name = "toolStripButton_kaydet";
            this.toolStripButton_kaydet.Size = new System.Drawing.Size(63, 22);
            this.toolStripButton_kaydet.Text = "Kaydet";
            this.toolStripButton_kaydet.Click += new System.EventHandler(this.toolStripButton_kaydet_Click);
            // 
            // toolStripButton_sil
            // 
            this.toolStripButton_sil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_sil.Image")));
            this.toolStripButton_sil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_sil.Name = "toolStripButton_sil";
            this.toolStripButton_sil.Size = new System.Drawing.Size(39, 22);
            this.toolStripButton_sil.Text = "Sil";
            this.toolStripButton_sil.Click += new System.EventHandler(this.toolStripButton_sil_Click);
            // 
            // toolStripButton_guncelle
            // 
            this.toolStripButton_guncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_guncelle.Image")));
            this.toolStripButton_guncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_guncelle.Name = "toolStripButton_guncelle";
            this.toolStripButton_guncelle.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton_guncelle.Text = "Güncelle";
            this.toolStripButton_guncelle.Click += new System.EventHandler(this.toolStripButton_guncelle_Click);
            // 
            // toolStripButton_temizle
            // 
            this.toolStripButton_temizle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_temizle.Image")));
            this.toolStripButton_temizle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_temizle.Name = "toolStripButton_temizle";
            this.toolStripButton_temizle.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton_temizle.Text = "Temizle";
            this.toolStripButton_temizle.Click += new System.EventHandler(this.toolStripButton_temizle_Click);
            // 
            // dataGridView_kategori
            // 
            this.dataGridView_kategori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_kategori.Location = new System.Drawing.Point(6, 19);
            this.dataGridView_kategori.Name = "dataGridView_kategori";
            this.dataGridView_kategori.Size = new System.Drawing.Size(338, 247);
            this.dataGridView_kategori.TabIndex = 1;
            this.dataGridView_kategori.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_kategori_CellDoubleClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kategori Adı:";
            // 
            // textBox_kategoriAdi
            // 
            this.textBox_kategoriAdi.Location = new System.Drawing.Point(119, 34);
            this.textBox_kategoriAdi.Name = "textBox_kategoriAdi";
            this.textBox_kategoriAdi.Size = new System.Drawing.Size(125, 20);
            this.textBox_kategoriAdi.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox_kategoriAdi);
            this.groupBox1.Location = new System.Drawing.Point(13, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(344, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Bilgileri";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView_kategori);
            this.groupBox2.Location = new System.Drawing.Point(13, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(344, 272);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kategori Listesi";
            // 
            // FrmKategoriler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 408);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmKategoriler";
            this.Text = "FrmKategoriler";
            this.Load += new System.EventHandler(this.FrmKategoriler_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_kategori)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton_kaydet;
        private System.Windows.Forms.ToolStripButton toolStripButton_sil;
        private System.Windows.Forms.ToolStripButton toolStripButton_guncelle;
        private System.Windows.Forms.ToolStripButton toolStripButton_temizle;
        private System.Windows.Forms.DataGridView dataGridView_kategori;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_kategoriAdi;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}