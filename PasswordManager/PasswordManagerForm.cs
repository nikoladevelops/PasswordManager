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
        private string password;
        private List<CustomButton> customButtons = new List<CustomButton>();
        private bool isDeletingACustomButtonNow = false;  // created because of a possible bug

        public PasswordManagerForm()
        {
            InitializeComponent();
        }

        public PasswordManagerForm(AccountModel account,string password)
            :this()
        {
            this.account = account;
            this.password = password;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if (account==null)
            //{
            //    MessageBox.Show("Sorry you are not logged in","Error");
            //    Application.Exit();
            //}

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

                var newButton = new CustomButton(item.Id, image, data, this.password);
                newButton.Click += CustomButton_Click;

                customButtons.Add(newButton);
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

            var newButton = new CustomButton(item.Id, image, data, this.password);
            newButton.Click += CustomButton_Click;

            customButtons.Add(newButton);
            passwordsPanel.Controls.Add(newButton);
        }

        private void CustomButton_Click(object sender, System.EventArgs e)
        {
            var buttonThatIsClicked = (CustomButton)sender;
            var data = StringCipher.Decrypt(buttonThatIsClicked.EncryptedData, buttonThatIsClicked.AccountPassword);
            Clipboard.SetText(data);
        }

        private void CustomButton_Click_Delete(object sender, System.EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("If you click on Yes, this password will be deleted.", "Do you want to delete this password?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var buttonThatIsClicked = (CustomButton)sender;
                this.passwordsPanel.Controls.Remove(buttonThatIsClicked);
                this.customButtons.Remove(buttonThatIsClicked);
                SqliteDataAccess.DeleteAccountItem(buttonThatIsClicked.Id);
            }

            foreach (var button in customButtons)
            {
                button.Click -= CustomButton_Click_Delete;
                button.Click += CustomButton_Click;
            }
            deleteLabel.Visible = false;
            isDeletingACustomButtonNow = false;
        }

        private void deletePasswordButton_Click(object sender, EventArgs e)
        {
            HideSettingsMenu();

            if (!isDeletingACustomButtonNow && customButtons.Count != 0)
            {
                deleteLabel.Visible = !deleteLabel.Visible;

                foreach (var button in customButtons)
                {
                    button.Click -= CustomButton_Click;
                    button.Click += CustomButton_Click_Delete;
                }

                isDeletingACustomButtonNow = true;
            }
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
            setControlVisibility(false, newPasswordButton, deletePasswordButton, deleteAccountForeverButton, clearClipboardButton);
        }

        private void settings_Click(object sender, EventArgs e)
        {
            setControlVisibility(!newPasswordButton.Visible, newPasswordButton, deletePasswordButton, deleteAccountForeverButton, clearClipboardButton);
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

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Select an image";
                dlg.Filter = "Files|*.jpg;*.jpeg;*.png;";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    var image = new Bitmap(dlg.FileName);

                    openDialogImage = BmpToByteArray(image, ImageFormat.Png);
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
            if (passwordTextBox.Text.Length < 5)
            {
                throw new ArgumentException("Password needs to be at least 5 characters.");
            }
            if (passwordTextBox.Text != repeatPasswordTextBox.Text)
            {
                throw new ArgumentException("Passwords do not match.");
            }

            if (openDialogImage == null)
            {
                throw new ArgumentException("You haven't selected an image.");
            }

            var encryptedPass = StringCipher.Encrypt(passwordTextBox.Text, this.password);
            SqliteDataAccess.SaveAccountItem(new AccountItemModel() { AccountId = this.account.Id, Image = openDialogImage, ImagePassword = encryptedPass });
            VisualizeMostRecentAccountData();

            ButtonsResetDefaultProperties();
        }

        private void deleteAccountForeverButton_Click(object sender, EventArgs e)
        {
            HideSettingsMenu();

            DialogResult dialogResult = MessageBox.Show("If you click on Yes, your account will be deleted forever.", "Do you want to delete your account FOREVER ?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SqliteDataAccess.DeleteAccountForever(account.Id);
                Application.Exit();
            }
        }

        private void creditsButton_Click(object sender, EventArgs e)
        {
            HideSettingsMenu();

            DialogResult dialogResult = MessageBox.Show("This application was made by Nikola Petkanski", "Do you want to visit my github page?", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://github.com/nikoladevelops");
            }
        }

        private void copyEmailButton_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(StringCipher.Decrypt(account.Email, password));
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
                Clipboard.Clear();
        }

        private void clearClipboardButton_Click(object sender, EventArgs e)
        {
            // needs adjustments
            HideSettingsMenu();

            Clipboard.Clear();
        }
    }
}
