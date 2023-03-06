namespace SQLStoreProcedure
{
    partial class Form3
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
            this.groupBoxUrunDetay = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboKategoriler = new System.Windows.Forms.ComboBox();
            this.comboUrunler = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUrunNo = new System.Windows.Forms.Label();
            this.lblUrunAd = new System.Windows.Forms.Label();
            this.lblBirimFiyat = new System.Windows.Forms.Label();
            this.lblStokAdet = new System.Windows.Forms.Label();
            this.groupBoxUrunDetay.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxUrunDetay
            // 
            this.groupBoxUrunDetay.Controls.Add(this.lblStokAdet);
            this.groupBoxUrunDetay.Controls.Add(this.lblBirimFiyat);
            this.groupBoxUrunDetay.Controls.Add(this.lblUrunAd);
            this.groupBoxUrunDetay.Controls.Add(this.lblUrunNo);
            this.groupBoxUrunDetay.Controls.Add(this.label7);
            this.groupBoxUrunDetay.Controls.Add(this.label6);
            this.groupBoxUrunDetay.Controls.Add(this.label5);
            this.groupBoxUrunDetay.Controls.Add(this.label4);
            this.groupBoxUrunDetay.Location = new System.Drawing.Point(348, 33);
            this.groupBoxUrunDetay.Name = "groupBoxUrunDetay";
            this.groupBoxUrunDetay.Size = new System.Drawing.Size(429, 357);
            this.groupBoxUrunDetay.TabIndex = 0;
            this.groupBoxUrunDetay.TabStop = false;
            this.groupBoxUrunDetay.Text = "ÜrünDetay";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(58, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kategoriler";
            // 
            // comboKategoriler
            // 
            this.comboKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboKategoriler.FormattingEnabled = true;
            this.comboKategoriler.Location = new System.Drawing.Point(51, 72);
            this.comboKategoriler.Name = "comboKategoriler";
            this.comboKategoriler.Size = new System.Drawing.Size(259, 30);
            this.comboKategoriler.TabIndex = 2;
            // 
            // comboUrunler
            // 
            this.comboUrunler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUrunler.FormattingEnabled = true;
            this.comboUrunler.Location = new System.Drawing.Point(51, 160);
            this.comboUrunler.Name = "comboUrunler";
            this.comboUrunler.Size = new System.Drawing.Size(259, 30);
            this.comboUrunler.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ürünler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ürün No :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "Ürün Ad :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Birim Fiyat :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(24, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 29);
            this.label7.TabIndex = 9;
            this.label7.Text = "StokAdet :";
            // 
            // lblUrunNo
            // 
            this.lblUrunNo.AutoSize = true;
            this.lblUrunNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunNo.Location = new System.Drawing.Point(191, 109);
            this.lblUrunNo.Name = "lblUrunNo";
            this.lblUrunNo.Size = new System.Drawing.Size(0, 36);
            this.lblUrunNo.TabIndex = 10;
            // 
            // lblUrunAd
            // 
            this.lblUrunAd.AutoSize = true;
            this.lblUrunAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUrunAd.Location = new System.Drawing.Point(191, 141);
            this.lblUrunAd.Name = "lblUrunAd";
            this.lblUrunAd.Size = new System.Drawing.Size(0, 36);
            this.lblUrunAd.TabIndex = 11;
            // 
            // lblBirimFiyat
            // 
            this.lblBirimFiyat.AutoSize = true;
            this.lblBirimFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBirimFiyat.Location = new System.Drawing.Point(191, 179);
            this.lblBirimFiyat.Name = "lblBirimFiyat";
            this.lblBirimFiyat.Size = new System.Drawing.Size(0, 36);
            this.lblBirimFiyat.TabIndex = 12;
            // 
            // lblStokAdet
            // 
            this.lblStokAdet.AutoSize = true;
            this.lblStokAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStokAdet.Location = new System.Drawing.Point(191, 218);
            this.lblStokAdet.Name = "lblStokAdet";
            this.lblStokAdet.Size = new System.Drawing.Size(0, 36);
            this.lblStokAdet.TabIndex = 13;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboUrunler);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboKategoriler);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxUrunDetay);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.groupBoxUrunDetay.ResumeLayout(false);
            this.groupBoxUrunDetay.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxUrunDetay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboKategoriler;
        private System.Windows.Forms.ComboBox comboUrunler;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStokAdet;
        private System.Windows.Forms.Label lblBirimFiyat;
        private System.Windows.Forms.Label lblUrunAd;
        private System.Windows.Forms.Label lblUrunNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}