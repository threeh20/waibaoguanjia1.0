namespace UI
{
    partial class xiangmuxiangqing
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
            this.webKitBrowser2 = new WebKit.WebKitBrowser();
            this.SuspendLayout();
            // 
            // webKitBrowser2
            // 
            this.webKitBrowser2.BackColor = System.Drawing.Color.White;
            this.webKitBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webKitBrowser2.Location = new System.Drawing.Point(0, 0);
            this.webKitBrowser2.Name = "webKitBrowser2";
            this.webKitBrowser2.Size = new System.Drawing.Size(1048, 588);
            this.webKitBrowser2.TabIndex = 1;
            this.webKitBrowser2.Url = null;
            this.webKitBrowser2.Load += new System.EventHandler(this.webKitBrowser2_Load);
            // 
            // Prescribe_UI10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1048, 588);
            this.Controls.Add(this.webKitBrowser2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Prescribe_UI10";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prescribe_UI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Prescribe_UI10_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Timer timer1;
        private WebKit.WebKitBrowser webKitBrowser1;
        private WebKit.WebKitBrowser webKitBrowser2;
    }
}