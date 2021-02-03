
namespace Register
{
    partial class SignUpForm
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
            this.signUpButton = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.signInButton = new System.Windows.Forms.Button();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.Color.LightSalmon;
            this.signUpButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(3, 290);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(323, 67);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // panel
            // 
            this.panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel.Controls.Add(this.emailTextBox);
            this.panel.Controls.Add(this.usernameTextBox);
            this.panel.Controls.Add(this.passwordTextBox);
            this.panel.Controls.Add(this.repeatPasswordTextBox);
            this.panel.Controls.Add(this.signUpButton);
            this.panel.Controls.Add(this.signInButton);
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(119, 4);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(331, 412);
            this.panel.TabIndex = 4;
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.Color.DarkOrange;
            this.signInButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(3, 363);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(323, 42);
            this.signInButton.TabIndex = 4;
            this.signInButton.TabStop = false;
            this.signInButton.Text = "Sign In Instead";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(3, 221);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(323, 46);
            this.repeatPasswordTextBox.TabIndex = 6;
            this.repeatPasswordTextBox.TabStop = false;
            this.repeatPasswordTextBox.Text = "Repeat Password";
            this.repeatPasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.repeatPasswordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTextBox.Location = new System.Drawing.Point(3, 152);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(323, 46);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.usernameTextBox.Location = new System.Drawing.Point(3, 86);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(323, 46);
            this.usernameTextBox.TabIndex = 5;
            this.usernameTextBox.TabStop = false;
            this.usernameTextBox.Text = "Username";
            this.usernameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.usernameTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.Location = new System.Drawing.Point(3, 20);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 20, 3, 0);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(323, 46);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(584, 433);
            this.Controls.Add(this.panel);
            this.Name = "SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button signInButton;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
    }
}

