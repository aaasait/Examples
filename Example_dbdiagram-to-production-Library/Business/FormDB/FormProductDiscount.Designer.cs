namespace FormDB
{
    partial class FormProductDiscount
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
            this.btnReturnMainPageDiscount = new System.Windows.Forms.Button();
            this.btnSaveDiscount = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptionDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDiscountPercentDiscount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturnMainPageDiscount
            // 
            this.btnReturnMainPageDiscount.Location = new System.Drawing.Point(461, 207);
            this.btnReturnMainPageDiscount.Name = "btnReturnMainPageDiscount";
            this.btnReturnMainPageDiscount.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageDiscount.TabIndex = 67;
            this.btnReturnMainPageDiscount.Text = "Return  Main Page";
            this.btnReturnMainPageDiscount.UseVisualStyleBackColor = true;
            this.btnReturnMainPageDiscount.Click += new System.EventHandler(this.btnReturnMainPageDiscount_Click);
            // 
            // btnSaveDiscount
            // 
            this.btnSaveDiscount.Location = new System.Drawing.Point(275, 207);
            this.btnSaveDiscount.Name = "btnSaveDiscount";
            this.btnSaveDiscount.Size = new System.Drawing.Size(154, 44);
            this.btnSaveDiscount.TabIndex = 66;
            this.btnSaveDiscount.Text = "Save";
            this.btnSaveDiscount.UseVisualStyleBackColor = true;
            this.btnSaveDiscount.Click += new System.EventHandler(this.btnSaveDiscount_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(73, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 65;
            this.label4.Text = "Description";
            // 
            // txtDescriptionDiscount
            // 
            this.txtDescriptionDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionDiscount.Location = new System.Drawing.Point(204, 85);
            this.txtDescriptionDiscount.Name = "txtDescriptionDiscount";
            this.txtDescriptionDiscount.Size = new System.Drawing.Size(459, 30);
            this.txtDescriptionDiscount.TabIndex = 64;
            this.txtDescriptionDiscount.Text = "2023 Black Days of Friday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(119, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 63;
            this.label3.Text = "Name";
            // 
            // txtNameDiscount
            // 
            this.txtNameDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameDiscount.Location = new System.Drawing.Point(204, 39);
            this.txtNameDiscount.Name = "txtNameDiscount";
            this.txtNameDiscount.Size = new System.Drawing.Size(459, 30);
            this.txtNameDiscount.TabIndex = 62;
            this.txtNameDiscount.Text = "Black Friday";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 25);
            this.label1.TabIndex = 69;
            this.label1.Text = "Discount Percent %";
            // 
            // txtDiscountPercentDiscount
            // 
            this.txtDiscountPercentDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPercentDiscount.Location = new System.Drawing.Point(204, 132);
            this.txtDiscountPercentDiscount.Name = "txtDiscountPercentDiscount";
            this.txtDiscountPercentDiscount.Size = new System.Drawing.Size(459, 30);
            this.txtDiscountPercentDiscount.TabIndex = 68;
            this.txtDiscountPercentDiscount.Text = "20";
            // 
            // FormProductDiscount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscountPercentDiscount);
            this.Controls.Add(this.btnReturnMainPageDiscount);
            this.Controls.Add(this.btnSaveDiscount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescriptionDiscount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameDiscount);
            this.Name = "FormProductDiscount";
            this.Text = "Product Discount";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMainPageDiscount;
        private System.Windows.Forms.Button btnSaveDiscount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriptionDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscountPercentDiscount;
    }
}