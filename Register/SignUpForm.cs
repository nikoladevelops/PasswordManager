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
using System.Threading;

namespace Register
{
    public partial class SignUpForm : Form
    {
        private List<AccountModel> accounts = new List<AccountModel>();
        private List<TextBox> textBoxes = new List<TextBox>();
        private bool isSigningUp = true;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxes.AddRange(new TextBox[]
            { 
                usernameTextBox,
                emailTextBox,
                passwordTextBox,
                repeatPasswordTextBox
            });
        }

        private void onFirstTimeClicked(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;
            textBox.Text = "";
            textBox.Click -= onFirstTimeClicked;
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            foreach (var textBox in textBoxes)
            {
                textBox.Click += onFirstTimeClicked;
            }

            usernameTextBox.Text = "Username";
            passwordTextBox.Text = "Password";
            repeatPasswordTextBox.Text = "Repeat Password";

            if (isSigningUp)
            {
                emailTextBox.Text = null;
                repeatPasswordTextBox.Text = null;
                signUpButton.Text = "Sign In";
                signInButton.Text = "Sign Up Instead";
                isSigningUp = false;

                emailTextBox.Visible = false;
                repeatPasswordTextBox.Visible = false;
            }
            else
            {
                emailTextBox.Text = "Email";
                repeatPasswordTextBox.Text = "Repeat Password";
                signUpButton.Text = "Sign Up";
                signInButton.Text = "Sign In Instead";
                isSigningUp = true;

                emailTextBox.Visible = true;
                repeatPasswordTextBox.Visible = true;

            }
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;

            AccountModel account =new AccountModel();
            if (isSigningUp)
            {
                var email = emailTextBox.Text;

                if (password != repeatPasswordTextBox.Text) 
                {
                    throw new ArgumentException("Passwords don't match");
                }
                // TODO - make a TextBoxValidator class, what happens if a texbox is null?

                account.Username = username;
                account.Email = StringCipher.Encrypt(email, password);
                account.Password = StringCipher.Encrypt(password, password);
                SqliteDataAccess.SaveAccount(account);
            }
            else 
            {
                var foundAccount = SqliteDataAccess.LoadAccount(username, password);
                if (foundAccount != null)
                {
                    // TODO LOAD PASSWORD MANAGER WITH ACCOUNT ITEMS
                    emailTextBox.Text = foundAccount.Password;
                    passwordTextBox.Text = foundAccount.Email;
                    
                    var newForm = new PasswordManager.PasswordManagerForm();
                    this.Visible = false;
                    newForm.ShowDialog();
                    this.Close();

                }
                else
                {
                    emailTextBox.Text = "Errorrr";
                }
            }
        }
    }
}
