namespace FormDB
{
    partial class FormPhone
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
            this.comboTypePhone = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNumberPhone = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNamePhone = new System.Windows.Forms.TextBox();
            this.btnReturnMainPagePhone = new System.Windows.Forms.Button();
            this.btnSavePhone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboTypePhone
            // 
            this.comboTypePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTypePhone.FormattingEnabled = true;
            this.comboTypePhone.Location = new System.Drawing.Point(219, 150);
            this.comboTypePhone.Name = "comboTypePhone";
            this.comboTypePhone.Size = new System.Drawing.Size(459, 33);
            this.comboTypePhone.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(68, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Phone Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Phone Number";
            // 
            // txtNumberPhone
            // 
            this.txtNumberPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberPhone.Location = new System.Drawing.Point(219, 106);
            this.txtNumberPhone.Name = "txtNumberPhone";
            this.txtNumberPhone.Size = new System.Drawing.Size(459, 30);
            this.txtNumberPhone.TabIndex = 18;
            this.txtNumberPhone.Text = "02124442379";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(70, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Name";
            // 
            // txtNamePhone
            // 
            this.txtNamePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNamePhone.Location = new System.Drawing.Point(219, 60);
            this.txtNamePhone.Name = "txtNamePhone";
            this.txtNamePhone.Size = new System.Drawing.Size(459, 30);
            this.txtNamePhone.TabIndex = 16;
            this.txtNamePhone.Text = "My Office";
            // 
            // btnReturnMainPagePhone
            // 
            this.btnReturnMainPagePhone.Location = new System.Drawing.Point(470, 221);
            this.btnReturnMainPagePhone.Name = "btnReturnMainPagePhone";
            this.btnReturnMainPagePhone.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPagePhone.TabIndex = 23;
            this.btnReturnMainPagePhone.Text = "Return  Main Page";
            this.btnReturnMainPagePhone.UseVisualStyleBackColor = true;
            this.btnReturnMainPagePhone.Click += new System.EventHandler(this.btnReturnMainPagePhone_Click);
            // 
            // btnSavePhone
            // 
            this.btnSavePhone.Location = new System.Drawing.Point(284, 221);
            this.btnSavePhone.Name = "btnSavePhone";
            this.btnSavePhone.Size = new System.Drawing.Size(154, 44);
            this.btnSavePhone.TabIndex = 22;
            this.btnSavePhone.Text = "Save";
            this.btnSavePhone.UseVisualStyleBackColor = true;
            this.btnSavePhone.Click += new System.EventHandler(this.btnSavePhone_Click);
            // 
            // FormPhone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 342);
            this.Controls.Add(this.btnReturnMainPagePhone);
            this.Controls.Add(this.btnSavePhone);
            this.Controls.Add(this.comboTypePhone);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNumberPhone);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNamePhone);
            this.Name = "FormPhone";
            this.Text = "Phone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboTypePhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNumberPhone;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNamePhone;
        private System.Windows.Forms.Button btnReturnMainPagePhone;
        private System.Windows.Forms.Button btnSavePhone;
    }
}