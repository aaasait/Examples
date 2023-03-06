namespace FormProje1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_usename = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.radioBtn_Erkek = new System.Windows.Forms.RadioButton();
            this.radioBtn_Kadin = new System.Windows.Forms.RadioButton();
            this.comboBox_sehir = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Adres = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_KayitOl = new System.Windows.Forms.Button();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // txt_usename
            // 
            this.txt_usename.Location = new System.Drawing.Point(175, 70);
            this.txt_usename.Name = "txt_usename";
            this.txt_usename.Size = new System.Drawing.Size(166, 27);
            this.txt_usename.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(175, 103);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(166, 27);
            this.txt_email.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Email :";
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(175, 136);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(166, 27);
            this.txt_pwd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Şifre  :";
            // 
            // radioBtn_Erkek
            // 
            this.radioBtn_Erkek.AutoSize = true;
            this.radioBtn_Erkek.Location = new System.Drawing.Point(178, 209);
            this.radioBtn_Erkek.Name = "radioBtn_Erkek";
            this.radioBtn_Erkek.Size = new System.Drawing.Size(65, 24);
            this.radioBtn_Erkek.TabIndex = 6;
            this.radioBtn_Erkek.TabStop = true;
            this.radioBtn_Erkek.Text = "Erkek";
            this.radioBtn_Erkek.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Kadin
            // 
            this.radioBtn_Kadin.AutoSize = true;
            this.radioBtn_Kadin.Location = new System.Drawing.Point(249, 209);
            this.radioBtn_Kadin.Name = "radioBtn_Kadin";
            this.radioBtn_Kadin.Size = new System.Drawing.Size(68, 24);
            this.radioBtn_Kadin.TabIndex = 7;
            this.radioBtn_Kadin.TabStop = true;
            this.radioBtn_Kadin.Text = "Kadın";
            this.radioBtn_Kadin.UseVisualStyleBackColor = true;
            // 
            // comboBox_sehir
            // 
            this.comboBox_sehir.FormattingEnabled = true;
            this.comboBox_sehir.Items.AddRange(new object[] {
            "Adana",
            "Antaly",
            "Ankara",
            "Istanbul",
            "Izmir",
            "Trabzon",
            "Elazig"});
            this.comboBox_sehir.Location = new System.Drawing.Point(175, 175);
            this.comboBox_sehir.Name = "comboBox_sehir";
            this.comboBox_sehir.Size = new System.Drawing.Size(166, 28);
            this.comboBox_sehir.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(73, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Şehir :";
            // 
            // txt_Adres
            // 
            this.txt_Adres.Location = new System.Drawing.Point(372, 100);
            this.txt_Adres.Name = "txt_Adres";
            this.txt_Adres.Size = new System.Drawing.Size(233, 103);
            this.txt_Adres.TabIndex = 10;
            this.txt_Adres.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Adres :";
            // 
            // btn_KayitOl
            // 
            this.btn_KayitOl.Location = new System.Drawing.Point(428, 241);
            this.btn_KayitOl.Name = "btn_KayitOl";
            this.btn_KayitOl.Size = new System.Drawing.Size(135, 33);
            this.btn_KayitOl.TabIndex = 12;
            this.btn_KayitOl.Text = "Kayıt Ol";
            this.btn_KayitOl.UseVisualStyleBackColor = true;
            this.btn_KayitOl.Click += new System.EventHandler(this.btn_KayitOl_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(12, 307);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(0, 20);
            this.lbl_sonuc.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 336);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_KayitOl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Adres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox_sehir);
            this.Controls.Add(this.radioBtn_Kadin);
            this.Controls.Add(this.radioBtn_Erkek);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_usename);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Kayıt";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txt_usename;
        private TextBox txt_email;
        private Label label2;
        private TextBox txt_pwd;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RadioButton radioBtn_Erkek;
        private RadioButton radioBtn_Kadin;
        private ComboBox comboBox_sehir;
        private Label label4;
        private RichTextBox txt_Adres;
        private Label label5;
        private Button btn_KayitOl;
        private Label lbl_sonuc;
    }
}