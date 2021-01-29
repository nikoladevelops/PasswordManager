using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public class CustomButton:Button
    {
        private string encryptedData;
        private int id;
        private string accountPass;

        public CustomButton(int id, Bitmap image, string encryptedData, string accountPass)
        {
            this.Click += Clicked;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            this.TabStop = false;
            this.Size = new Size(70, 70);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = new Bitmap(image);
            this.encryptedData = encryptedData;
            this.id = id;
            this.accountPass = accountPass;
        }

        private void Clicked (object sender, System.EventArgs e)
        {
            var data = StringCipher.Decrypt(encryptedData, accountPass);
            Clipboard.SetText(data);
        }
    }
}
