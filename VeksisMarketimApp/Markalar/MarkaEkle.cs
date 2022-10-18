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
    public partial class MarkaEkle : Form
    {
        public bool tb { get; set; }
        DataModel dm = new DataModel();
        public MarkaEkle()
        {
            InitializeComponent();
        }

        private void btn_MarkaEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_MarkaAdi.Text))
            {
                Marka marka = new Marka();
                marka.Isim = tb_MarkaAdi.Text;
                marka.Durum = cb_Aktif.Checked;
                marka.Silinmis = false;
                if (dm.MarkaEkle(marka))
                {
                    MessageBox.Show("Marka Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Marka Ekleme sırasında Bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    clean();
                }
            }
            else
            {
                btn_Hata.Text = "Marka Adı Boşluk Bırakılamaz";
                btn_Hata.Visible = true;
            }
        }
        private void clean()
        {
            cb_Aktif.Checked = false;
            tb_MarkaAdi.Text = "";
        }

        private void tb_MarkaAdi_Click(object sender, EventArgs e)
        {
            if (tb)
            {
            tb_MarkaAdi.Text = "";
            tb = false;
            }
        }

        private void MarkaEkle_Load(object sender, EventArgs e)
        {
            tb = true;
        }
    }
}
