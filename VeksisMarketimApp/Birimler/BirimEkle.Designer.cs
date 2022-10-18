namespace VeksisMarketimApp
{
    partial class BirimEkle
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
            this.btn_Hata = new System.Windows.Forms.Button();
            this.cb_Aktif = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_BirimAdi = new System.Windows.Forms.TextBox();
            this.btn_BirimEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hata
            // 
            this.btn_Hata.Enabled = false;
            this.btn_Hata.Location = new System.Drawing.Point(297, 7);
            this.btn_Hata.Name = "btn_Hata";
            this.btn_Hata.Size = new System.Drawing.Size(108, 51);
            this.btn_Hata.TabIndex = 23;
            this.btn_Hata.UseVisualStyleBackColor = true;
            this.btn_Hata.Visible = false;
            // 
            // cb_Aktif
            // 
            this.cb_Aktif.AutoSize = true;
            this.cb_Aktif.Location = new System.Drawing.Point(103, 43);
            this.cb_Aktif.Name = "cb_Aktif";
            this.cb_Aktif.Size = new System.Drawing.Size(47, 17);
            this.cb_Aktif.TabIndex = 22;
            this.cb_Aktif.Text = "Aktif";
            this.cb_Aktif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Birim Adı";
            // 
            // tb_BirimAdi
            // 
            this.tb_BirimAdi.Location = new System.Drawing.Point(103, 8);
            this.tb_BirimAdi.Name = "tb_BirimAdi";
            this.tb_BirimAdi.Size = new System.Drawing.Size(188, 20);
            this.tb_BirimAdi.TabIndex = 19;
            this.tb_BirimAdi.Text = "Birim Adı Giriniz";
            this.tb_BirimAdi.Click += new System.EventHandler(this.tb_MarkaAdi_Click);
            // 
            // btn_BirimEkle
            // 
            this.btn_BirimEkle.Location = new System.Drawing.Point(156, 34);
            this.btn_BirimEkle.Name = "btn_BirimEkle";
            this.btn_BirimEkle.Size = new System.Drawing.Size(135, 26);
            this.btn_BirimEkle.TabIndex = 18;
            this.btn_BirimEkle.Text = "Birimi Ekle";
            this.btn_BirimEkle.UseVisualStyleBackColor = true;
            this.btn_BirimEkle.Click += new System.EventHandler(this.btn_MarkaEkle_Click);
            // 
            // BirimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 66);
            this.Controls.Add(this.btn_Hata);
            this.Controls.Add(this.cb_Aktif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_BirimAdi);
            this.Controls.Add(this.btn_BirimEkle);
            this.Name = "BirimEkle";
            this.Text = "BirimEkle";
            this.Load += new System.EventHandler(this.BirimEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Hata;
        private System.Windows.Forms.CheckBox cb_Aktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_BirimAdi;
        private System.Windows.Forms.Button btn_BirimEkle;
    }
}