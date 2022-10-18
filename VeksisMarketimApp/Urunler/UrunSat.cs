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
    public partial class UrunSat : Form
    {
        DataModel dm = new DataModel();
        public UrunSat()
        {
            InitializeComponent();
        }

        public void Doldur()
        {
            cb_Urunler.DataSource = dm.UrunListele();
            cb_Urunler.DisplayMember = "Isim";
            cb_Urunler.ValueMember = "ID";
        }

        private void cb_Urunler_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ID= ((int)cb_Urunler.SelectedIndex);
        }
    }
}
