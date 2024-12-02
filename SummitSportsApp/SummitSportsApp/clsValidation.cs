using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    internal class clsValidation
    {
        static Label errorLabel;

        #region frmLogon
        public static bool ValidateLogonFilled(string user, string pass, bool verifyPass, Label lblError)
        {
            errorLabel = lblError;
            if (user == "")
            {
                errorLabel.Text = "Please enter your username.";
                // MessageBox.Show("Please enter your username.", "Username Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else if (verifyPass && pass == "")
            {
                errorLabel.Text = "Please enter your password.";
                // MessageBox.Show("Please enter your password.", "Password Required", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
                return true;
        }
        #endregion



        #region frmRegister
        /*
         * FORM SUBMISSION VALIDATION
         */
        public static bool ValidatePersonalInfo(TextBox fName, TextBox lName, TextBox addy, TextBox city, TextBox state, TextBox zip, TextBox email, TextBox phone1, TextBox phone2)
        {
            // Trim all textboxes
            fName.Text = fName.Text.Trim();
            lName.Text = lName.Text.Trim();
            addy.Text = addy.Text.Trim();
            city.Text = city.Text.Trim();
            state.Text = state.Text.Trim();
            zip.Text = zip.Text.Trim();
            email.Text = email.Text.Trim();
            phone1.Text = phone1.Text.Trim();
            phone2.Text = phone2.Text.Trim();

            if (fName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your first name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                fName.Focus();
                return false;
            }
            else if (lName.Text.Length == 0)
            {
                MessageBox.Show("Please enter your last name.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lName.Focus();
                return false;
            }
            else if (addy.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please enter your address.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                addy.Focus();
                return false;
            }
            else if (city.Text.Length == 0)
            {
                MessageBox.Show("Please enter your city.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                city.Focus();
                return false;
            }
            else if (state.Text.Length != 2)
            {
                MessageBox.Show("Please enter a valid state.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                state.Focus();
                return false;
            }
            else if (zip.Text.Length != 5 && zip.Text.Length != 10)
            {
                MessageBox.Show("Please enter a valid ZIP code.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                zip.Focus();
                return false;
            }
            else if (email.Text.Length != 0 && !Regex.Match(email.Text, @"^(?!.*\.\.)[A-Z0-9](?:[A-Z0-9._%+-]*[A-Z0-9])?@[A-Z0-9](?:[A-Z0-9.-]*[A-Z0-9])?\.[A-Z]{2,}$", RegexOptions.IgnoreCase).Success)
            {
                MessageBox.Show("Please enter a valid email (or none at all).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
                return false;
            }
            else if (phone1.Text.Length != 0 && phone1.Text.Length != 14)
            {
                MessageBox.Show("Please enter a valid primary phone (or none at all).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone1.Focus();
                return false;
            }
            else if (phone2.Text.Length != 0 && phone2.Text.Length != 14)
            {
                MessageBox.Show("Please enter a valid secondary phone (or none at all).", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone2.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateCredentials(TextBox user, TextBox pass, TextBox conf)
        {
            if (user.Text.Length < 8 || char.IsDigit(user.Text[0]))
            {
                MessageBox.Show("Please enter a valid username.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user.Focus();
                return false;
            }
            else if (clsSQL.VerifyUser(user.Text, "checkUnique", false, errorLabel) != 0)
            {
                MessageBox.Show("That username is already taken.\nSorry, please enter a different username.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                user.Focus();
                return false;
            }
            else if (pass.Text.Length < 8 || CheckComplexity(pass.Text) < 3)
            {
                MessageBox.Show("Please enter a valid password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pass.Focus();
                return false;
            }
            else if (!(conf.Text == pass.Text))
            {
                MessageBox.Show("Passwords do not match.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conf.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }

        public static bool ValidateQuestions(TextBox question1, TextBox question2, TextBox question3)
        {
            question1.Text = question1.Text.Trim();
            question2.Text = question2.Text.Trim();
            question3.Text = question3.Text.Trim();

            if (question1.Text.Length == 0)
            {
                MessageBox.Show("Please answer the first security question.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                question1.Focus();
                return false;
            }
            else if (question2.Text.Length == 0)
            {
                MessageBox.Show("Please answer the second security question.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                question2.Focus();
                return false;
            }
            else if (question3.Text.Length == 0)
            {
                MessageBox.Show("Please answer the third security question.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                question3.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        /*
         * GENERAL IS IT FILLED CHECK
         */
        public static void ValidateFilled(object sender, Label label)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text.Trim()))
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }
        /*
         * STATE VALIDATION
         */
        public static void ValidateState(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static void ValidateStateFormat(object sender, Label label)
        {
            if (((TextBox)sender).Text.Length == 2)
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }
        /*
         * ZIP VALIDATION AND FORMATTING
         */
        public static void ValidateZip(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static void ValidateZipFormat(object sender, Label label)
        {
            if (((TextBox)sender).Text.Length == 5 || ((TextBox)sender).Text.Length == 10)
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        public static void FormatZip(object sender)
        {
            string stripped = Regex.Replace(((TextBox)sender).Text, "[^0-9]", "");
            if (stripped.Length > 5)
            {
                ((TextBox)sender).Text = stripped.Insert(5, "-");
                if (((TextBox)sender).Text.Length > 10)
                    ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 10);
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            }
            else
            {
                ((TextBox)sender).Text = stripped;
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            }
        }
        /*
         * EMAIL VALIDATION
         */
        public static void ValidateEmailFormat(object sender, Label label)
        {
            if (((TextBox)sender).Text.Length == 0 || Regex.Match(((TextBox)sender).Text, @"^(?!.*\.\.)[A-Z0-9](?:[A-Z0-9._%+-]*[A-Z0-9])?@[A-Z0-9](?:[A-Z0-9.-]*[A-Z0-9])?\.[A-Z]{2,}$", RegexOptions.IgnoreCase).Success)
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }
        /*
         * PHONE VALIDATION AND FORMATTING
         */
        public static void ValidatePhone(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static void ValidatePhoneFormat(object sender, Label label)
        {
            if (((TextBox)sender).Text.Length == 0 || ((TextBox)sender).Text.Length == 14)
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        public static void FormatPhone(object sender)
        {
            string stripped = Regex.Replace(((TextBox)sender).Text, "[^0-9]", "");
            if (stripped.Length > 6)
            {
                ((TextBox)sender).Text = "(" + stripped.Substring(0, 3) + ") " + stripped.Substring(3, 3) + "-" + stripped.Substring(6);
                if (((TextBox)sender).Text.Length > 14)
                    ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 14);
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            }
            else if (stripped.Length > 3)
            {
                ((TextBox)sender).Text = "(" + stripped.Substring(0, 3) + ") " + stripped.Substring(3);
                if (((TextBox)sender).Text.Length > 14)
                    ((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 14);
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            }
            else
            {
                ((TextBox)sender).Text = stripped;
                ((TextBox)sender).SelectionStart = ((TextBox)sender).Text.Length;
            }
        }
        /*
         * USERNAME AND PASSWORD VALIDATION AND FORMATTING
         */
        public static void ValidateUser(KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static void ValidatePass(KeyPressEventArgs e)
        {
            string specialChars = "!@#$%^&*()";
            if (char.IsLetterOrDigit(e.KeyChar) || specialChars.Contains(e.KeyChar.ToString()) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                SystemSounds.Beep.Play();
            }
        }

        public static void ValidateUserRequirements(TextBox sender, Label label)
        {
            if (sender.Text.Length >= 8 && !char.IsDigit(sender.Text[0]))
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        public static void ValidatePassRequirements(TextBox sender, Label label)
        {
            if (sender.Text.Length >= 8)
            {
                int complexity = CheckComplexity(sender.Text);

                if (complexity >= 3)
                    label.ForeColor = System.Drawing.Color.Black;
                else
                    label.ForeColor = System.Drawing.Color.Crimson;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        public static void ValidatePassConfirm(TextBox sender, TextBox password, Label labelConfirm, Label labelPass)
        {
            if (sender.Text.Length != 0 && labelPass.ForeColor != System.Drawing.Color.Crimson && sender.Text == password.Text)
            {
                labelConfirm.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                labelConfirm.ForeColor = System.Drawing.Color.Crimson;
            }
        }

        public static int CheckComplexity(string pass)
        {
            string specialChars = "!@#$%^&*()";
            int complexity = 0;

            if (pass.Any(char.IsUpper))
                complexity++;
            if (pass.Any(char.IsLower))
                complexity++;
            if (pass.Any(char.IsDigit))
                complexity++;
            foreach (char c in pass)
            {
                if (specialChars.Contains(c))
                {
                    complexity++;
                    break;
                }
            }

            return complexity;
        }
        #endregion



        #region frmReset
        public static bool ValidateAnswers(TextBox answer1, TextBox answer2, TextBox answer3, List<string> answers)
        {
            if (answer1.Text.ToLower() == answers[0].ToLower() && answer2.Text.ToLower() == answers[1].ToLower() && answer3.Text.ToLower() == answers[2].ToLower())
                return true;
            else
                return false;
        }

        public static bool ValidateReset(TextBox pass, TextBox conf)
        {
            if (pass.Text.Length < 8 || CheckComplexity(pass.Text) < 3)
            {
                MessageBox.Show("Please enter a valid password.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                pass.Focus();
                return false;
            }
            else if (!(conf.Text == pass.Text))
            {
                MessageBox.Show("Passwords do not match.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                conf.Focus();
                return false;
            }
            else
            {
                return true;
            }
        }
        #endregion
    }
}
