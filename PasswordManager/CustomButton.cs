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
        private string data = "254121224";
        public CustomButton(Bitmap image)
        {
            this.Click += Clicked;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            this.TabStop = false;
            this.Size = new Size(70, 70);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = new Bitmap(image);
        }
        public CustomButton(Bitmap image,Size size)
        {
            this.Click += Clicked;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            this.TabStop = false;
            this.Size = size;
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = new Bitmap(image);
        }

        private void Clicked (object sender, System.EventArgs e)
        {
            Clipboard.SetText(data);
        }
    }
}
