using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class PasswordManagerForm : Form
    {
        private List<AccountItemModel> accountItems=new List<AccountItemModel>();

        public PasswordManagerForm()
        {
            InitializeComponent();
        }
        public PasswordManagerForm(List<AccountItemModel> accountItems)
            :this()
        {
            this.accountItems = accountItems;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAccountData();
        }

        private void LoadAccountData()
        {
            foreach (var item in accountItems)
            {
                Bitmap image;
                using (var ms = new MemoryStream(item.Image))
                {
                    image = new Bitmap(ms);
                }

                var data = item.Password;

                var newButton = new CustomButton(item.Id,image, data);
                passwordsPanel.Controls.Add(newButton);
            }
        }

        //var image = new Bitmap(10, 10);
        // Draw your image
        //byte[] arr = image.ToByteArray(ImageFormat.Bmp);

        private void AddButton(CustomButton button)
        {
            passwordsPanel.Controls.Add(button);
        }

        private void onFirstTimeClicked(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = "";
            textBox.Click -= onFirstTimeClicked;
        }

        private void setControlVisibility(bool setToVisible , params Control[] controls) 
        {
            foreach (var control in controls)
            {
                control.Visible = setToVisible;
            }
        }
        private void HideSettingsMenu() 
        {
            setControlVisibility(false, newPasswordButton, deletePasswordButton, deleteAccountForeverButton);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            setControlVisibility(!newPasswordButton.Visible, newPasswordButton, deletePasswordButton, deleteAccountForeverButton);
        }

        private void manager_Clicked(object sender, EventArgs e)
        {
            HideSettingsMenu();
        }

        private void newPasswordButton_Click(object sender, EventArgs e)
        {
            setControlVisibility(!passwordTextBox.Visible, passwordTextBox, repeatPasswordTextBox, browseImageButton, imageSizeLabel, saveButton, cancelButton);
            HideSettingsMenu();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            passwordTextBox.Click += onFirstTimeClicked;
            repeatPasswordTextBox.Click += onFirstTimeClicked;

            setControlVisibility(!passwordTextBox.Visible, passwordTextBox, repeatPasswordTextBox, browseImageButton, imageSizeLabel, saveButton, cancelButton);
            
            passwordTextBox.Text = "Password";
            repeatPasswordTextBox.Text = "Repeat Password";
        }

        private void deletePasswordButton_Click(object sender, EventArgs e)
        {
            HideSettingsMenu();
            deleteLabel.Visible = !deleteLabel.Visible;
        }

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select an image";
                dlg.Filter = "Files|*.jpg;*.jpeg;*.png;";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var image = new Bitmap(dlg.FileName);
                    AddButton(new CustomButton(image));
                }
            }
        }
    }
}
