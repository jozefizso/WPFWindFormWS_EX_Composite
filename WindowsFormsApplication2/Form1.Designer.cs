namespace WindowsFormsApplication2
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
            this.cWPFHost = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // cWPFHost
            // 
            this.cWPFHost.Location = new System.Drawing.Point(-1, 0);
            this.cWPFHost.Name = "cWPFHost";
            this.cWPFHost.Size = new System.Drawing.Size(493, 193);
            this.cWPFHost.TabIndex = 1;
            this.cWPFHost.Child = null;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 190);
            this.Controls.Add(this.cWPFHost);
            this.Name = "Form1";
            this.Text = "WS_EX_COMPOSITED Form Window and WPF Composite Window";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost cWPFHost;
    }
}

