namespace DisConnection
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDataTable = new System.Windows.Forms.Button();
            this.btnDataSet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 537);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnDataTable
            // 
            this.btnDataTable.Location = new System.Drawing.Point(26, 587);
            this.btnDataTable.Name = "btnDataTable";
            this.btnDataTable.Size = new System.Drawing.Size(176, 55);
            this.btnDataTable.TabIndex = 2;
            this.btnDataTable.Text = "Data Table";
            this.btnDataTable.UseVisualStyleBackColor = true;
            // 
            // btnDataSet
            // 
            this.btnDataSet.Location = new System.Drawing.Point(230, 587);
            this.btnDataSet.Name = "btnDataSet";
            this.btnDataSet.Size = new System.Drawing.Size(176, 55);
            this.btnDataSet.TabIndex = 3;
            this.btnDataSet.Text = "Data Set";
            this.btnDataSet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 678);
            this.Controls.Add(this.btnDataSet);
            this.Controls.Add(this.btnDataTable);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDataTable;
        private System.Windows.Forms.Button btnDataSet;
    }
}

