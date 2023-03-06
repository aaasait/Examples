namespace FormDB
{
    partial class FormProductCategory
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
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptionCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.btnReturnMainPageCategory = new System.Windows.Forms.Button();
            this.btnSaveCategory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(57, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 59;
            this.label4.Text = "Description";
            // 
            // txtDescriptionCategory
            // 
            this.txtDescriptionCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDescriptionCategory.Location = new System.Drawing.Point(206, 141);
            this.txtDescriptionCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDescriptionCategory.Name = "txtDescriptionCategory";
            this.txtDescriptionCategory.Size = new System.Drawing.Size(459, 30);
            this.txtDescriptionCategory.TabIndex = 58;
            this.txtDescriptionCategory.Text = "Home Design";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(57, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 57;
            this.label3.Text = "Name";
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNameCategory.Location = new System.Drawing.Point(206, 84);
            this.txtNameCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(459, 30);
            this.txtNameCategory.TabIndex = 56;
            this.txtNameCategory.Text = "Home";
            // 
            // btnReturnMainPageCategory
            // 
            this.btnReturnMainPageCategory.Location = new System.Drawing.Point(449, 216);
            this.btnReturnMainPageCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReturnMainPageCategory.Name = "btnReturnMainPageCategory";
            this.btnReturnMainPageCategory.Size = new System.Drawing.Size(154, 55);
            this.btnReturnMainPageCategory.TabIndex = 61;
            this.btnReturnMainPageCategory.Text = "Return  Main Page";
            this.btnReturnMainPageCategory.UseVisualStyleBackColor = true;
            this.btnReturnMainPageCategory.Click += new System.EventHandler(this.btnReturnMainPageCategory_Click);
            // 
            // btnSaveCategory
            // 
            this.btnSaveCategory.Location = new System.Drawing.Point(263, 216);
            this.btnSaveCategory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSaveCategory.Name = "btnSaveCategory";
            this.btnSaveCategory.Size = new System.Drawing.Size(154, 55);
            this.btnSaveCategory.TabIndex = 60;
            this.btnSaveCategory.Text = "Save";
            this.btnSaveCategory.UseVisualStyleBackColor = true;
            this.btnSaveCategory.Click += new System.EventHandler(this.btnSaveCategory_Click);
            // 
            // FormProductCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 382);
            this.Controls.Add(this.btnReturnMainPageCategory);
            this.Controls.Add(this.btnSaveCategory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescriptionCategory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameCategory);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormProductCategory";
            this.Text = "Product Category";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriptionCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.Button btnReturnMainPageCategory;
        private System.Windows.Forms.Button btnSaveCategory;
    }
}