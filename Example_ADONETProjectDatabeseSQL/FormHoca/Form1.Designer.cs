namespace FormHoca
{
    partial class Form1
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
            this.txtContent = new System.Windows.Forms.TextBox();
            this.btnExecuteReader = new System.Windows.Forms.Button();
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.btnExecuteProcedure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCategoryName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(9, 61);
            this.txtContent.Multiline = true;
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(779, 312);
            this.txtContent.TabIndex = 0;
            // 
            // btnExecuteReader
            // 
            this.btnExecuteReader.Location = new System.Drawing.Point(23, 379);
            this.btnExecuteReader.Name = "btnExecuteReader";
            this.btnExecuteReader.Size = new System.Drawing.Size(123, 44);
            this.btnExecuteReader.TabIndex = 1;
            this.btnExecuteReader.Text = "Execute Reader";
            this.btnExecuteReader.UseVisualStyleBackColor = true;
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(181, 379);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(123, 44);
            this.btnExecuteScalar.TabIndex = 2;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            // 
            // btnExecuteProcedure
            // 
            this.btnExecuteProcedure.Location = new System.Drawing.Point(338, 379);
            this.btnExecuteProcedure.Name = "btnExecuteProcedure";
            this.btnExecuteProcedure.Size = new System.Drawing.Size(123, 44);
            this.btnExecuteProcedure.TabIndex = 3;
            this.btnExecuteProcedure.Text = "Execute Procedure";
            this.btnExecuteProcedure.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Category Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(335, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year";
            // 
            // txtCategoryName
            // 
            this.txtCategoryName.Location = new System.Drawing.Point(146, 19);
            this.txtCategoryName.Name = "txtCategoryName";
            this.txtCategoryName.Size = new System.Drawing.Size(168, 22);
            this.txtCategoryName.TabIndex = 6;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(386, 20);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(168, 22);
            this.txtYear.TabIndex = 7;
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(560, 12);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(123, 44);
            this.btnGetReport.TabIndex = 8;
            this.btnGetReport.Text = "Get Report ";
            this.btnGetReport.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(696, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 44);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtCategoryName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecuteProcedure);
            this.Controls.Add(this.btnExecuteScalar);
            this.Controls.Add(this.btnExecuteReader);
            this.Controls.Add(this.txtContent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Button btnExecuteReader;
        private System.Windows.Forms.Button btnExecuteScalar;
        private System.Windows.Forms.Button btnExecuteProcedure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCategoryName;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Button btnGetReport;
        private System.Windows.Forms.Button btnClear;
    }
}

