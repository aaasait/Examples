namespace WinFormsApp1
{
    partial class Form2
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
            this.btnExecuteScalar = new System.Windows.Forms.Button();
            this.btnExecuteReader = new System.Windows.Forms.Button();
            this.btnExecuteProcedure = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblCatName = new System.Windows.Forms.Label();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.btnGetReport = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExecuteScalar
            // 
            this.btnExecuteScalar.Location = new System.Drawing.Point(12, 409);
            this.btnExecuteScalar.Name = "btnExecuteScalar";
            this.btnExecuteScalar.Size = new System.Drawing.Size(168, 29);
            this.btnExecuteScalar.TabIndex = 0;
            this.btnExecuteScalar.Text = "Execute Scalar";
            this.btnExecuteScalar.UseVisualStyleBackColor = true;
            // 
            // btnExecuteReader
            // 
            this.btnExecuteReader.Location = new System.Drawing.Point(186, 409);
            this.btnExecuteReader.Name = "btnExecuteReader";
            this.btnExecuteReader.Size = new System.Drawing.Size(168, 29);
            this.btnExecuteReader.TabIndex = 1;
            this.btnExecuteReader.Text = "Execute Reader";
            this.btnExecuteReader.UseVisualStyleBackColor = true;
            // 
            // btnExecuteProcedure
            // 
            this.btnExecuteProcedure.Location = new System.Drawing.Point(360, 409);
            this.btnExecuteProcedure.Name = "btnExecuteProcedure";
            this.btnExecuteProcedure.Size = new System.Drawing.Size(168, 29);
            this.btnExecuteProcedure.TabIndex = 2;
            this.btnExecuteProcedure.Text = "Execute Procedure";
            this.btnExecuteProcedure.UseVisualStyleBackColor = true;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(12, 60);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(745, 343);
            this.txtResult.TabIndex = 3;
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(12, 23);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(124, 20);
            this.lblCatName.TabIndex = 4;
            this.lblCatName.Text = "Category Name : ";
            // 
            // txtCatName
            // 
            this.txtCatName.Location = new System.Drawing.Point(142, 21);
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(166, 27);
            this.txtCatName.TabIndex = 5;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(374, 21);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(166, 27);
            this.txtYear.TabIndex = 7;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(320, 23);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(48, 20);
            this.lblYear.TabIndex = 6;
            this.lblYear.Text = "Year : ";
            // 
            // btnGetReport
            // 
            this.btnGetReport.Location = new System.Drawing.Point(549, 21);
            this.btnGetReport.Name = "btnGetReport";
            this.btnGetReport.Size = new System.Drawing.Size(120, 29);
            this.btnGetReport.TabIndex = 8;
            this.btnGetReport.Text = "Get Report";
            this.btnGetReport.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(675, 21);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(82, 29);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 450);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGetReport);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtCatName);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.btnExecuteProcedure);
            this.Controls.Add(this.btnExecuteReader);
            this.Controls.Add(this.btnExecuteScalar);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnExecuteScalar;
        private Button btnExecuteReader;
        private Button btnExecuteProcedure;
        private TextBox txtResult;
        private Label lblCatName;
        private TextBox txtCatName;
        private TextBox txtYear;
        private Label lblYear;
        private Button btnGetReport;
        private Button btnClear;
    }
}