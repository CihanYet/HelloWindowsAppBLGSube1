namespace HelloWindowsAppBLGSube1
{
    partial class frmOyun
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
            this.pnlBilgi = new System.Windows.Forms.Panel();
            this.lblSkor = new System.Windows.Forms.Label();
            this.pnlBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 134);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 70);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.button1_MouseMove);
            // 
            // pnlBilgi
            // 
            this.pnlBilgi.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlBilgi.Controls.Add(this.lblSkor);
            this.pnlBilgi.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlBilgi.Location = new System.Drawing.Point(652, 0);
            this.pnlBilgi.Name = "pnlBilgi";
            this.pnlBilgi.Size = new System.Drawing.Size(148, 450);
            this.pnlBilgi.TabIndex = 1;
            // 
            // lblSkor
            // 
            this.lblSkor.AutoSize = true;
            this.lblSkor.Location = new System.Drawing.Point(50, 58);
            this.lblSkor.Name = "lblSkor";
            this.lblSkor.Size = new System.Drawing.Size(0, 13);
            this.lblSkor.TabIndex = 0;
            // 
            // frmOyun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlBilgi);
            this.Controls.Add(this.button1);
            this.Name = "frmOyun";
            this.Text = "frmOyun";
            this.SizeChanged += new System.EventHandler(this.frmOyun_SizeChanged);
            this.pnlBilgi.ResumeLayout(false);
            this.pnlBilgi.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnlBilgi;
        private System.Windows.Forms.Label lblSkor;
    }
}