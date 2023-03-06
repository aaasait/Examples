namespace FormListe
{
    partial class Form2
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Writer = new System.Windows.Forms.Button();
            this.check_OnayW = new System.Windows.Forms.CheckBox();
            this.txt_PwdW = new System.Windows.Forms.TextBox();
            this.txt_EmailW = new System.Windows.Forms.TextBox();
            this.txt_UserNameW = new System.Windows.Forms.TextBox();
            this.combo_CountryW = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(216, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(300, 46);
            this.label5.TabIndex = 23;
            this.label5.Text = "FORM YAZDIR";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 22);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ülke :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 22);
            this.label3.TabIndex = 20;
            this.label3.Text = "Şifre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 22);
            this.label2.TabIndex = 19;
            this.label2.Text = "Email  :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 22);
            this.label1.TabIndex = 18;
            this.label1.Text = "Kullanıcı Adı :";
            // 
            // btn_Writer
            // 
            this.btn_Writer.Location = new System.Drawing.Point(293, 405);
            this.btn_Writer.Name = "btn_Writer";
            this.btn_Writer.Size = new System.Drawing.Size(210, 51);
            this.btn_Writer.TabIndex = 17;
            this.btn_Writer.Text = "Yazdır";
            this.btn_Writer.UseVisualStyleBackColor = true;
            this.btn_Writer.Click += new System.EventHandler(this.btn_Writer_Click);
            // 
            // check_OnayW
            // 
            this.check_OnayW.AutoSize = true;
            this.check_OnayW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_OnayW.Location = new System.Drawing.Point(198, 365);
            this.check_OnayW.Name = "check_OnayW";
            this.check_OnayW.Size = new System.Drawing.Size(241, 24);
            this.check_OnayW.TabIndex = 16;
            this.check_OnayW.Text = "Okudum ve Kabul Ediyorum.";
            this.check_OnayW.UseVisualStyleBackColor = true;
            // 
            // txt_PwdW
            // 
            this.txt_PwdW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PwdW.Location = new System.Drawing.Point(198, 238);
            this.txt_PwdW.Name = "txt_PwdW";
            this.txt_PwdW.Size = new System.Drawing.Size(386, 38);
            this.txt_PwdW.TabIndex = 15;
            // 
            // txt_EmailW
            // 
            this.txt_EmailW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_EmailW.Location = new System.Drawing.Point(198, 164);
            this.txt_EmailW.Name = "txt_EmailW";
            this.txt_EmailW.Size = new System.Drawing.Size(386, 38);
            this.txt_EmailW.TabIndex = 14;
            // 
            // txt_UserNameW
            // 
            this.txt_UserNameW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_UserNameW.Location = new System.Drawing.Point(198, 90);
            this.txt_UserNameW.Name = "txt_UserNameW";
            this.txt_UserNameW.Size = new System.Drawing.Size(386, 38);
            this.txt_UserNameW.TabIndex = 13;
            // 
            // combo_CountryW
            // 
            this.combo_CountryW.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_CountryW.FormattingEnabled = true;
            this.combo_CountryW.Location = new System.Drawing.Point(198, 308);
            this.combo_CountryW.Name = "combo_CountryW";
            this.combo_CountryW.Size = new System.Drawing.Size(386, 39);
            this.combo_CountryW.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(732, 496);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Writer);
            this.Controls.Add(this.check_OnayW);
            this.Controls.Add(this.txt_PwdW);
            this.Controls.Add(this.txt_EmailW);
            this.Controls.Add(this.txt_UserNameW);
            this.Controls.Add(this.combo_CountryW);
            this.Name = "Form2";
            this.Text = "Form Yazdır";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Writer;
        private System.Windows.Forms.CheckBox check_OnayW;
        private System.Windows.Forms.TextBox txt_PwdW;
        private System.Windows.Forms.TextBox txt_EmailW;
        private System.Windows.Forms.TextBox txt_UserNameW;
        private System.Windows.Forms.ComboBox combo_CountryW;
    }
}