namespace FormDB
{
    partial class FormBasket
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
            this.btnReturnMainPageBasket = new System.Windows.Forms.Button();
            this.btnSaveBasket = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotalBasket = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserIDBasket = new System.Windows.Forms.TextBox();
            this.comboItemsBasket = new System.Windows.Forms.ComboBox();
            this.btnAddBasketItemBasket = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReturnMainPageBasket
            // 
            this.btnReturnMainPageBasket.Location = new System.Drawing.Point(427, 216);
            this.btnReturnMainPageBasket.Name = "btnReturnMainPageBasket";
            this.btnReturnMainPageBasket.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageBasket.TabIndex = 87;
            this.btnReturnMainPageBasket.Text = "Return  Main Page";
            this.btnReturnMainPageBasket.UseVisualStyleBackColor = true;
            this.btnReturnMainPageBasket.Click += new System.EventHandler(this.btnReturnMainPageBasket_Click);
            // 
            // btnSaveBasket
            // 
            this.btnSaveBasket.Location = new System.Drawing.Point(239, 216);
            this.btnSaveBasket.Name = "btnSaveBasket";
            this.btnSaveBasket.Size = new System.Drawing.Size(154, 44);
            this.btnSaveBasket.TabIndex = 86;
            this.btnSaveBasket.Text = "Save";
            this.btnSaveBasket.UseVisualStyleBackColor = true;
            this.btnSaveBasket.Click += new System.EventHandler(this.btnSaveBasket_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 25);
            this.label2.TabIndex = 85;
            this.label2.Text = "Items";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 83;
            this.label1.Text = "Total";
            // 
            // txtTotalBasket
            // 
            this.txtTotalBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalBasket.Location = new System.Drawing.Point(283, 104);
            this.txtTotalBasket.Name = "txtTotalBasket";
            this.txtTotalBasket.Size = new System.Drawing.Size(459, 30);
            this.txtTotalBasket.TabIndex = 82;
            this.txtTotalBasket.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 31);
            this.label3.TabIndex = 81;
            this.label3.Text = "User ID";
            // 
            // txtUserIDBasket
            // 
            this.txtUserIDBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserIDBasket.Location = new System.Drawing.Point(283, 59);
            this.txtUserIDBasket.Name = "txtUserIDBasket";
            this.txtUserIDBasket.Size = new System.Drawing.Size(459, 30);
            this.txtUserIDBasket.TabIndex = 80;
            this.txtUserIDBasket.Text = "1";
            // 
            // comboItemsBasket
            // 
            this.comboItemsBasket.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboItemsBasket.FormattingEnabled = true;
            this.comboItemsBasket.Location = new System.Drawing.Point(283, 150);
            this.comboItemsBasket.Name = "comboItemsBasket";
            this.comboItemsBasket.Size = new System.Drawing.Size(459, 33);
            this.comboItemsBasket.TabIndex = 88;
            // 
            // btnAddBasketItemBasket
            // 
            this.btnAddBasketItemBasket.Location = new System.Drawing.Point(628, 216);
            this.btnAddBasketItemBasket.Name = "btnAddBasketItemBasket";
            this.btnAddBasketItemBasket.Size = new System.Drawing.Size(154, 44);
            this.btnAddBasketItemBasket.TabIndex = 89;
            this.btnAddBasketItemBasket.Text = "Add Basket Item";
            this.btnAddBasketItemBasket.UseVisualStyleBackColor = true;
            this.btnAddBasketItemBasket.Click += new System.EventHandler(this.btnAddBasketItemBasket_Click);
            // 
            // FormBasket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 337);
            this.Controls.Add(this.btnAddBasketItemBasket);
            this.Controls.Add(this.comboItemsBasket);
            this.Controls.Add(this.btnReturnMainPageBasket);
            this.Controls.Add(this.btnSaveBasket);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalBasket);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserIDBasket);
            this.Name = "FormBasket";
            this.Text = "Basket";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMainPageBasket;
        private System.Windows.Forms.Button btnSaveBasket;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotalBasket;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserIDBasket;
        private System.Windows.Forms.ComboBox comboItemsBasket;
        private System.Windows.Forms.Button btnAddBasketItemBasket;
    }
}