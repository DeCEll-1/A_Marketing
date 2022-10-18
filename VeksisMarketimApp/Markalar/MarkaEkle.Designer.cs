namespace VeksisMarketimApp
{
    partial class MarkaEkle
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
            this.tb_MarkaAdi = new System.Windows.Forms.TextBox();
            this.btn_MarkaEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Hata
            // 
            this.btn_Hata.Enabled = false;
            this.btn_Hata.Location = new System.Drawing.Point(297, 5);
            this.btn_Hata.Name = "btn_Hata";
            this.btn_Hata.Size = new System.Drawing.Size(108, 51);
            this.btn_Hata.TabIndex = 17;
            this.btn_Hata.UseVisualStyleBackColor = true;
            this.btn_Hata.Visible = false;
            // 
            // cb_Aktif
            // 
            this.cb_Aktif.AutoSize = true;
            this.cb_Aktif.Location = new System.Drawing.Point(103, 41);
            this.cb_Aktif.Name = "cb_Aktif";
            this.cb_Aktif.Size = new System.Drawing.Size(47, 17);
            this.cb_Aktif.TabIndex = 16;
            this.cb_Aktif.Text = "Aktif";
            this.cb_Aktif.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Durum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Marka Adı";
            // 
            // tb_MarkaAdi
            // 
            this.tb_MarkaAdi.Location = new System.Drawing.Point(103, 6);
            this.tb_MarkaAdi.Name = "tb_MarkaAdi";
            this.tb_MarkaAdi.Size = new System.Drawing.Size(188, 20);
            this.tb_MarkaAdi.TabIndex = 13;
            this.tb_MarkaAdi.Text = "Marka Adı Giriniz";
            this.tb_MarkaAdi.Click += new System.EventHandler(this.tb_MarkaAdi_Click);
            // 
            // btn_MarkaEkle
            // 
            this.btn_MarkaEkle.Location = new System.Drawing.Point(156, 32);
            this.btn_MarkaEkle.Name = "btn_MarkaEkle";
            this.btn_MarkaEkle.Size = new System.Drawing.Size(135, 26);
            this.btn_MarkaEkle.TabIndex = 12;
            this.btn_MarkaEkle.Text = "Markayı Ekle";
            this.btn_MarkaEkle.UseVisualStyleBackColor = true;
            // 
            // MarkaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 66);
            this.Controls.Add(this.btn_Hata);
            this.Controls.Add(this.cb_Aktif);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_MarkaAdi);
            this.Controls.Add(this.btn_MarkaEkle);
            this.Name = "MarkaEkle";
            this.Text = "MarkaEkle";
            this.Load += new System.EventHandler(this.MarkaEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Hata;
        private System.Windows.Forms.CheckBox cb_Aktif;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_MarkaAdi;
        private System.Windows.Forms.Button btn_MarkaEkle;
    }
}