namespace WinFormsApp2
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
            this.dgShippersData = new System.Windows.Forms.DataGridView();
            this.btnGetAllShippers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgShippersData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgShippersData
            // 
            this.dgShippersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShippersData.Location = new System.Drawing.Point(12, 12);
            this.dgShippersData.Name = "dgShippersData";
            this.dgShippersData.RowHeadersWidth = 51;
            this.dgShippersData.RowTemplate.Height = 29;
            this.dgShippersData.Size = new System.Drawing.Size(663, 338);
            this.dgShippersData.TabIndex = 0;
            // 
            // btnGetAllShippers
            // 
            this.btnGetAllShippers.Location = new System.Drawing.Point(514, 359);
            this.btnGetAllShippers.Name = "btnGetAllShippers";
            this.btnGetAllShippers.Size = new System.Drawing.Size(161, 29);
            this.btnGetAllShippers.TabIndex = 1;
            this.btnGetAllShippers.Text = "Get All Shippers";
            this.btnGetAllShippers.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 400);
            this.Controls.Add(this.btnGetAllShippers);
            this.Controls.Add(this.dgShippersData);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dgShippersData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView dgShippersData;
        private Button btnGetAllShippers;
    }
}