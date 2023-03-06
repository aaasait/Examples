namespace ADONETProjectSQL
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
            this.btnOpenCon = new System.Windows.Forms.Button();
            this.btnCloseCon = new System.Windows.Forms.Button();
            this.lblConn = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenCon
            // 
            this.btnOpenCon.Location = new System.Drawing.Point(240, 111);
            this.btnOpenCon.Name = "btnOpenCon";
            this.btnOpenCon.Size = new System.Drawing.Size(295, 52);
            this.btnOpenCon.TabIndex = 0;
            this.btnOpenCon.Text = "btnOpenCon";
            this.btnOpenCon.UseVisualStyleBackColor = true;
            // 
            // btnCloseCon
            // 
            this.btnCloseCon.Location = new System.Drawing.Point(253, 199);
            this.btnCloseCon.Name = "btnCloseCon";
            this.btnCloseCon.Size = new System.Drawing.Size(295, 52);
            this.btnCloseCon.TabIndex = 1;
            this.btnCloseCon.Text = "btnCloseCon";
            this.btnCloseCon.UseVisualStyleBackColor = true;
            // 
            // lblConn
            // 
            this.lblConn.AutoSize = true;
            this.lblConn.Location = new System.Drawing.Point(250, 264);
            this.lblConn.Name = "lblConn";
            this.lblConn.Size = new System.Drawing.Size(0, 16);
            this.lblConn.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblConn);
            this.Controls.Add(this.btnCloseCon);
            this.Controls.Add(this.btnOpenCon);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenCon;
        private System.Windows.Forms.Button btnCloseCon;
        private System.Windows.Forms.Label lblConn;
    }
}

