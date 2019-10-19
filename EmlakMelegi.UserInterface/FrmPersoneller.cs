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
    public partial class FrmPersoneller : Form
    {
        public FrmPersoneller()
        {
            InitializeComponent();
        }

        PersonelManager per_Manager = new PersonelManager();
        private void FrmPersoneller_Load(object sender, EventArgs e)
        {
            
            dataGridView1.DataSource = per_Manager.PersonelList();
           
        }

        #region Kaydet
        private void toolStripButtonKaydet_Click(object sender, EventArgs e)
        {
            Alanlar();

            string kaydet = per_Manager.PersonelSave(tc, ad, soyad, cinsiyetSecim(), tel, mail, bolumu, maas, adres);
            dataGridView1.DataSource = per_Manager.PersonelList();//eklendikten sonra yenilensin diye

            MessageBox.Show(kaydet);
            temizle();
        }
        #endregion
        #region Cinsiyet Seçimi
        private bool cinsiyetSecim()
        {
            if (rb_Erkek.Checked == true)
            {
                return true; //erkek
            }
            return false; //kadın
        }
        #endregion
        #region TC ile getir
        private void button1_Click(object sender, EventArgs e)
        {
            if (per_Manager.TcilePersonelGetir(mtxt_tc.Text))
            {
                rb_Erkek.Checked = false;
                rb_Kadin.Checked = false;
                txt_Ad.Text = per_Manager.gelenad;
                txt_Soyad.Text = per_Manager.gelensoyad;
                txt_Mail.Text = per_Manager.gelenmailadres;
                txt_Maas.Text = per_Manager.gelenmaas.ToString();
                mtxt_Tel.Text = per_Manager.gelentelefon;
                mtxt_tc.Text = per_Manager.gelentc;
                if (per_Manager.gelencinsiyet == "True")
                {
                    rb_Erkek.Checked = true;
                }
                else if (per_Manager.gelencinsiyet == "False")
                {
                    rb_Kadin.Checked = true;
                }

            }
            else
            {
                MessageBox.Show("Bu TC numarasına kayıtlı personel Bulunamadı");
            }
        }
        #endregion
        #region Guncelle
        private void toolStripButtonGuncelle_Click(object sender, EventArgs e)
        {
            if (rb_Erkek.Checked == true || rb_Kadin.Checked == true && string.IsNullOrWhiteSpace(txt_Maas.Text))
            {
                Alanlar();
                string updateResult = per_Manager.PersonelUpdate(per_Manager.personel_ID, tc, ad, soyad, cinsiyetSecim(), tel, mail, bolumu, maas, adres);
                dataGridView1.DataSource = per_Manager.PersonelList();
                MessageBox.Show(updateResult);
                temizle();
            }
            MessageBox.Show("Cinsiyet Seçimi Zorunludur");
        } 
        #endregion
        #region AlanTanımlaması
        string tc, ad, soyad, adres, mail, bolumu,tel;

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        decimal maas;

        private void Alanlar()
        {
            tc = mtxt_tc.Text;
            ad = txt_Ad.Text;
            soyad = txt_Soyad.Text;
            adres = txt_Adres.Text;
            mail = txt_Mail.Text;
            bolumu = comboBox1.Text;
            maas = Convert.ToDecimal(txt_Maas.Text);
            tel = mtxt_Tel.Text;

        }
        #endregion
        #region Silme
        private void toolStripButtonSil_Click(object sender, EventArgs e)
        {
            DialogResult mesajOnay = MessageBox.Show("Silmek istediğinize emin misiniz?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (mesajOnay == DialogResult.Yes)
            {
                string personelDel = per_Manager.personelDelete(mtxt_tc.Text);
                dataGridView1.DataSource = per_Manager.PersonelList();
                MessageBox.Show(personelDel);
                temizle();
            }
            else
            {
                MessageBox.Show("Silme işlemi iptal edildi");
            }
        } 
        #endregion
        #region TC kutusunu baştan başlatma
        private void mtxt_tc_Enter(object sender, EventArgs e)
        {
            this.BeginInvoke((MethodInvoker)delegate ()
            {
                mtxt_tc.Select(0, 0);

            });
        }
        #endregion
        #region Temizleme
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            temizle();
        }
        #endregion
        #region Temizleme Metodu
        public void temizle()
        {
            foreach (Control item in grp_bilgiler.Controls)
            {
                if (item is TextBox || item is MaskedTextBox || item is ComboBox)
                {
                    item.Text = string.Empty;
                }
                if (item is RadioButton && ((RadioButton)item).Checked == true)
                {
                    ((RadioButton)item).Checked = false;
                }
            }
           // txt_Maas.Text = 0.ToString();
        } 
        #endregion

    }
}
