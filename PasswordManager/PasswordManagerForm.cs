using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class PasswordManagerForm : Form
    {
        private AccountModel account;
        private List<AccountItemModel> accountItems;
        private byte[] openDialogImage;

        public PasswordManagerForm()
        {
            InitializeComponent();
        }

        public PasswordManagerForm(AccountModel account)
            :this()
        {
            this.account = account;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            VisualizeAccountData();
        }
        private void VisualizeAccountData()
        {
            accountItems = SqliteDataAccess.LoadAllAccountItems(account);

            foreach (var item in accountItems)
            {
                Bitmap image;
                using (var ms = new MemoryStream(item.Image))
                {
                    image = new Bitmap(ms);
                }

                var data = item.ImagePassword;

                var newButton = new CustomButton(item.Id,image, data);
                passwordsPanel.Controls.Add(newButton);
            }
        }
        private void VisualizeMostRecentAccountData()
        {
            var item = SqliteDataAccess.LoadMostRecentAccountItem(account);

            Bitmap image;
            using (var ms = new MemoryStream(item.Image))
            {
                image = new Bitmap(ms);
            }

            var data = item.ImagePassword;

            var newButton = new CustomButton(item.Id, image, data);
            passwordsPanel.Controls.Add(newButton);
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

        private void deletePasswordButton_Click(object sender, EventArgs e)
        {
            // TODO 
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

                    openDialogImage = BmpToByteArray(image, ImageFormat.Bmp);
                }
            }
        }

        public static byte[] BmpToByteArray(Image image, ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                return ms.ToArray();
            }
        }

        private void ButtonsResetDefaultProperties()
        {
            openDialogImage = null;

            passwordTextBox.Click += onFirstTimeClicked;
            repeatPasswordTextBox.Click += onFirstTimeClicked;

            setControlVisibility(!passwordTextBox.Visible, passwordTextBox, repeatPasswordTextBox, browseImageButton, imageSizeLabel, saveButton, cancelButton);

            passwordTextBox.Text = "Password";
            repeatPasswordTextBox.Text = "Repeat Password";
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ButtonsResetDefaultProperties();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            // TODO Verify password and repeated password

            SqliteDataAccess.SaveAccountItem(new AccountItemModel() { AccountId = this.account.Id, Image = openDialogImage, ImagePassword = passwordTextBox.Text });
            VisualizeMostRecentAccountData();

            ButtonsResetDefaultProperties();
        }
    }
}
