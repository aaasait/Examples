namespace FormDB
{
    partial class FormProductInventory
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
            this.label1 = new System.Windows.Forms.Label();
            this.txQuantityıInventory = new System.Windows.Forms.TextBox();
            this.btnReturnMainPageDiscount = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 31);
            this.label1.TabIndex = 73;
            this.label1.Text = "Quantity";
            // 
            // txQuantityıInventory
            // 
            this.txQuantityıInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txQuantityıInventory.Location = new System.Drawing.Point(129, 27);
            this.txQuantityıInventory.Name = "txQuantityıInventory";
            this.txQuantityıInventory.Size = new System.Drawing.Size(459, 30);
            this.txQuantityıInventory.TabIndex = 72;
            this.txQuantityıInventory.Text = "2";
            // 
            // btnReturnMainPageDiscount
            // 
            this.btnReturnMainPageDiscount.Location = new System.Drawing.Point(374, 87);
            this.btnReturnMainPageDiscount.Name = "btnReturnMainPageDiscount";
            this.btnReturnMainPageDiscount.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageDiscount.TabIndex = 71;
            this.btnReturnMainPageDiscount.Text = "Return  Main Page";
            this.btnReturnMainPageDiscount.UseVisualStyleBackColor = true;
            this.btnReturnMainPageDiscount.Click += new System.EventHandler(this.btnReturnMainPageDiscount_Click);
            // 
            // btnSaveDiscount
            // 
            this.btnSaveDiscount.Location = new System.Drawing.Point(188, 87);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(154, 44);
            this.btnSaveDiscount.TabIndex = 70;
            this.btnSaveDiscount.Text = "Save";
            this.btnSaveDiscount.UseVisualStyleBackColor = true;
            this.btnSaveDiscount.Click += new System.EventHandler(this.btnSaveDiscount_Click);
            // 
            // FormProductInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(674, 189);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txQuantityıInventory);
            this.Controls.Add(this.btnReturnMainPageDiscount);
            this.Controls.Add(this.btnSaveDiscount);
            this.Name = "FormProductInventory";
            this.Text = "Product Inventory";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txQuantityıInventory;
        private System.Windows.Forms.Button btnReturnMainPageDiscount;
        private System.Windows.Forms.Button btnSaveDiscount;
    }
}