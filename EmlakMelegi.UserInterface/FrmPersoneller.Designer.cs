namespace EmlakMelegi.UserInterface
{
    partial class FrmPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPersoneller));
            this.grp_bilgiler = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Adres = new System.Windows.Forms.TextBox();
            this.txt_Maas = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.mtxt_Tel = new System.Windows.Forms.MaskedTextBox();
            this.mtxt_tc = new System.Windows.Forms.MaskedTextBox();
            this.rb_Kadin = new System.Windows.Forms.RadioButton();
            this.rb_Erkek = new System.Windows.Forms.RadioButton();
            this.txt_Soyad = new System.Windows.Forms.TextBox();
            this.txt_Ad = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonKaydet = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonGuncelle = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonSil = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.grp_bilgiler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grp_bilgiler
            // 
            this.grp_bilgiler.Controls.Add(this.button1);
            this.grp_bilgiler.Controls.Add(this.txt_Adres);
            this.grp_bilgiler.Controls.Add(this.txt_Maas);
            this.grp_bilgiler.Controls.Add(this.comboBox1);
            this.grp_bilgiler.Controls.Add(this.txt_Mail);
            this.grp_bilgiler.Controls.Add(this.mtxt_Tel);
            this.grp_bilgiler.Controls.Add(this.mtxt_tc);
            this.grp_bilgiler.Controls.Add(this.rb_Kadin);
            this.grp_bilgiler.Controls.Add(this.rb_Erkek);
            this.grp_bilgiler.Controls.Add(this.txt_Soyad);
            this.grp_bilgiler.Controls.Add(this.txt_Ad);
            this.grp_bilgiler.Controls.Add(this.linkLabel1);
            this.grp_bilgiler.Controls.Add(this.pictureBox1);
            this.grp_bilgiler.Controls.Add(this.label9);
            this.grp_bilgiler.Controls.Add(this.label5);
            this.grp_bilgiler.Controls.Add(this.label6);
            this.grp_bilgiler.Controls.Add(this.label7);
            this.grp_bilgiler.Controls.Add(this.label8);
            this.grp_bilgiler.Controls.Add(this.label4);
            this.grp_bilgiler.Controls.Add(this.label3);
            this.grp_bilgiler.Controls.Add(this.label2);
            this.grp_bilgiler.Controls.Add(this.label1);
            this.grp_bilgiler.Location = new System.Drawing.Point(12, 29);
            this.grp_bilgiler.Name = "grp_bilgiler";
            this.grp_bilgiler.Size = new System.Drawing.Size(634, 182);
            this.grp_bilgiler.TabIndex = 0;
            this.grp_bilgiler.TabStop = false;
            this.grp_bilgiler.Text = "Personel Bilgiler";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 20);
            this.button1.TabIndex = 22;
            this.button1.Text = "BUL";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(395, 34);
            this.txt_Adres.Multiline = true;
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(121, 137);
            this.txt_Adres.TabIndex = 21;
            // 
            // txt_Maas
            // 
            this.txt_Maas.Location = new System.Drawing.Point(238, 152);
            this.txt_Maas.Name = "txt_Maas";
            this.txt_Maas.Size = new System.Drawing.Size(88, 20);
            this.txt_Maas.TabIndex = 20;
            this.txt_Maas.Text = "0";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bilgi İşlem",
            "Eğitim",
            "IK",
            "Muhasebe",
            "Güvenlik",
            "Pazarlama",
            "Satış",
            "Temizlik"});
            this.comboBox1.Location = new System.Drawing.Point(238, 117);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(88, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // txt_Mail
            // 
            this.txt_Mail.Location = new System.Drawing.Point(238, 73);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(88, 20);
            this.txt_Mail.TabIndex = 18;
            // 
            // mtxt_Tel
            // 
            this.mtxt_Tel.Location = new System.Drawing.Point(238, 34);
            this.mtxt_Tel.Mask = "(999) 000-0000";
            this.mtxt_Tel.Name = "mtxt_Tel";
            this.mtxt_Tel.Size = new System.Drawing.Size(88, 20);
            this.mtxt_Tel.TabIndex = 17;
            // 
            // mtxt_tc
            // 
            this.mtxt_tc.Location = new System.Drawing.Point(40, 34);
            this.mtxt_tc.Mask = "00000000000";
            this.mtxt_tc.Name = "mtxt_tc";
            this.mtxt_tc.Size = new System.Drawing.Size(73, 20);
            this.mtxt_tc.TabIndex = 16;
            this.mtxt_tc.Enter += new System.EventHandler(this.mtxt_tc_Enter);
            // 
            // rb_Kadin
            // 
            this.rb_Kadin.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_Kadin.Location = new System.Drawing.Point(130, 154);
            this.rb_Kadin.Name = "rb_Kadin";
            this.rb_Kadin.Size = new System.Drawing.Size(58, 17);
            this.rb_Kadin.TabIndex = 15;
            this.rb_Kadin.TabStop = true;
            this.rb_Kadin.Text = "KADIN";
            this.rb_Kadin.UseVisualStyleBackColor = true;
            // 
            // rb_Erkek
            // 
            this.rb_Erkek.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb_Erkek.Location = new System.Drawing.Point(75, 150);
            this.rb_Erkek.Name = "rb_Erkek";
            this.rb_Erkek.Size = new System.Drawing.Size(61, 24);
            this.rb_Erkek.TabIndex = 14;
            this.rb_Erkek.TabStop = true;
            this.rb_Erkek.Text = "ERKEK";
            this.rb_Erkek.UseVisualStyleBackColor = true;
            // 
            // txt_Soyad
            // 
            this.txt_Soyad.Location = new System.Drawing.Point(66, 117);
            this.txt_Soyad.Name = "txt_Soyad";
            this.txt_Soyad.Size = new System.Drawing.Size(86, 20);
            this.txt_Soyad.TabIndex = 13;
            // 
            // txt_Ad
            // 
            this.txt_Ad.Location = new System.Drawing.Point(66, 76);
            this.txt_Ad.Name = "txt_Ad";
            this.txt_Ad.Size = new System.Drawing.Size(86, 20);
            this.txt_Ad.TabIndex = 12;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(522, 158);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 10;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Resim Seçiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(525, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 110);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(332, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ADRESS :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(189, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "MAAŞ :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 120);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "BÖLÜMÜ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(194, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "MAİL :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(161, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "TELEFON :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "CİNSİYET :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SOYADI :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ADI :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TC :";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 217);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 221);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Personel Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(628, 202);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonKaydet,
            this.toolStripButtonGuncelle,
            this.toolStripButtonSil,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(657, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripButtonKaydet
            // 
            this.toolStripButtonKaydet.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonKaydet.Image")));
            this.toolStripButtonKaydet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonKaydet.Name = "toolStripButtonKaydet";
            this.toolStripButtonKaydet.Size = new System.Drawing.Size(69, 22);
            this.toolStripButtonKaydet.Text = "KAYDET";
            this.toolStripButtonKaydet.Click += new System.EventHandler(this.toolStripButtonKaydet_Click);
            // 
            // toolStripButtonGuncelle
            // 
            this.toolStripButtonGuncelle.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonGuncelle.Image")));
            this.toolStripButtonGuncelle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonGuncelle.Name = "toolStripButtonGuncelle";
            this.toolStripButtonGuncelle.Size = new System.Drawing.Size(84, 22);
            this.toolStripButtonGuncelle.Text = "GUNCELLE";
            this.toolStripButtonGuncelle.Click += new System.EventHandler(this.toolStripButtonGuncelle_Click);
            // 
            // toolStripButtonSil
            // 
            this.toolStripButtonSil.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonSil.Image")));
            this.toolStripButtonSil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonSil.Name = "toolStripButtonSil";
            this.toolStripButtonSil.Size = new System.Drawing.Size(42, 22);
            this.toolStripButtonSil.Text = "SİL";
            this.toolStripButtonSil.Click += new System.EventHandler(this.toolStripButtonSil_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 22);
            this.toolStripButton1.Text = "Temizle";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // FrmPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(657, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grp_bilgiler);
            this.Name = "FrmPersoneller";
            this.Text = "FrmPersoneller";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            this.grp_bilgiler.ResumeLayout(false);
            this.grp_bilgiler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grp_bilgiler;
        private System.Windows.Forms.TextBox txt_Adres;
        private System.Windows.Forms.TextBox txt_Maas;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.MaskedTextBox mtxt_Tel;
        private System.Windows.Forms.MaskedTextBox mtxt_tc;
        private System.Windows.Forms.RadioButton rb_Kadin;
        private System.Windows.Forms.RadioButton rb_Erkek;
        private System.Windows.Forms.TextBox txt_Soyad;
        private System.Windows.Forms.TextBox txt_Ad;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripButton toolStripButtonKaydet;
        private System.Windows.Forms.ToolStripButton toolStripButtonGuncelle;
        private System.Windows.Forms.ToolStripButton toolStripButtonSil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}