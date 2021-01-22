using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Register
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void onFirstTimeClicked(object sender, EventArgs e)
        {
            var button = sender as TextBox;
            button.Text = "";
            button.Click -= onFirstTimeClicked;
        }
    }
}
