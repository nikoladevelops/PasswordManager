
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordManagerForm));
            this.passwordsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.deletePasswordButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.deleteAccountForeverButton = new System.Windows.Forms.Button();
            this.creditsButton = new System.Windows.Forms.Button();
            this.imageSizeLabel = new System.Windows.Forms.Label();
            this.deleteLabel = new System.Windows.Forms.Label();
            this.browseImageButton = new System.Windows.Forms.Button();
            this.copyEmailButton = new System.Windows.Forms.Button();
            this.clearClipboardButton = new System.Windows.Forms.Button();
            this.newPasswordButton = new System.Windows.Forms.Button();
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
            this.settingsButton.BackColor = System.Drawing.Color.LightSalmon;
            this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsButton.Location = new System.Drawing.Point(-1, -1);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(85, 24);
            this.settingsButton.TabIndex = 3;
            this.settingsButton.TabStop = false;
            this.settingsButton.Text = "Settings";
            this.settingsButton.UseVisualStyleBackColor = false;
            this.settingsButton.Click += new System.EventHandler(this.settings_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(258, 10);
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
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(384, 10);
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(124, 27);
            this.repeatPasswordTextBox.TabIndex = 6;
            this.repeatPasswordTextBox.TabStop = false;
            this.repeatPasswordTextBox.Text = "Repeat Password";
            this.repeatPasswordTextBox.Visible = false;
            this.repeatPasswordTextBox.Click += new System.EventHandler(this.onFirstTimeClicked);
            // 
            // deletePasswordButton
            // 
            this.deletePasswordButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deletePasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePasswordButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletePasswordButton.Location = new System.Drawing.Point(-1, 45);
            this.deletePasswordButton.Name = "deletePasswordButton";
            this.deletePasswordButton.Size = new System.Drawing.Size(169, 24);
            this.deletePasswordButton.TabIndex = 8;
            this.deletePasswordButton.TabStop = false;
            this.deletePasswordButton.Text = "Delete Password";
            this.deletePasswordButton.UseVisualStyleBackColor = false;
            this.deletePasswordButton.Visible = false;
            this.deletePasswordButton.Click += new System.EventHandler(this.deletePasswordButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LimeGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(615, 10);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(62, 28);
            this.saveButton.TabIndex = 9;
            this.saveButton.TabStop = false;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Firebrick;
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Location = new System.Drawing.Point(678, 10);
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
            this.deleteAccountForeverButton.BackColor = System.Drawing.Color.LightSalmon;
            this.deleteAccountForeverButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteAccountForeverButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountForeverButton.Location = new System.Drawing.Point(-1, 68);
            this.deleteAccountForeverButton.Name = "deleteAccountForeverButton";
            this.deleteAccountForeverButton.Size = new System.Drawing.Size(169, 24);
            this.deleteAccountForeverButton.TabIndex = 11;
            this.deleteAccountForeverButton.TabStop = false;
            this.deleteAccountForeverButton.Text = "DELETE ACCOUNT FOREVER";
            this.deleteAccountForeverButton.UseVisualStyleBackColor = false;
            this.deleteAccountForeverButton.Visible = false;
            this.deleteAccountForeverButton.Click += new System.EventHandler(this.deleteAccountForeverButton_Click);
            // 
            // creditsButton
            // 
            this.creditsButton.BackColor = System.Drawing.Color.LightSalmon;
            this.creditsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.creditsButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsButton.Location = new System.Drawing.Point(83, -1);
            this.creditsButton.Name = "creditsButton";
            this.creditsButton.Size = new System.Drawing.Size(85, 24);
            this.creditsButton.TabIndex = 13;
            this.creditsButton.TabStop = false;
            this.creditsButton.Text = "Credits";
            this.creditsButton.UseVisualStyleBackColor = false;
            this.creditsButton.Click += new System.EventHandler(this.creditsButton_Click);
            // 
            // imageSizeLabel
            // 
            this.imageSizeLabel.AutoSize = true;
            this.imageSizeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageSizeLabel.Location = new System.Drawing.Point(546, 38);
            this.imageSizeLabel.Name = "imageSizeLabel";
            this.imageSizeLabel.Size = new System.Drawing.Size(29, 13);
            this.imageSizeLabel.TabIndex = 14;
            this.imageSizeLabel.Text = "70x70";
            this.imageSizeLabel.Visible = false;
            // 
            // deleteLabel
            // 
            this.deleteLabel.AutoSize = true;
            this.deleteLabel.BackColor = System.Drawing.Color.DimGray;
            this.deleteLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.deleteLabel.Location = new System.Drawing.Point(341, 53);
            this.deleteLabel.Name = "deleteLabel";
            this.deleteLabel.Size = new System.Drawing.Size(248, 19);
            this.deleteLabel.TabIndex = 15;
            this.deleteLabel.Text = "CLICK ON THE PASSWORD YOU WISH TO DELETE!";
            this.deleteLabel.Visible = false;
            // 
            // browseImageButton
            // 
            this.browseImageButton.BackColor = System.Drawing.Color.LightSalmon;
            this.browseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.browseImageButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImageButton.Location = new System.Drawing.Point(509, 10);
            this.browseImageButton.Name = "browseImageButton";
            this.browseImageButton.Size = new System.Drawing.Size(105, 28);
            this.browseImageButton.TabIndex = 16;
            this.browseImageButton.TabStop = false;
            this.browseImageButton.Text = "Browse Image";
            this.browseImageButton.UseVisualStyleBackColor = false;
            this.browseImageButton.Visible = false;
            this.browseImageButton.Click += new System.EventHandler(this.browseImageButton_Click);
            // 
            // copyEmailButton
            // 
            this.copyEmailButton.BackColor = System.Drawing.Color.LightSalmon;
            this.copyEmailButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyEmailButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyEmailButton.Location = new System.Drawing.Point(167, -1);
            this.copyEmailButton.Name = "copyEmailButton";
            this.copyEmailButton.Size = new System.Drawing.Size(84, 24);
            this.copyEmailButton.TabIndex = 17;
            this.copyEmailButton.TabStop = false;
            this.copyEmailButton.Text = "Copy Email";
            this.copyEmailButton.UseVisualStyleBackColor = false;
            this.copyEmailButton.Click += new System.EventHandler(this.copyEmailButton_Click);
            // 
            // clearClipboardButton
            // 
            this.clearClipboardButton.BackColor = System.Drawing.Color.LightSalmon;
            this.clearClipboardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearClipboardButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearClipboardButton.Location = new System.Drawing.Point(-1, 91);
            this.clearClipboardButton.Name = "clearClipboardButton";
            this.clearClipboardButton.Size = new System.Drawing.Size(169, 24);
            this.clearClipboardButton.TabIndex = 18;
            this.clearClipboardButton.TabStop = false;
            this.clearClipboardButton.Text = "Clear Clipboard (F5)";
            this.clearClipboardButton.UseVisualStyleBackColor = false;
            this.clearClipboardButton.Visible = false;
            this.clearClipboardButton.Click += new System.EventHandler(this.clearClipboardButton_Click);
            // 
            // newPasswordButton
            // 
            this.newPasswordButton.BackColor = System.Drawing.Color.LightSalmon;
            this.newPasswordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newPasswordButton.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordButton.Location = new System.Drawing.Point(-1, 22);
            this.newPasswordButton.Name = "newPasswordButton";
            this.newPasswordButton.Size = new System.Drawing.Size(169, 24);
            this.newPasswordButton.TabIndex = 19;
            this.newPasswordButton.TabStop = false;
            this.newPasswordButton.Text = "New Password";
            this.newPasswordButton.UseVisualStyleBackColor = false;
            this.newPasswordButton.Visible = false;
            this.newPasswordButton.Click += new System.EventHandler(this.newPasswordButton_Click);
            // 
            // PasswordManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clearClipboardButton);
            this.Controls.Add(this.newPasswordButton);
            this.Controls.Add(this.copyEmailButton);
            this.Controls.Add(this.deleteLabel);
            this.Controls.Add(this.browseImageButton);
            this.Controls.Add(this.imageSizeLabel);
            this.Controls.Add(this.creditsButton);
            this.Controls.Add(this.deleteAccountForeverButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deletePasswordButton);
            this.Controls.Add(this.repeatPasswordTextBox);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.settingsButton);
            this.Controls.Add(this.passwordsPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PasswordManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Button deletePasswordButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button deleteAccountForeverButton;
        private System.Windows.Forms.Button creditsButton;
        private System.Windows.Forms.Label imageSizeLabel;
        private System.Windows.Forms.Label deleteLabel;
        private System.Windows.Forms.Button browseImageButton;
        private System.Windows.Forms.Button copyEmailButton;
        private System.Windows.Forms.Button clearClipboardButton;
        private System.Windows.Forms.Button newPasswordButton;
    }
}

