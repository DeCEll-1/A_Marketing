namespace VeksisMarketimApp
{
    partial class UrunSat
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_Sat = new System.Windows.Forms.Button();
            this.tb_Stok = new System.Windows.Forms.TextBox();
            this.tb_Barkod = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_Urunler = new System.Windows.Forms.ComboBox();
            this.tb_Birim = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(228, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 489);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ürünler Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(254, 470);
            this.dataGridView1.TabIndex = 6;
            // 
            // btn_Sat
            // 
            this.btn_Sat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Sat.Location = new System.Drawing.Point(12, 461);
            this.btn_Sat.Name = "btn_Sat";
            this.btn_Sat.Size = new System.Drawing.Size(213, 40);
            this.btn_Sat.TabIndex = 5;
            this.btn_Sat.Text = "Sat";
            this.btn_Sat.UseVisualStyleBackColor = true;
            // 
            // tb_Stok
            // 
            this.tb_Stok.Enabled = false;
            this.tb_Stok.Location = new System.Drawing.Point(12, 78);
            this.tb_Stok.Name = "tb_Stok";
            this.tb_Stok.Size = new System.Drawing.Size(210, 20);
            this.tb_Stok.TabIndex = 3;
            this.tb_Stok.Text = "Stok Sayısı";
            // 
            // tb_Barkod
            // 
            this.tb_Barkod.Enabled = false;
            this.tb_Barkod.Location = new System.Drawing.Point(12, 52);
            this.tb_Barkod.Name = "tb_Barkod";
            this.tb_Barkod.Size = new System.Drawing.Size(210, 20);
            this.tb_Barkod.TabIndex = 2;
            this.tb_Barkod.Text = "Barkod Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Ürünün İsmi:";
            // 
            // cb_Urunler
            // 
            this.cb_Urunler.FormattingEnabled = true;
            this.cb_Urunler.Location = new System.Drawing.Point(12, 25);
            this.cb_Urunler.Name = "cb_Urunler";
            this.cb_Urunler.Size = new System.Drawing.Size(210, 21);
            this.cb_Urunler.TabIndex = 1;
            this.cb_Urunler.SelectedIndexChanged += new System.EventHandler(this.cb_Urunler_SelectedIndexChanged);
            // 
            // tb_Birim
            // 
            this.tb_Birim.Enabled = false;
            this.tb_Birim.Location = new System.Drawing.Point(12, 104);
            this.tb_Birim.Name = "tb_Birim";
            this.tb_Birim.Size = new System.Drawing.Size(210, 20);
            this.tb_Birim.TabIndex = 4;
            this.tb_Birim.Text = "Birim";
            // 
            // UrunSat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tb_Birim);
            this.Controls.Add(this.cb_Urunler);
            this.Controls.Add(this.btn_Sat);
            this.Controls.Add(this.tb_Stok);
            this.Controls.Add(this.tb_Barkod);
            this.Controls.Add(this.label2);
            this.Name = "UrunSat";
            this.Text = "Ürün Satma Sayfası";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Sat;
        private System.Windows.Forms.TextBox tb_Stok;
        private System.Windows.Forms.TextBox tb_Barkod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_Urunler;
        private System.Windows.Forms.TextBox tb_Birim;
    }
}