namespace WinGestionComercial
{
    partial class FrmGoogle
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
            this.wbGoogle = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // wbGoogle
            // 
            this.wbGoogle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wbGoogle.Location = new System.Drawing.Point(0, 0);
            this.wbGoogle.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbGoogle.Name = "wbGoogle";
            this.wbGoogle.Size = new System.Drawing.Size(776, 388);
            this.wbGoogle.TabIndex = 0;
            // 
            // FrmGoogle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 388);
            this.Controls.Add(this.wbGoogle);
            this.Name = "FrmGoogle";
            this.Text = "Google";
            this.Load += new System.EventHandler(this.FrmGoogle_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser wbGoogle;
    }
}