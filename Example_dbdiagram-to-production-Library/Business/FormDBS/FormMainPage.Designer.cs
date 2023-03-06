namespace FormDB
{
    partial class FormMainPage
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
            this.btnMainPageProduct = new System.Windows.Forms.Button();
            this.btnMainPageUser = new System.Windows.Forms.Button();
            this.btnMainPagePayment = new System.Windows.Forms.Button();
            this.btnMainPageOrder = new System.Windows.Forms.Button();
            this.btnMainPageBasket = new System.Windows.Forms.Button();
            this.btnMainPageOrderItem = new System.Windows.Forms.Button();
            this.btnMainPageCreditCard = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMainPageProduct
            // 
            this.btnMainPageProduct.Location = new System.Drawing.Point(58, 49);
            this.btnMainPageProduct.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageProduct.Name = "btnMainPageProduct";
            this.btnMainPageProduct.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageProduct.TabIndex = 0;
            this.btnMainPageProduct.Text = "Add Product";
            this.btnMainPageProduct.UseVisualStyleBackColor = true;
            this.btnMainPageProduct.Click += new System.EventHandler(this.btnMainPageProduct_Click);
            // 
            // btnMainPageUser
            // 
            this.btnMainPageUser.Location = new System.Drawing.Point(289, 49);
            this.btnMainPageUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageUser.Name = "btnMainPageUser";
            this.btnMainPageUser.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageUser.TabIndex = 1;
            this.btnMainPageUser.Text = "Add User";
            this.btnMainPageUser.UseVisualStyleBackColor = true;
            this.btnMainPageUser.Click += new System.EventHandler(this.btnMainPageUser_Click);
            // 
            // btnMainPagePayment
            // 
            this.btnMainPagePayment.Location = new System.Drawing.Point(527, 49);
            this.btnMainPagePayment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPagePayment.Name = "btnMainPagePayment";
            this.btnMainPagePayment.Size = new System.Drawing.Size(185, 65);
            this.btnMainPagePayment.TabIndex = 2;
            this.btnMainPagePayment.Text = "Add Payment";
            this.btnMainPagePayment.UseVisualStyleBackColor = true;
            this.btnMainPagePayment.Click += new System.EventHandler(this.btnMainPagePayment_Click);
            // 
            // btnMainPageOrder
            // 
            this.btnMainPageOrder.Location = new System.Drawing.Point(774, 49);
            this.btnMainPageOrder.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageOrder.Name = "btnMainPageOrder";
            this.btnMainPageOrder.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageOrder.TabIndex = 3;
            this.btnMainPageOrder.Text = "Add Order";
            this.btnMainPageOrder.UseVisualStyleBackColor = true;
            this.btnMainPageOrder.Click += new System.EventHandler(this.btnMainPageOrder_Click);
            // 
            // btnMainPageBasket
            // 
            this.btnMainPageBasket.Location = new System.Drawing.Point(1022, 49);
            this.btnMainPageBasket.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageBasket.Name = "btnMainPageBasket";
            this.btnMainPageBasket.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageBasket.TabIndex = 4;
            this.btnMainPageBasket.Text = "Add Basket";
            this.btnMainPageBasket.UseVisualStyleBackColor = true;
            this.btnMainPageBasket.Click += new System.EventHandler(this.btnMainPageBasket_Click);
            // 
            // btnMainPageOrderItem
            // 
            this.btnMainPageOrderItem.Location = new System.Drawing.Point(774, 148);
            this.btnMainPageOrderItem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageOrderItem.Name = "btnMainPageOrderItem";
            this.btnMainPageOrderItem.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageOrderItem.TabIndex = 5;
            this.btnMainPageOrderItem.Text = "Add Order Item";
            this.btnMainPageOrderItem.UseVisualStyleBackColor = true;
            this.btnMainPageOrderItem.Click += new System.EventHandler(this.btnMainPageOrderItem_Click);
            // 
            // btnMainPageCreditCard
            // 
            this.btnMainPageCreditCard.Location = new System.Drawing.Point(527, 148);
            this.btnMainPageCreditCard.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMainPageCreditCard.Name = "btnMainPageCreditCard";
            this.btnMainPageCreditCard.Size = new System.Drawing.Size(185, 65);
            this.btnMainPageCreditCard.TabIndex = 6;
            this.btnMainPageCreditCard.Text = "Add Credit Card";
            this.btnMainPageCreditCard.UseVisualStyleBackColor = true;
            this.btnMainPageCreditCard.Click += new System.EventHandler(this.btnMainPageCreditCard_Click);
            // 
            // FormMainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1355, 779);
            this.Controls.Add(this.btnMainPageCreditCard);
            this.Controls.Add(this.btnMainPageOrderItem);
            this.Controls.Add(this.btnMainPageBasket);
            this.Controls.Add(this.btnMainPageOrder);
            this.Controls.Add(this.btnMainPagePayment);
            this.Controls.Add(this.btnMainPageUser);
            this.Controls.Add(this.btnMainPageProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormMainPage";
            this.Text = "Sıemens E-Commerce";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMainPageProduct;
        private System.Windows.Forms.Button btnMainPageUser;
        private System.Windows.Forms.Button btnMainPagePayment;
        private System.Windows.Forms.Button btnMainPageOrder;
        private System.Windows.Forms.Button btnMainPageBasket;
        private System.Windows.Forms.Button btnMainPageOrderItem;
        private System.Windows.Forms.Button btnMainPageCreditCard;
    }
}

