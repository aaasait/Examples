namespace DisConnection
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
            this.btnDoldur = new System.Windows.Forms.Button();
            this.btnDegisiklikUygula = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDoldur
            // 
            this.btnDoldur.Location = new System.Drawing.Point(242, 565);
            this.btnDoldur.Name = "btnDoldur";
            this.btnDoldur.Size = new System.Drawing.Size(176, 55);
            this.btnDoldur.TabIndex = 6;
            this.btnDoldur.Text = "Doldur";
            this.btnDoldur.UseVisualStyleBackColor = true;
            this.btnDoldur.Click += new System.EventHandler(this.btnDoldur_Click);
            // 
            // btnDegisiklikUygula
            // 
            this.btnDegisiklikUygula.Location = new System.Drawing.Point(38, 565);
            this.btnDegisiklikUygula.Name = "btnDegisiklikUygula";
            this.btnDegisiklikUygula.Size = new System.Drawing.Size(176, 55);
            this.btnDegisiklikUygula.TabIndex = 5;
            this.btnDegisiklikUygula.Text = "Değişiklikleri Uygula";
            this.btnDegisiklikUygula.UseVisualStyleBackColor = true;
            this.btnDegisiklikUygula.Click += new System.EventHandler(this.btnDegisiklikUygula_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(33, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1086, 537);
            this.dataGridView1.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 632);
            this.Controls.Add(this.btnDoldur);
            this.Controls.Add(this.btnDegisiklikUygula);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDoldur;
        private System.Windows.Forms.Button btnDegisiklikUygula;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}