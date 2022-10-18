namespace VeksisMarketimApp
{
    partial class KategoriIslemleri
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
            this.cb_ListeTuru = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_SecilenIndex = new System.Windows.Forms.TextBox();
            this.btn_Hata = new System.Windows.Forms.Button();
            this.btn_Git = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 220);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kategori Listesi";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(770, 199);
            this.dataGridView1.TabIndex = 0;
            // 
            // cb_ListeTuru
            // 
            this.cb_ListeTuru.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cb_ListeTuru.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ListeTuru.FormattingEnabled = true;
            this.cb_ListeTuru.Items.AddRange(new object[] {
            "Bütün Kategorileri Listele",
            "En Üst Kategorileri Listele (Üst Kategorisi Olmayanları)",
            "Üst Kategoriye Göre Listele",
            "Sadece Alt Ve Üst Kategorisi Olanları Listele",
            "Altında Kategori Olanları Listele"});
            this.cb_ListeTuru.Location = new System.Drawing.Point(472, 193);
            this.cb_ListeTuru.Name = "cb_ListeTuru";
            this.cb_ListeTuru.Size = new System.Drawing.Size(280, 21);
            this.cb_ListeTuru.TabIndex = 1;
            this.cb_ListeTuru.SelectedIndexChanged += new System.EventHandler(this.cb_ListeTuru_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(469, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Seçilen Üst Kategori İndexi";
            // 
            // tb_SecilenIndex
            // 
            this.tb_SecilenIndex.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_SecilenIndex.Location = new System.Drawing.Point(609, 166);
            this.tb_SecilenIndex.Name = "tb_SecilenIndex";
            this.tb_SecilenIndex.Size = new System.Drawing.Size(176, 20);
            this.tb_SecilenIndex.TabIndex = 7;
            // 
            // btn_Hata
            // 
            this.btn_Hata.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Hata.Enabled = false;
            this.btn_Hata.Location = new System.Drawing.Point(676, 126);
            this.btn_Hata.Name = "btn_Hata";
            this.btn_Hata.Size = new System.Drawing.Size(109, 34);
            this.btn_Hata.TabIndex = 8;
            this.btn_Hata.UseVisualStyleBackColor = true;
            this.btn_Hata.Visible = false;
            // 
            // btn_Git
            // 
            this.btn_Git.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Git.Location = new System.Drawing.Point(758, 192);
            this.btn_Git.Name = "btn_Git";
            this.btn_Git.Size = new System.Drawing.Size(30, 22);
            this.btn_Git.TabIndex = 2;
            this.btn_Git.Text = "Git";
            this.btn_Git.UseVisualStyleBackColor = true;
            this.btn_Git.Click += new System.EventHandler(this.btn_Git_Click);
            // 
            // KategoriIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Hata);
            this.Controls.Add(this.tb_SecilenIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Git);
            this.Controls.Add(this.cb_ListeTuru);
            this.Controls.Add(this.groupBox1);
            this.Name = "KategoriIslemleri";
            this.Text = "KategoriIslemleri";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cb_ListeTuru;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_SecilenIndex;
        private System.Windows.Forms.Button btn_Hata;
        private System.Windows.Forms.Button btn_Git;
    }
}