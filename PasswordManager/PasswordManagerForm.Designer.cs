
namespace PasswordManager
{
    partial class PasswordManagerForm
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
            this.passwordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // passwordsPanel
            // 
            this.passwordsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordsPanel.AutoScroll = true;
            this.passwordsPanel.Location = new System.Drawing.Point(0, 46);
            this.passwordsPanel.Name = "passwordsPanel";
            this.passwordsPanel.Size = new System.Drawing.Size(801, 405);
            this.passwordsPanel.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passwordsPanel);
            this.Name = "Form1";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel passwordsPanel;
    }
}

