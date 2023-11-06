namespace HelloWindowsAppBLGSube1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtDeneme = new System.Windows.Forms.TextBox();
            this.lblKoordinat = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 202);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 50);
            this.button1.TabIndex = 0;
            this.button1.Text = "Hello Windows";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtDeneme
            // 
            this.txtDeneme.Location = new System.Drawing.Point(351, 295);
            this.txtDeneme.Name = "txtDeneme";
            this.txtDeneme.Size = new System.Drawing.Size(100, 20);
            this.txtDeneme.TabIndex = 1;
            // 
            // lblKoordinat
            // 
            this.lblKoordinat.AutoSize = true;
            this.lblKoordinat.Location = new System.Drawing.Point(36, 26);
            this.lblKoordinat.Name = "lblKoordinat";
            this.lblKoordinat.Size = new System.Drawing.Size(0, 13);
            this.lblKoordinat.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKoordinat);
            this.Controls.Add(this.txtDeneme);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseLeave += new System.EventHandler(this.Form1_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtDeneme;
        private System.Windows.Forms.Label lblKoordinat;
    }
}

