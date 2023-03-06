namespace FormDB
{
    partial class FormOrder
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
            this.txtUserIDOrder = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescriptionOrder = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPaymentOrder = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAddPaymentOrder = new System.Windows.Forms.Button();
            this.btnSaveOrder = new System.Windows.Forms.Button();
            this.btnReturnMainPageOrder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUserIDOrder
            // 
            this.txtUserIDOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDOrder.Location = new System.Drawing.Point(198, 44);
            this.txtUserIDOrder.Name = "txtUserIDOrder";
            this.txtUserIDOrder.Size = new System.Drawing.Size(459, 30);
            this.txtUserIDOrder.TabIndex = 41;
            this.txtUserIDOrder.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(126, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Total";
            // 
            // txtDescriptionOrder
            // 
            this.txtDescriptionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionOrder.Location = new System.Drawing.Point(198, 89);
            this.txtDescriptionOrder.Name = "txtDescriptionOrder";
            this.txtDescriptionOrder.Size = new System.Drawing.Size(459, 30);
            this.txtDescriptionOrder.TabIndex = 43;
            this.txtDescriptionOrder.Text = "11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 25);
            this.label1.TabIndex = 42;
            this.label1.Text = "User ID";
            // 
            // comboPaymentOrder
            // 
            this.comboPaymentOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPaymentOrder.FormattingEnabled = true;
            this.comboPaymentOrder.Location = new System.Drawing.Point(198, 141);
            this.comboPaymentOrder.Name = "comboPaymentOrder";
            this.comboPaymentOrder.Size = new System.Drawing.Size(459, 33);
            this.comboPaymentOrder.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(90, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 44;
            this.label6.Text = "Payment";
            // 
            // btnAddPaymentOrder
            // 
            this.btnAddPaymentOrder.Location = new System.Drawing.Point(320, 210);
            this.btnAddPaymentOrder.Name = "btnAddPaymentOrder";
            this.btnAddPaymentOrder.Size = new System.Drawing.Size(154, 44);
            this.btnAddPaymentOrder.TabIndex = 47;
            this.btnAddPaymentOrder.Text = "Add Payment";
            this.btnAddPaymentOrder.UseVisualStyleBackColor = true;
            this.btnAddPaymentOrder.Click += new System.EventHandler(this.btnAddPaymentOrder_Click);
            // 
            // btnSaveOrder
            // 
            this.btnSaveOrder.Location = new System.Drawing.Point(134, 210);
            this.btnSaveOrder.Name = "btnSaveOrder";
            this.btnSaveOrder.Size = new System.Drawing.Size(154, 44);
            this.btnSaveOrder.TabIndex = 46;
            this.btnSaveOrder.Text = "Save";
            this.btnSaveOrder.UseVisualStyleBackColor = true;
            this.btnSaveOrder.Click += new System.EventHandler(this.btnSaveOrder_Click);
            // 
            // btnReturnMainPageOrder
            // 
            this.btnReturnMainPageOrder.Location = new System.Drawing.Point(503, 210);
            this.btnReturnMainPageOrder.Name = "btnReturnMainPageOrder";
            this.btnReturnMainPageOrder.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageOrder.TabIndex = 48;
            this.btnReturnMainPageOrder.Text = "Return  Main Page";
            this.btnReturnMainPageOrder.UseVisualStyleBackColor = true;
            this.btnReturnMainPageOrder.Click += new System.EventHandler(this.btnReturnMainPageOrder_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 309);
            this.Controls.Add(this.btnReturnMainPageOrder);
            this.Controls.Add(this.btnAddPaymentOrder);
            this.Controls.Add(this.btnSaveOrder);
            this.Controls.Add(this.comboPaymentOrder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescriptionOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUserIDOrder);
            this.Controls.Add(this.label7);
            this.Name = "FormOrder";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUserIDOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescriptionOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPaymentOrder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddPaymentOrder;
        private System.Windows.Forms.Button btnSaveOrder;
        private System.Windows.Forms.Button btnReturnMainPageOrder;
    }
}