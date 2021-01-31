using DatabaseModels;
using System.Drawing;
using System.Windows.Forms;

namespace PasswordManager
{
    public class CustomButton:Button
    {
        public string EncryptedData { get; }
        public string AccountPassword { get; }
        public int Id { get; }

        public CustomButton(int id, Bitmap image, string encryptedData, string accountPass)
        {
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            this.TabStop = false;
            this.Size = new Size(70, 70);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = new Bitmap(image);
            this.EncryptedData = encryptedData;
            this.Id = id;
            this.AccountPassword = accountPass;
        }
    }
}
