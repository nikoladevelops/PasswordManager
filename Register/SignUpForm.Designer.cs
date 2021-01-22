
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.signInButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(3, 162);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(323, 67);
            this.signUpButton.TabIndex = 1;
            this.signUpButton.TabStop = false;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.signInButton);
            this.flowLayoutPanel1.Controls.Add(this.signUpButton);
            this.flowLayoutPanel1.Controls.Add(this.passwordTextBox);
            this.flowLayoutPanel1.Controls.Add(this.emailTextBox);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.BottomUp;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(165, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(331, 280);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.passwordTextBox.Location = new System.Drawing.Point(3, 83);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(323, 46);
            this.passwordTextBox.TabIndex = 2;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // emailTextBox
            // 
            this.emailTextBox.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.emailTextBox.Location = new System.Drawing.Point(3, 7);
            this.emailTextBox.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(323, 46);
            this.emailTextBox.TabIndex = 3;
            this.emailTextBox.TabStop = false;
            this.emailTextBox.Text = "Email";
            this.emailTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // signInButton
            // 
            this.signInButton.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signInButton.Location = new System.Drawing.Point(3, 235);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(323, 42);
            this.signInButton.TabIndex = 4;
            this.signInButton.TabStop = false;
            this.signInButton.Text = "Sign In Instead";
            this.signInButton.UseVisualStyleBackColor = true;
            // 
            // SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 425);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "SignUpForm";
            this.Text = "Sign Up";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Button signInButton;
    }
}

