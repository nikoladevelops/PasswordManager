using DatabaseModels;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            // TODO Visualize all user buttons!
            // ALSO ADD A PASSWORD FIELD IN YOUR AccountItems table!!
            for (int i = 0; i < 10; i++)
            {
            }

            foreach (var item in accountItems)
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

        private void settings_Click(object sender, EventArgs e)
        {
            ((Button)sender).Focus();
        }
    }
}
