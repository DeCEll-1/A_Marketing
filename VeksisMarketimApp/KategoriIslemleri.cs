using DataAccessLayer;
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
    public partial class KategoriIslemleri : Form
    {
        DataModel dm = new DataModel();
        public KategoriIslemleri()
        {
            InitializeComponent();
            Load();
        }

        public void Load()
        {
            int cbselectedindex = cb_ListeTuru.SelectedIndex;
            tb_SecilenIndex.Enabled = false;
            btn_Hata.Visible = false;
            switch (cbselectedindex)
            {
                case 0:
                    dataGridView1.DataSource = dm.ButunKategorileriListele(0);
                    break;
                case 1:
                    dataGridView1.DataSource = dm.EnUstKategorileriListele(0);
                    break;
                case 2:
                    tb_SecilenIndex.Enabled = true;
                    if (dm.IsANumber(tb_SecilenIndex.Text))
                    {
                        int a = Convert.ToInt32(tb_SecilenIndex.Text);
                        dataGridView1.DataSource = dm.UstKategoriyeGoreListele(a, 0);
                    }
                    else
                    {
                        btn_Hata.Visible = true;
                        btn_Hata.Text = "Lütfen Bir Sayı Giriniz";
                    }
                    break;
                case 3:
                    dataGridView1.DataSource = dm.AltKategorisiVeUstKategorisiOlanlariListele(0);
                    break;
                case 4:
                    dataGridView1.DataSource = dm.AltındaKategoriOlanUstKategorileriGetir(0);
                    break;
            }
        }

        private void KategoriIslemleri_Load(object sender, EventArgs e)
        {
            Load();
        }

        private void cb_ListeTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            Load();
        }

        private void btn_Git_Click(object sender, EventArgs e)
        {
            Load();
        }
    }
}
