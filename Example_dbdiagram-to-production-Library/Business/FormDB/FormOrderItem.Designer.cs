namespace FormDB
{
    partial class FormOrderItem
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
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderIDOrderItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductIDOrderItem = new System.Windows.Forms.TextBox();
            this.txtQuantityOrderItem = new System.Windows.Forms.TextBox();
            this.btnReturnMainPageOrderItem = new System.Windows.Forms.Button();
            this.btnSaveOrderItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 73;
            this.label3.Text = "Order ID";
            // 
            // txtOrderIDOrderItem
            // 
            this.txtOrderIDOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrderIDOrderItem.Location = new System.Drawing.Point(197, 53);
            this.txtOrderIDOrderItem.Name = "txtOrderIDOrderItem";
            this.txtOrderIDOrderItem.Size = new System.Drawing.Size(459, 30);
            this.txtOrderIDOrderItem.TabIndex = 72;
            this.txtOrderIDOrderItem.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Product ID";
            // 
            // txtProductIDOrderItem
            // 
            this.txtProductIDOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductIDOrderItem.Location = new System.Drawing.Point(197, 96);
            this.txtProductIDOrderItem.Name = "txtProductIDOrderItem";
            this.txtProductIDOrderItem.Size = new System.Drawing.Size(459, 30);
            this.txtProductIDOrderItem.TabIndex = 74;
            this.txtProductIDOrderItem.Text = "1";
            // 
            // txtQuantityOrderItem
            // 
            this.txtQuantityOrderItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityOrderItem.Location = new System.Drawing.Point(197, 143);
            this.txtQuantityOrderItem.Name = "txtQuantityOrderItem";
            this.txtQuantityOrderItem.Size = new System.Drawing.Size(459, 30);
            this.txtQuantityOrderItem.TabIndex = 76;
            this.txtQuantityOrderItem.Text = "2";
            // 
            // btnReturnMainPageOrderItem
            // 
            this.btnReturnMainPageOrderItem.Location = new System.Drawing.Point(430, 200);
            this.btnReturnMainPageOrderItem.Name = "btnReturnMainPageOrderItem";
            this.btnReturnMainPageOrderItem.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageOrderItem.TabIndex = 79;
            this.btnReturnMainPageOrderItem.Text = "Return  Main Page";
            this.btnReturnMainPageOrderItem.UseVisualStyleBackColor = true;
            this.btnReturnMainPageOrderItem.Click += new System.EventHandler(this.btnReturnMainPageOrderItem_Click);
            // 
            // btnSaveOrderItem
            // 
            this.btnSaveOrderItem.Location = new System.Drawing.Point(242, 200);
            this.btnSaveOrderItem.Name = "btnSaveOrderItem";
            this.btnSaveOrderItem.Size = new System.Drawing.Size(154, 44);
            this.btnSaveOrderItem.TabIndex = 78;
            this.btnSaveOrderItem.Text = "Save";
            this.btnSaveOrderItem.UseVisualStyleBackColor = true;
            this.btnSaveOrderItem.Click += new System.EventHandler(this.btnSaveOrderItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(92, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 77;
            this.label2.Text = "Quantity";
            // 
            // FormOrderItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 324);
            this.Controls.Add(this.btnReturnMainPageOrderItem);
            this.Controls.Add(this.btnSaveOrderItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantityOrderItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtProductIDOrderItem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOrderIDOrderItem);
            this.Name = "FormOrderItem";
            this.Text = "Order Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderIDOrderItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtProductIDOrderItem;
        private System.Windows.Forms.TextBox txtQuantityOrderItem;
        private System.Windows.Forms.Button btnReturnMainPageOrderItem;
        private System.Windows.Forms.Button btnSaveOrderItem;
        private System.Windows.Forms.Label label2;
    }
}