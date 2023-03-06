namespace FormDB
{
    partial class FormBasketItem
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
            this.comboBasketBasketItem = new System.Windows.Forms.ComboBox();
            this.btnReturnMainPageBasketItem = new System.Windows.Forms.Button();
            this.btnSaveBasketItem = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantityBasketItem = new System.Windows.Forms.TextBox();
            this.comboProductBasketItem = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddBasketBasketItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBasketBasketItem
            // 
            this.comboBasketBasketItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBasketBasketItem.FormattingEnabled = true;
            this.comboBasketBasketItem.Location = new System.Drawing.Point(203, 45);
            this.comboBasketBasketItem.Name = "comboBasketBasketItem";
            this.comboBasketBasketItem.Size = new System.Drawing.Size(457, 33);
            this.comboBasketBasketItem.TabIndex = 96;
            // 
            // btnReturnMainPageBasketItem
            // 
            this.btnReturnMainPageBasketItem.Location = new System.Drawing.Point(335, 210);
            this.btnReturnMainPageBasketItem.Name = "btnReturnMainPageBasketItem";
            this.btnReturnMainPageBasketItem.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageBasketItem.TabIndex = 95;
            this.btnReturnMainPageBasketItem.Text = "Return  Main Page";
            this.btnReturnMainPageBasketItem.UseVisualStyleBackColor = true;
            this.btnReturnMainPageBasketItem.Click += new System.EventHandler(this.btnReturnMainPageBasketItem_Click);
            // 
            // btnSaveBasketItem
            // 
            this.btnSaveBasketItem.Location = new System.Drawing.Point(147, 210);
            this.btnSaveBasketItem.Name = "btnSaveBasketItem";
            this.btnSaveBasketItem.Size = new System.Drawing.Size(154, 44);
            this.btnSaveBasketItem.TabIndex = 94;
            this.btnSaveBasketItem.Text = "Save";
            this.btnSaveBasketItem.UseVisualStyleBackColor = true;
            this.btnSaveBasketItem.Click += new System.EventHandler(this.btnSaveBasketItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(113, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 31);
            this.label2.TabIndex = 93;
            this.label2.Text = "Basket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 92;
            this.label1.Text = "Quantity";
            // 
            // txtQuantityBasketItem
            // 
            this.txtQuantityBasketItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantityBasketItem.Location = new System.Drawing.Point(203, 141);
            this.txtQuantityBasketItem.Name = "txtQuantityBasketItem";
            this.txtQuantityBasketItem.Size = new System.Drawing.Size(457, 30);
            this.txtQuantityBasketItem.TabIndex = 91;
            this.txtQuantityBasketItem.Text = "2";
            // 
            // comboProductBasketItem
            // 
            this.comboProductBasketItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProductBasketItem.FormattingEnabled = true;
            this.comboProductBasketItem.Location = new System.Drawing.Point(203, 93);
            this.comboProductBasketItem.Name = "comboProductBasketItem";
            this.comboProductBasketItem.Size = new System.Drawing.Size(457, 33);
            this.comboProductBasketItem.TabIndex = 98;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(113, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 31);
            this.label4.TabIndex = 97;
            this.label4.Text = "Product";
            // 
            // btnAddBasketBasketItem
            // 
            this.btnAddBasketBasketItem.Location = new System.Drawing.Point(530, 210);
            this.btnAddBasketBasketItem.Name = "btnAddBasketBasketItem";
            this.btnAddBasketBasketItem.Size = new System.Drawing.Size(154, 44);
            this.btnAddBasketBasketItem.TabIndex = 99;
            this.btnAddBasketBasketItem.Text = "Add Basket ";
            this.btnAddBasketBasketItem.UseVisualStyleBackColor = true;
            this.btnAddBasketBasketItem.Click += new System.EventHandler(this.btnAddBasketBasketItem_Click);
            // 
            // FormBasketItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 317);
            this.Controls.Add(this.btnAddBasketBasketItem);
            this.Controls.Add(this.comboProductBasketItem);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBasketBasketItem);
            this.Controls.Add(this.btnReturnMainPageBasketItem);
            this.Controls.Add(this.btnSaveBasketItem);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtQuantityBasketItem);
            this.Name = "FormBasketItem";
            this.Text = "Basket Item";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBasketBasketItem;
        private System.Windows.Forms.Button btnReturnMainPageBasketItem;
        private System.Windows.Forms.Button btnSaveBasketItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantityBasketItem;
        private System.Windows.Forms.ComboBox comboProductBasketItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddBasketBasketItem;
    }
}