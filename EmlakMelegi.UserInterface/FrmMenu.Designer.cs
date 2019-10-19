namespace EmlakMelegi.UserInterface
{
    partial class FrmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dairelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiralıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.satılıkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pERSONELLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mÜŞTERİLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gELİRLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gİDERLERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kULLANICILARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.daireKategorileriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dairelerToolStripMenuItem,
            this.pERSONELLERToolStripMenuItem,
            this.mÜŞTERİLERToolStripMenuItem,
            this.gELİRLERToolStripMenuItem,
            this.gİDERLERToolStripMenuItem,
            this.kULLANICILARToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1042, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dairelerToolStripMenuItem
            // 
            this.dairelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.daireKategorileriToolStripMenuItem,
            this.kiralıkToolStripMenuItem,
            this.satılıkToolStripMenuItem});
            this.dairelerToolStripMenuItem.Name = "dairelerToolStripMenuItem";
            this.dairelerToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.dairelerToolStripMenuItem.Text = "DAİRELER";
            // 
            // kiralıkToolStripMenuItem
            // 
            this.kiralıkToolStripMenuItem.Name = "kiralıkToolStripMenuItem";
            this.kiralıkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.kiralıkToolStripMenuItem.Text = "Kiralık";
            // 
            // satılıkToolStripMenuItem
            // 
            this.satılıkToolStripMenuItem.Name = "satılıkToolStripMenuItem";
            this.satılıkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.satılıkToolStripMenuItem.Text = "Satılık";
            // 
            // pERSONELLERToolStripMenuItem
            // 
            this.pERSONELLERToolStripMenuItem.Name = "pERSONELLERToolStripMenuItem";
            this.pERSONELLERToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.pERSONELLERToolStripMenuItem.Text = "PERSONELLER";
            this.pERSONELLERToolStripMenuItem.Click += new System.EventHandler(this.pERSONELLERToolStripMenuItem_Click);
            // 
            // mÜŞTERİLERToolStripMenuItem
            // 
            this.mÜŞTERİLERToolStripMenuItem.Name = "mÜŞTERİLERToolStripMenuItem";
            this.mÜŞTERİLERToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.mÜŞTERİLERToolStripMenuItem.Text = "MÜŞTERİLER";
            this.mÜŞTERİLERToolStripMenuItem.Click += new System.EventHandler(this.mÜŞTERİLERToolStripMenuItem_Click);
            // 
            // gELİRLERToolStripMenuItem
            // 
            this.gELİRLERToolStripMenuItem.Name = "gELİRLERToolStripMenuItem";
            this.gELİRLERToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.gELİRLERToolStripMenuItem.Text = "GELİRLER";
            // 
            // gİDERLERToolStripMenuItem
            // 
            this.gİDERLERToolStripMenuItem.Name = "gİDERLERToolStripMenuItem";
            this.gİDERLERToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.gİDERLERToolStripMenuItem.Text = "GİDERLER";
            // 
            // kULLANICILARToolStripMenuItem
            // 
            this.kULLANICILARToolStripMenuItem.Name = "kULLANICILARToolStripMenuItem";
            this.kULLANICILARToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.kULLANICILARToolStripMenuItem.Text = "KULLANICILAR";
            // 
            // daireKategorileriToolStripMenuItem
            // 
            this.daireKategorileriToolStripMenuItem.Name = "daireKategorileriToolStripMenuItem";
            this.daireKategorileriToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.daireKategorileriToolStripMenuItem.Text = "Daire Kategorileri";
            this.daireKategorileriToolStripMenuItem.Click += new System.EventHandler(this.daireKategorileriToolStripMenuItem_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmMenu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dairelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiralıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem satılıkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pERSONELLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mÜŞTERİLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gELİRLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gİDERLERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kULLANICILARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem daireKategorileriToolStripMenuItem;
    }
}