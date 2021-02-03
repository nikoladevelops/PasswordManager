using System;

namespace Register
{
    public class TextBoxValidator
    {
        private string TEXT_INVALID_MESSAGE = "{0} must contain at least {1} characters.";
        private string TEXT_TOO_LONG_MESSAGE = "{0} is too long.";
        private string PASSWORDS_NOT_SAME_MESSAGE = "Passwords do NOT match.";

        private const int TEXT_MAXIMUM_LENGTH = 40;
        private const int USERNAME_MINIMUM_LENGTH = 3;
        private const int EMAIL_MINIMUM_LENGTH = 5;
        private const int PASSWORD_MINIMUM_LENGTH = 5;

        public void ValidateUsername(string username) 
        {
            ValidateText(username, "Username", USERNAME_MINIMUM_LENGTH, TEXT_MAXIMUM_LENGTH);
        }

        public void ValidateEmail(string email) 
        {
            var specialCharCount = 0;
            foreach (var symbol in email)
            {
                if (symbol=='@')
                {
                    specialCharCount++;
                }
            }

            if (specialCharCount!=1)
            {
                throw new ArgumentException("Email is not valid.");
            }

            ValidateText(email, "Email", EMAIL_MINIMUM_LENGTH, TEXT_MAXIMUM_LENGTH);
        }

        public void ValidatePassword(string password) 
        {
            ValidateText(password,"Password", PASSWORD_MINIMUM_LENGTH, TEXT_MAXIMUM_LENGTH);
        }

        public void CheckIfPasswordsAreSame(string password, string repeatedPassword) 
        {
            if (password != repeatedPassword)
            {
                throw new ArgumentException(PASSWORDS_NOT_SAME_MESSAGE);
            }
        }

        private void ValidateText(string text, string textBoxName, int minimumCharsAllowed, int maximumCharsAllowed) 
        {
            if (text.Length < minimumCharsAllowed)
            {
                var formattedText = string.Format(TEXT_INVALID_MESSAGE, textBoxName, minimumCharsAllowed);
                throw new ArgumentException(formattedText);
            }

            if (text.Length > maximumCharsAllowed)
            {
                throw new ArgumentException(string.Format(TEXT_TOO_LONG_MESSAGE),textBoxName);
            }
        }
    }
}
