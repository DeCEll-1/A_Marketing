using DataAccessLayer;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeksisMarketimApp
{
    public partial class KategoriEkle : Form
    {
        DataModel dm = new DataModel();
        public KategoriEkle()
        {
            InitializeComponent();
            ReLoad();
        }

        public void ReLoad()
        {
            List<Kategori> kategori = dm.EnUstKategorileriListele(0);
            foreach (Kategori item in kategori)
            {
                cb_UstKategori.Items.Add(item.Isim);
            }
        }

        private void btn_KategoriEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_KategoriAdi.Text))
            {
                Kategori kat = new Kategori();

                if (cbx_UstKategori.Checked)
                {
                    List<Kategori> kategori = dm.EnUstKategorileriListele(0);
                    foreach (Kategori item in kategori)
                    {
                        if (item.Isim == cb_UstKategori.Text)
                        {
                            kat.UstKategori_ID = item.ID;
                        }
                    }
                }
                kat.Isim = tb_KategoriAdi.Text;
                kat.Durum = cbx_Aktif.Checked;
                kat.Silinmis = false;
                if (dm.KategoriEkle(kat, cbx_UstKategori.Checked))
                {
                    MessageBox.Show("Kategori Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kategori Ekleme sırasında Bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clean();
                }
            }
            else
            {
                btn_Hata.Text = "Marka Adı Boşluk Bırakılamaz";
                btn_Hata.Visible = true;
            }
        }

        private void cb_UstKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_KategoriAdi.Text = "";
        }

        private void tb_KategoriAdi_Click(object sender, EventArgs e)
        {
            tb_KategoriAdi.Text = "";
        }
        private void clean()
        {
            cbx_Aktif.Checked = true;
            cbx_UstKategori.Checked = false;
            tb_KategoriAdi.Text = "";
        }

        private void cbx_UstKategori_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_UstKategori.Checked)
            {
                cb_UstKategori.Enabled = true;
                cb_UstKategori.SelectedIndex = 0;
            }
            else
            {
                cb_UstKategori.Enabled = false;
                cb_UstKategori.SelectedIndex = 0;
            }
        }
    }
}
