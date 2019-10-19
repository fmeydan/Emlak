using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmlakMelegi.BusinessLogicLayer.Manager;

namespace EmlakMelegi.UserInterface
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }
        FrmPersoneller f_pers;
        private void pERSONELLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (f_pers==null ||f_pers.IsDisposed)
            {
                f_pers = new FrmPersoneller();
                f_pers.MdiParent = this;              
                f_pers.Show();  
            }
            
        }
        FrmMusteriler fmusteri;
        private void mÜŞTERİLERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fmusteri==null || fmusteri.IsDisposed)
            {
                fmusteri = new FrmMusteriler();
                fmusteri.MdiParent = this;
                fmusteri.Show();
            }
            
        }

        FrmKategoriler frm_kat;
        private void daireKategorileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frm_kat==null || frm_kat.IsDisposed)
            {
                frm_kat = new FrmKategoriler();
                frm_kat.MdiParent = this;
                frm_kat.Show();
            }
        }
    }
}
