namespace FormDB
{
    partial class FormPayment
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
            this.btnReturnMainPagePayment = new System.Windows.Forms.Button();
            this.btnSavePayment = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAmountPayment = new System.Windows.Forms.TextBox();
            this.comboProviderPayment = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPaymentTypePayment = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxPaymentStatusPayment = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnReturnMainPagePayment
            // 
            this.btnReturnMainPagePayment.Location = new System.Drawing.Point(536, 307);
            this.btnReturnMainPagePayment.Name = "btnReturnMainPagePayment";
            this.btnReturnMainPagePayment.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPagePayment.TabIndex = 75;
            this.btnReturnMainPagePayment.Text = "Return  Main Page";
            this.btnReturnMainPagePayment.UseVisualStyleBackColor = true;
            this.btnReturnMainPagePayment.Click += new System.EventHandler(this.btnReturnMainPagePayment_Click);
            // 
            // btnSavePayment
            // 
            this.btnSavePayment.Location = new System.Drawing.Point(348, 307);
            this.btnSavePayment.Name = "btnSavePayment";
            this.btnSavePayment.Size = new System.Drawing.Size(154, 44);
            this.btnSavePayment.TabIndex = 74;
            this.btnSavePayment.Text = "Save";
            this.btnSavePayment.UseVisualStyleBackColor = true;
            this.btnSavePayment.Click += new System.EventHandler(this.btnSavePayment_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(170, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Amount";
            // 
            // txtAmountPayment
            // 
            this.txtAmountPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmountPayment.Location = new System.Drawing.Point(275, 72);
            this.txtAmountPayment.Name = "txtAmountPayment";
            this.txtAmountPayment.Size = new System.Drawing.Size(459, 30);
            this.txtAmountPayment.TabIndex = 70;
            this.txtAmountPayment.Text = "100.9";
            // 
            // comboProviderPayment
            // 
            this.comboProviderPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProviderPayment.FormattingEnabled = true;
            this.comboProviderPayment.Location = new System.Drawing.Point(275, 124);
            this.comboProviderPayment.Name = "comboProviderPayment";
            this.comboProviderPayment.Size = new System.Drawing.Size(459, 33);
            this.comboProviderPayment.TabIndex = 77;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(177, 127);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 31);
            this.label7.TabIndex = 76;
            this.label7.Text = "Provider";
            // 
            // comboPaymentTypePayment
            // 
            this.comboPaymentTypePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaymentTypePayment.FormattingEnabled = true;
            this.comboPaymentTypePayment.Location = new System.Drawing.Point(275, 177);
            this.comboPaymentTypePayment.Name = "comboPaymentTypePayment";
            this.comboPaymentTypePayment.Size = new System.Drawing.Size(459, 33);
            this.comboPaymentTypePayment.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 78;
            this.label1.Text = "Payment Type";
            // 
            // comboBoxPaymentStatusPayment
            // 
            this.comboBoxPaymentStatusPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxPaymentStatusPayment.FormattingEnabled = true;
            this.comboBoxPaymentStatusPayment.Location = new System.Drawing.Point(275, 233);
            this.comboBoxPaymentStatusPayment.Name = "comboBoxPaymentStatusPayment";
            this.comboBoxPaymentStatusPayment.Size = new System.Drawing.Size(459, 33);
            this.comboBoxPaymentStatusPayment.TabIndex = 81;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 80;
            this.label2.Text = "Payment Status";
            // 
            // FormPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 437);
            this.Controls.Add(this.comboBoxPaymentStatusPayment);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboPaymentTypePayment);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboProviderPayment);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnReturnMainPagePayment);
            this.Controls.Add(this.btnSavePayment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAmountPayment);
            this.Name = "FormPayment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturnMainPagePayment;
        private System.Windows.Forms.Button btnSavePayment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAmountPayment;
        private System.Windows.Forms.ComboBox comboProviderPayment;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPaymentTypePayment;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxPaymentStatusPayment;
        private System.Windows.Forms.Label label2;
    }
}