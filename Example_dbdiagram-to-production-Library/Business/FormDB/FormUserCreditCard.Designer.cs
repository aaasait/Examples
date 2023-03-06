namespace FormDB
{
    partial class FormUserCreditCard
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
            this.btnReturnMainPageCreditCard = new System.Windows.Forms.Button();
            this.btnSaveCreditCard = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumberCreditCard = new System.Windows.Forms.TextBox();
            this.comboProviderCreditCard = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeExpiryCreditCard = new System.Windows.Forms.DateTimePicker();
            this.btnAddProviderCreditCard = new System.Windows.Forms.Button();
            this.txtUserIDCreditCard = new System.Windows.Forms.TextBox();
            this.txtPaymentTypeCreditCard = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturnMainPageCreditCard
            // 
            this.btnReturnMainPageCreditCard.Location = new System.Drawing.Point(350, 296);
            this.btnReturnMainPageCreditCard.Name = "btnReturnMainPageCreditCard";
            this.btnReturnMainPageCreditCard.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageCreditCard.TabIndex = 31;
            this.btnReturnMainPageCreditCard.Text = "Return  Main Page";
            this.btnReturnMainPageCreditCard.UseVisualStyleBackColor = true;
            this.btnReturnMainPageCreditCard.Click += new System.EventHandler(this.btnReturnMainPageCreditCard_Click);
            // 
            // btnSaveCreditCard
            // 
            this.btnSaveCreditCard.Location = new System.Drawing.Point(164, 296);
            this.btnSaveCreditCard.Name = "btnSaveCreditCard";
            this.btnSaveCreditCard.Size = new System.Drawing.Size(154, 44);
            this.btnSaveCreditCard.TabIndex = 30;
            this.btnSaveCreditCard.Text = "Save";
            this.btnSaveCreditCard.UseVisualStyleBackColor = true;
            this.btnSaveCreditCard.Click += new System.EventHandler(this.btnSaveCreditCard_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Payment Type";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 27;
            this.label7.Text = "User ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(42, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 25);
            this.label5.TabIndex = 25;
            this.label5.Text = "Card No";
            // 
            // txtNumberCreditCard
            // 
            this.txtNumberCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberCreditCard.Location = new System.Drawing.Point(191, 185);
            this.txtNumberCreditCard.Name = "txtNumberCreditCard";
            this.txtNumberCreditCard.Size = new System.Drawing.Size(459, 30);
            this.txtNumberCreditCard.TabIndex = 24;
            // 
            // comboProviderCreditCard
            // 
            this.comboProviderCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProviderCreditCard.FormattingEnabled = true;
            this.comboProviderCreditCard.Location = new System.Drawing.Point(191, 138);
            this.comboProviderCreditCard.Name = "comboProviderCreditCard";
            this.comboProviderCreditCard.Size = new System.Drawing.Size(459, 33);
            this.comboProviderCreditCard.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 32;
            this.label1.Text = "Provider";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 35;
            this.label2.Text = "Expiry";
            // 
            // dateTimeExpiryCreditCard
            // 
            this.dateTimeExpiryCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeExpiryCreditCard.Location = new System.Drawing.Point(191, 233);
            this.dateTimeExpiryCreditCard.Name = "dateTimeExpiryCreditCard";
            this.dateTimeExpiryCreditCard.Size = new System.Drawing.Size(459, 27);
            this.dateTimeExpiryCreditCard.TabIndex = 37;
            // 
            // btnAddProviderCreditCard
            // 
            this.btnAddProviderCreditCard.Location = new System.Drawing.Point(534, 296);
            this.btnAddProviderCreditCard.Name = "btnAddProviderCreditCard";
            this.btnAddProviderCreditCard.Size = new System.Drawing.Size(154, 44);
            this.btnAddProviderCreditCard.TabIndex = 38;
            this.btnAddProviderCreditCard.Text = "Add Provider";
            this.btnAddProviderCreditCard.UseVisualStyleBackColor = true;
            this.btnAddProviderCreditCard.Click += new System.EventHandler(this.btnAddProviderCreditCard_Click);
            // 
            // txtUserIDCreditCard
            // 
            this.txtUserIDCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDCreditCard.Location = new System.Drawing.Point(191, 48);
            this.txtUserIDCreditCard.Name = "txtUserIDCreditCard";
            this.txtUserIDCreditCard.Size = new System.Drawing.Size(459, 30);
            this.txtUserIDCreditCard.TabIndex = 39;
            this.txtUserIDCreditCard.Text = "1";
            // 
            // txtPaymentTypeCreditCard
            // 
            this.txtPaymentTypeCreditCard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentTypeCreditCard.Location = new System.Drawing.Point(191, 94);
            this.txtPaymentTypeCreditCard.Name = "txtPaymentTypeCreditCard";
            this.txtPaymentTypeCreditCard.Size = new System.Drawing.Size(459, 30);
            this.txtPaymentTypeCreditCard.TabIndex = 40;
            // 
            // FormUserCreditCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 351);
            this.Controls.Add(this.txtPaymentTypeCreditCard);
            this.Controls.Add(this.txtUserIDCreditCard);
            this.Controls.Add(this.btnAddProviderCreditCard);
            this.Controls.Add(this.dateTimeExpiryCreditCard);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboProviderCreditCard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReturnMainPageCreditCard);
            this.Controls.Add(this.btnSaveCreditCard);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtNumberCreditCard);
            this.Name = "FormUserCreditCard";
            this.Text = "User Credit Card";
            this.Load += new System.EventHandler(this.FormUserCreditCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMainPageCreditCard;
        private System.Windows.Forms.Button btnSaveCreditCard;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumberCreditCard;
        private System.Windows.Forms.ComboBox comboProviderCreditCard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimeExpiryCreditCard;
        private System.Windows.Forms.Button btnAddProviderCreditCard;
        private System.Windows.Forms.TextBox txtUserIDCreditCard;
        private System.Windows.Forms.TextBox txtPaymentTypeCreditCard;
    }
}