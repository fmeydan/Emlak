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
using EmlakMelegi.DatabaseLogicLayer;

namespace EmlakMelegi.UserInterface
{
    public partial class FrmKategoriler : Form
    {
        int kategoriid;
        public FrmKategoriler()
        {
            InitializeComponent();
        }
        KategoriManager kategori = new KategoriManager();
        #region Kaydet
        private void toolStripButton_kaydet_Click(object sender, EventArgs e)
        {


            string insertresult = kategori.KategoriKaydet(textBox_kategoriAdi.Text);
            dataGridView_kategori.DataSource = kategori.KategoriListe();
            MessageBox.Show(insertresult);
            temizle();

        }
        #endregion
        #region Load
        private void FrmKategoriler_Load(object sender, EventArgs e)
        {
            dataGridView_kategori.DataSource = kategori.KategoriListe();
        } 
        #endregion
        #region Güncelle
        private void toolStripButton_guncelle_Click(object sender, EventArgs e)
        {
            string updateResult = kategori.KategoriGuncelle(kategoriid, textBox_kategoriAdi.Text);
            dataGridView_kategori.DataSource = kategori.KategoriListe();
            MessageBox.Show(updateResult);
            kategoriid = 0;
            temizle();
        } 
        #endregion
        #region Temizle
        private void toolStripButton_temizle_Click(object sender, EventArgs e)
        {
            temizle();
        } 
        #endregion
        #region Sil
        private void toolStripButton_sil_Click(object sender, EventArgs e)
        {
            
            DialogResult mesaj= MessageBox.Show("Silmek işelmini onaylıyormusunuz?", "Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mesaj==DialogResult.Yes)
            {
                string deleteResult = kategori.KategoriSil(kategoriid);
                MessageBox.Show(deleteResult);
                dataGridView_kategori.DataSource = kategori.KategoriListe();
                temizle();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi.");
            }
            

        } 
        #endregion
        #region CellClik
        private void dataGridView_kategori_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            kategoriid = (int)dataGridView_kategori.CurrentRow.Cells["KategorilerID"].Value;
            textBox_kategoriAdi.Text = dataGridView_kategori.CurrentRow.Cells["KategoriAdi"].Value.ToString();
        } 
        #endregion

        public void temizle()
        {
            textBox_kategoriAdi.Text = "";
        }
    }
}
