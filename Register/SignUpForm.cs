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
        private List<AccountModel> accounts = new List<AccountModel>();
        private bool isSigningUp = true;

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

            //TODO - MAKE A USERNAME TEXBOX THAT WILL BE UNIQUE AND PUBLIC


            AccountModel account =new AccountModel();
            var email = emailTextBox.Text;
            var password = passwordTextBox.Text;

            if (isSigningUp)
            {
                account.Email = StringCipher.Encrypt(email, email);
                account.Password = StringCipher.Encrypt(password, password);
                SqliteDataAccess.SaveAccount(account);
            }
            else 
            {
                var foundAccount = SqliteDataAccess.LoadAccount(email, password);
                if (foundAccount != null)
                {
                    emailTextBox.Text = foundAccount.Password;
                    passwordTextBox.Text = foundAccount.Email;

                }
                else
                {
                    emailTextBox.Text = "Errorrr";
                }
            }
        }
    }
}
