using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var newButton = new CustomButton(new Bitmap("img2.png"));
                passwordsPanel.Controls.Add(newButton);
            }

            //foreach (var control in passwordsPanel.Controls)
            //{
            //    var btn = control as Button;
            //    btn.Size = new Size(140, 140);
            //}
        }

    }
}
