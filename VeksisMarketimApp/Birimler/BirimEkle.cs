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
    public partial class BirimEkle : Form
    {
        public bool tb { get; set; }
        DataModel dm = new DataModel();
        public BirimEkle()
        {
            InitializeComponent();
        }

        private void btn_MarkaEkle_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tb_BirimAdi.Text))
            {
                Birim birim = new Birim();
                birim.Isim = tb_BirimAdi.Text;
                birim.Durum = cb_Aktif.Checked;
                birim.Silinmis = false;
                if (dm.BirimEkle(birim))
                {
                    MessageBox.Show("Birim Başarıyla Eklendi", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Birim Ekleme sırasında Bir Hata Oluştu Lütfen Tekrar Deneyiniz", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clean();
                }
            }
            else
            {
                btn_Hata.Text = "Birim Adı Boşluk Bırakılamaz";
                btn_Hata.Visible = true;
            }
        }
        private void clean()
        {
            cb_Aktif.Checked = false;
            tb_BirimAdi.Text = "";
        }

        private void tb_MarkaAdi_Click(object sender, EventArgs e)
        {
            if (tb)
            {
                tb_BirimAdi.Text = "";
                tb = false;
            }
        }

        private void BirimEkle_Load(object sender, EventArgs e)
        {
            tb = true;
        }
    }
}
