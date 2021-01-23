using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Register
{
    public partial class SignUpForm : Form
    {
        private bool isSigningUp = true;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!File.Exists("important.info")) 
            {
                File.Create("important.info");
            }
        }

        private void onFirstTimeClicked(object sender, EventArgs e)
        {
            var button = sender as TextBox;
            button.Text = "";
            button.Click -= onFirstTimeClicked;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            if (isSigningUp)
            {
                signUpButton.Text = "Sign In";
                signInButton.Text = "Sign Up Instead";
                isSigningUp = false;
            }
            else
            {
                signUpButton.Text = "Sign Up";
                signInButton.Text = "Sign In Instead";
                isSigningUp = true;

            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            if (isSigningUp)
            {
                var email = emailTextBox.Text;
                var password = passwordTextBox.Text;

                var encryptedEmail = StringCipher.Encrypt(email, email);
                var encryptedPassword = StringCipher.Encrypt(password, password);

                //using (var writer = new StreamWriter("important.info"))
                //{
                //    writer.WriteLine(encryptedEmail);
                //    writer.WriteLine(encryptedPassword);
                //}

                using (var reader = new StreamReader("important.info"))
                {
                    var encEmail = reader.ReadLine();
                    var encPass = reader.ReadLine();

                    var decryptedEmail = StringCipher.Decrypt(encEmail, email);
                    var decryptedPassword = StringCipher.Decrypt(encPass, password);

                    emailTextBox.Text = decryptedPassword;
                    passwordTextBox.Text = decryptedEmail;
                }


            }
        }
    }
}
