namespace VeksisMarketimApp
{
    partial class KategoriEkle
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
            this.cb_UstKategori = new System.Windows.Forms.ComboBox();
            this.btn_Hata = new System.Windows.Forms.Button();
            this.cbx_Aktif = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_KategoriAdi = new System.Windows.Forms.TextBox();
            this.btn_KategoriEkle = new System.Windows.Forms.Button();
            this.cbx_UstKategori = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cb_UstKategori
            // 
            this.cb_UstKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_UstKategori.FormattingEnabled = true;
            this.cb_UstKategori.Items.AddRange(new object[] {
            ""});
            this.cb_UstKategori.Location = new System.Drawing.Point(103, 9);
            this.cb_UstKategori.Name = "cb_UstKategori";
            this.cb_UstKategori.Size = new System.Drawing.Size(86, 21);
            this.cb_UstKategori.TabIndex = 14;
            this.cb_UstKategori.SelectedIndexChanged += new System.EventHandler(this.cb_UstKategori_SelectedIndexChanged);
            // 
            // btn_Hata
            // 
            this.btn_Hata.Enabled = false;
            this.btn_Hata.Location = new System.Drawing.Point(15, 102);
            this.btn_Hata.Name = "btn_Hata";
            this.btn_Hata.Size = new System.Drawing.Size(135, 67);
            this.btn_Hata.TabIndex = 13;
            this.btn_Hata.UseVisualStyleBackColor = true;
            this.btn_Hata.Visible = false;
            // 
            // cbx_Aktif
            // 
            this.cbx_Aktif.AutoSize = true;
            this.cbx_Aktif.Location = new System.Drawing.Point(270, 79);
            this.cbx_Aktif.Name = "cbx_Aktif";
            this.cbx_Aktif.Size = new System.Drawing.Size(47, 17);
            this.cbx_Aktif.TabIndex = 12;
            this.cbx_Aktif.Text = "Aktif";
            this.cbx_Aktif.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Durum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Üst Kategori";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "KategoriAdi";
            // 
            // tb_KategoriAdi
            // 
            this.tb_KategoriAdi.Location = new System.Drawing.Point(103, 47);
            this.tb_KategoriAdi.Name = "tb_KategoriAdi";
            this.tb_KategoriAdi.Size = new System.Drawing.Size(214, 20);
            this.tb_KategoriAdi.TabIndex = 8;
            this.tb_KategoriAdi.Text = "Kategori Giriniz";
            this.tb_KategoriAdi.Click += new System.EventHandler(this.tb_KategoriAdi_Click);
            // 
            // btn_KategoriEkle
            // 
            this.btn_KategoriEkle.Location = new System.Drawing.Point(156, 102);
            this.btn_KategoriEkle.Name = "btn_KategoriEkle";
            this.btn_KategoriEkle.Size = new System.Drawing.Size(166, 67);
            this.btn_KategoriEkle.TabIndex = 7;
            this.btn_KategoriEkle.Text = "KategoriEkle";
            this.btn_KategoriEkle.UseVisualStyleBackColor = true;
            this.btn_KategoriEkle.Click += new System.EventHandler(this.btn_KategoriEkle_Click);
            // 
            // cbx_UstKategori
            // 
            this.cbx_UstKategori.AutoSize = true;
            this.cbx_UstKategori.Checked = true;
            this.cbx_UstKategori.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbx_UstKategori.Location = new System.Drawing.Point(195, 12);
            this.cbx_UstKategori.Name = "cbx_UstKategori";
            this.cbx_UstKategori.Size = new System.Drawing.Size(103, 17);
            this.cbx_UstKategori.TabIndex = 15;
            this.cbx_UstKategori.Text = "Üst Kategori Var";
            this.cbx_UstKategori.UseVisualStyleBackColor = true;
            this.cbx_UstKategori.CheckedChanged += new System.EventHandler(this.cbx_UstKategori_CheckedChanged);
            // 
            // KategoriEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 181);
            this.Controls.Add(this.cbx_UstKategori);
            this.Controls.Add(this.cb_UstKategori);
            this.Controls.Add(this.btn_Hata);
            this.Controls.Add(this.cbx_Aktif);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_KategoriAdi);
            this.Controls.Add(this.btn_KategoriEkle);
            this.Name = "KategoriEkle";
            this.Text = "KategoriEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cb_UstKategori;
        private System.Windows.Forms.Button btn_Hata;
        private System.Windows.Forms.CheckBox cbx_Aktif;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_KategoriAdi;
        private System.Windows.Forms.Button btn_KategoriEkle;
        private System.Windows.Forms.CheckBox cbx_UstKategori;
    }
}