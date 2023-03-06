namespace FormDB
{
    partial class FormProvider
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
            this.btnReturnMainPageProvider = new System.Windows.Forms.Button();
            this.btnSaveProvider = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescriptionProvider = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNameProvider = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReturnMainPageProvider
            // 
            this.btnReturnMainPageProvider.Location = new System.Drawing.Point(435, 160);
            this.btnReturnMainPageProvider.Name = "btnReturnMainPageProvider";
            this.btnReturnMainPageProvider.Size = new System.Drawing.Size(154, 44);
            this.btnReturnMainPageProvider.TabIndex = 75;
            this.btnReturnMainPageProvider.Text = "Return  Main Page";
            this.btnReturnMainPageProvider.UseVisualStyleBackColor = true;
            this.btnReturnMainPageProvider.Click += new System.EventHandler(this.btnReturnMainPageProvider_Click);
            // 
            // btnSaveProvider
            // 
            this.btnSaveProvider.Location = new System.Drawing.Point(249, 160);
            this.btnSaveProvider.Name = "btnSaveProvider";
            this.btnSaveProvider.Size = new System.Drawing.Size(154, 44);
            this.btnSaveProvider.TabIndex = 74;
            this.btnSaveProvider.Text = "Save";
            this.btnSaveProvider.UseVisualStyleBackColor = true;
            this.btnSaveProvider.Click += new System.EventHandler(this.btnSaveProvider_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(82, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 25);
            this.label4.TabIndex = 73;
            this.label4.Text = "Description";
            // 
            // txtDescriptionProvider
            // 
            this.txtDescriptionProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescriptionProvider.Location = new System.Drawing.Point(213, 87);
            this.txtDescriptionProvider.Name = "txtDescriptionProvider";
            this.txtDescriptionProvider.Size = new System.Drawing.Size(459, 30);
            this.txtDescriptionProvider.TabIndex = 72;
            this.txtDescriptionProvider.Text = "New Provider Version";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Name";
            // 
            // txtNameProvider
            // 
            this.txtNameProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameProvider.Location = new System.Drawing.Point(213, 43);
            this.txtNameProvider.Name = "txtNameProvider";
            this.txtNameProvider.Size = new System.Drawing.Size(459, 30);
            this.txtNameProvider.TabIndex = 70;
            this.txtNameProvider.Text = "Provider New";
            // 
            // FormProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 304);
            this.Controls.Add(this.btnReturnMainPageProvider);
            this.Controls.Add(this.btnSaveProvider);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescriptionProvider);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNameProvider);
            this.Name = "FormProvider";
            this.Text = "Provider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReturnMainPageProvider;
        private System.Windows.Forms.Button btnSaveProvider;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescriptionProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNameProvider;
    }
}