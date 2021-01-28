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
        private string data;
        private int id;

        public CustomButton(int id, Bitmap image, string data)
        {
            this.Click += Clicked;
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            this.TabStop = false;
            this.Size = new Size(70, 70);
            this.BackgroundImageLayout = ImageLayout.Zoom;
            this.BackgroundImage = new Bitmap(image);
            this.data = data;
            this.id = id;
        }

        private void Clicked (object sender, System.EventArgs e)
        {
            Clipboard.SetText(data);
        }
    }
}
