
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
            this.settingsButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordButton = new System.Windows.Forms.Button();
            this.deletePasswordButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteAccountForeverButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // passwordsPanel
            // 
            this.passwordsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordsPanel.AutoScroll = true;
            this.passwordsPanel.Location = new System.Drawing.Point(0, 75);
            this.passwordsPanel.Name = "passwordsPanel";
            this.passwordsPanel.Size = new System.Drawing.Size(801, 376);
            this.passwordsPanel.TabIndex = 2;
            this.passwordsPanel.Click += new System.EventHandler(this.manager_Clicked);
            // 
            // settingsButton
            // 
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(-1, -1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(85, 24);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(247, 10);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(124, 27);
            this.passwordTextBox.TabIndex = 4;
            this.passwordTextBox.TabStop = false;
            this.passwordTextBox.Text = "Password";
            this.passwordTextBox.Visible = false;
            this.passwordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(373, 10);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(124, 27);
            this.repeatPasswordTextBox.TabIndex = 6;
            this.repeatPasswordTextBox.TabStop = false;
            this.repeatPasswordTextBox.Text = "Repeat Password";
            this.repeatPasswordTextBox.Visible = false;
            this.repeatPasswordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPasswordButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordButton.Location = new System.Drawing.Point(-1, 22);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(169, 24);
            this.newPasswordButton.TabIndex = 7;
            this.newPasswordButton.TabStop = false;
            this.newPasswordButton.Text = "New Password";
            this.newPasswordButton.UseVisualStyleBackColor = true;
            this.newPasswordButton.Visible = false;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // deletePasswordButton
            // 
            this.deletePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePasswordButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePasswordButton.Location = new System.Drawing.Point(-1, 45);
            this.deletePasswordButton.Name = "deletePasswordButton";
            this.deletePasswordButton.Size = new System.Drawing.Size(169, 24);
            this.deletePasswordButton.TabIndex = 8;
            this.deletePasswordButton.TabStop = false;
            this.deletePasswordButton.Text = "Delete Password";
            this.deletePasswordButton.UseVisualStyleBackColor = true;
            this.deletePasswordButton.Visible = false;
            this.deletePasswordButton.Click += new System.EventHandler(this.deletePasswordButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(604, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(62, 28);
            this.saveButton.TabIndex = 9;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(667, 10);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(62, 28);
            this.cancelButton.TabIndex = 10;
            this.cancelButton.TabStop = false;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Visible = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // deleteAccountForeverButton
            // 
            this.deleteAccountForeverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountForeverButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountForeverButton.Location = new System.Drawing.Point(-1, 68);
            this.deleteAccountForeverButton.Name = "deleteAccountForeverButton";
            this.deleteAccountForeverButton.Size = new System.Drawing.Size(169, 24);
            this.deleteAccountForeverButton.TabIndex = 11;
            this.deleteAccountForeverButton.TabStop = false;
            this.deleteAccountForeverButton.Text = "DELETE ACCOUNT FOREVER";
            this.deleteAccountForeverButton.UseVisualStyleBackColor = true;
            this.deleteAccountForeverButton.Visible = false;
            // 
            // creditsButton
            // 
            this.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.Location = new System.Drawing.Point(83, -1);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(85, 24);
            this.creditsButton.TabIndex = 13;
            this.creditsButton.TabStop = false;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = true;
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSizeLabel.Location = new System.Drawing.Point(535, 38);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(29, 13);
            this.imageSizeLabel.TabIndex = 14;
            this.imageSizeLabel.Text = "70x70";
            this.imageSizeLabel.Visible = false;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.Location = new System.Drawing.Point(341, 53);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(248, 19);
            this.deleteLabel.TabIndex = 15;
            this.deleteLabel.Text = "CLICK ON THE PASSWORD YOU WISH TO DELETE!";
            this.deleteLabel.Visible = false;
            // 
            // browseImageButton
            // 
            this.browseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseImageButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImageButton.Location = new System.Drawing.Point(498, 10);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(105, 28);
            this.browseImageButton.TabIndex = 16;
            this.browseImageButton.TabStop = false;
            this.browseImageButton.Text = "Browse Image";
            this.browseImageButton.UseVisualStyleBackColor = true;
            this.browseImageButton.Visible = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // PasswordManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.imageSizeLabel);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.deleteAccountForeverButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deletePasswordButton);
            this.Controls.Add(this.newPasswordButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.passwordsPanel);
            this.Name = "PasswordManagerForm";
            this.Text = "Password Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.manager_Clicked);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel passwordsPanel;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Button newPasswordButton;
        private System.Windows.Forms.Button deletePasswordButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteAccountForeverButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button browseImageButton;
    }
}

