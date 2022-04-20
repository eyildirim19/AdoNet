namespace _1_AdoGiris
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBaglan = new System.Windows.Forms.Button();
            this.lstKategoriListesi = new System.Windows.Forms.ListBox();
            this.btnKategoriListesi = new System.Windows.Forms.Button();
            this.lblUrunSayisi = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBaglan
            // 
            this.btnBaglan.Location = new System.Drawing.Point(26, 52);
            this.btnBaglan.Name = "btnBaglan";
            this.btnBaglan.Size = new System.Drawing.Size(110, 27);
            this.btnBaglan.TabIndex = 0;
            this.btnBaglan.Text = "Bağlan";
            this.btnBaglan.UseVisualStyleBackColor = true;
            this.btnBaglan.Click += new System.EventHandler(this.btnBaglan_Click);
            // 
            // lstKategoriListesi
            // 
            this.lstKategoriListesi.FormattingEnabled = true;
            this.lstKategoriListesi.ItemHeight = 15;
            this.lstKategoriListesi.Location = new System.Drawing.Point(26, 118);
            this.lstKategoriListesi.Name = "lstKategoriListesi";
            this.lstKategoriListesi.Size = new System.Drawing.Size(166, 199);
            this.lstKategoriListesi.TabIndex = 1;
            this.lstKategoriListesi.SelectedIndexChanged += new System.EventHandler(this.lstKategoriListesi_SelectedIndexChanged);
            // 
            // btnKategoriListesi
            // 
            this.btnKategoriListesi.Location = new System.Drawing.Point(27, 91);
            this.btnKategoriListesi.Name = "btnKategoriListesi";
            this.btnKategoriListesi.Size = new System.Drawing.Size(165, 23);
            this.btnKategoriListesi.TabIndex = 2;
            this.btnKategoriListesi.Text = "Kategori Listesi";
            this.btnKategoriListesi.UseVisualStyleBackColor = true;
            this.btnKategoriListesi.Click += new System.EventHandler(this.btnKategoriListesi_Click);
            // 
            // lblUrunSayisi
            // 
            this.lblUrunSayisi.AutoSize = true;
            this.lblUrunSayisi.Location = new System.Drawing.Point(295, 118);
            this.lblUrunSayisi.Name = "lblUrunSayisi";
            this.lblUrunSayisi.Size = new System.Drawing.Size(12, 15);
            this.lblUrunSayisi.TabIndex = 5;
            this.lblUrunSayisi.Text = "-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürün Sayısı:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 329);
            this.Controls.Add(this.lblUrunSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKategoriListesi);
            this.Controls.Add(this.lstKategoriListesi);
            this.Controls.Add(this.btnBaglan);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBaglan;
        private ListBox lstKategoriListesi;
        private Button btnKategoriListesi;
        private Label lblUrunSayisi;
        private Label label1;
    }
}