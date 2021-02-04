using System;
using System.Collections.Generic;
using System.Windows.Forms;
using PasswordManager;
using DatabaseModels;

namespace Register
{
    public partial class SignUpForm : Form
    {
        private List<TextBox> textBoxes = new List<TextBox>();
        private bool isSigningUp = true;

        public SignUpForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //TODO create Accounts.db if it doesn't exist
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
            errorLabel.Visible = false;

            foreach (var textBox in textBoxes)
            {
                textBox.Click += onFirstTimeClicked;
            }

            usernameTextBox.Text = "Username";
            passwordTextBox.Text = "Password";
            repeatPasswordTextBox.Text = "Repeat Password";

            if (isSigningUp)
            {
                this.Text = "Sign In";
                panel.Padding = new Padding(0, 66, 0, 0);
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
                this.Text = "Sign Up";
                panel.Padding = new Padding(0, 0, 0, 0);
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
            errorLabel.Visible = false;

            var username = usernameTextBox.Text;
            var password = passwordTextBox.Text;
            var email = emailTextBox.Text;

            var account =new AccountModel();
            if (isSigningUp)
            {
                try
                {
                    var validator = new TextBoxValidator();
                    validator.ValidateEmail(email);
                    validator.ValidateUsername(username);
                    validator.ValidatePassword(password);
                    validator.CheckIfPasswordsAreSame(password, repeatPasswordTextBox.Text);

                    account.Username = username;
                    account.Email = StringCipher.Encrypt(email, password);
                    account.Password = StringCipher.Encrypt(password, password);
                    SqliteDataAccess.SaveAccount(account);
                    signInButton.PerformClick();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = $"ERROR: {ex.Message}";
                    errorLabel.Visible = true;
                }
            }
            else 
            {
                try
                {
                    var foundAccount = SqliteDataAccess.LoadAccount(username, password);
               
                    var newForm = new PasswordManagerForm(foundAccount,password);
                    this.Visible = false;
                    newForm.ShowDialog();
                    this.Close();
                }
                catch (Exception ex)
                {
                    errorLabel.Text = $"ERROR: {ex.Message}";
                    errorLabel.Visible = true;
                }
            }
        }
    }
}
