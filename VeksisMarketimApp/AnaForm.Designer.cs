namespace VeksisMarketimApp
{
    partial class AnaForm
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
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.işlemlerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_TedarikciIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_UrunEkle = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_UrunSat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.TSMI_KategoriIslemleri = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TSSL_Kullanici = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem,
            this.işlemlerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // işlemlerToolStripMenuItem
            // 
            this.işlemlerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_TedarikciIslemleri,
            this.toolStripSeparator1,
            this.TSMI_UrunEkle,
            this.TSMI_UrunSat,
            this.toolStripSeparator2,
            this.TSMI_KategoriIslemleri});
            this.işlemlerToolStripMenuItem.Name = "işlemlerToolStripMenuItem";
            this.işlemlerToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.işlemlerToolStripMenuItem.Text = "İşlemler";
            // 
            // TSMI_TedarikciIslemleri
            // 
            this.TSMI_TedarikciIslemleri.Name = "TSMI_TedarikciIslemleri";
            this.TSMI_TedarikciIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_TedarikciIslemleri.Text = "Tedarikçi İşlemleri";
            this.TSMI_TedarikciIslemleri.Click += new System.EventHandler(this.TSMI_TedarikciIslemleri_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_UrunEkle
            // 
            this.TSMI_UrunEkle.Name = "TSMI_UrunEkle";
            this.TSMI_UrunEkle.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunEkle.Text = "Ürün Ekle";
            this.TSMI_UrunEkle.Click += new System.EventHandler(this.TSMI_UrunIslemleri_Click);
            // 
            // TSMI_UrunSat
            // 
            this.TSMI_UrunSat.Name = "TSMI_UrunSat";
            this.TSMI_UrunSat.Size = new System.Drawing.Size(180, 22);
            this.TSMI_UrunSat.Text = "Ürün Sat";
            this.TSMI_UrunSat.Click += new System.EventHandler(this.TSMI_UrunSat_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
            // 
            // TSMI_KategoriIslemleri
            // 
            this.TSMI_KategoriIslemleri.Name = "TSMI_KategoriIslemleri";
            this.TSMI_KategoriIslemleri.Size = new System.Drawing.Size(180, 22);
            this.TSMI_KategoriIslemleri.Text = "Kategori İşlemleri";
            this.TSMI_KategoriIslemleri.Click += new System.EventHandler(this.TSMI_KategoriEkle_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSL_Kullanici});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TSSL_Kullanici
            // 
            this.TSSL_Kullanici.Name = "TSSL_Kullanici";
            this.TSSL_Kullanici.Size = new System.Drawing.Size(118, 17);
            this.TSSL_Kullanici.Text = "toolStripStatusLabel1";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "AnaForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel TSSL_Kullanici;
        private System.Windows.Forms.ToolStripMenuItem işlemlerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TSMI_TedarikciIslemleri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunEkle;
        private System.Windows.Forms.ToolStripMenuItem TSMI_UrunSat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem TSMI_KategoriIslemleri;
    }
}