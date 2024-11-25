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
        /*
         * FORM SUBMISSION VALIDATION
         */   
        public static void ValidatePersonalInfo()
        {

        }

        public static void ValidateCredentials()
        {

        }

        public static void ValidateQuestions()
        {
            
        }
        /*
         * GENERAL IS IT FILLED CHECK
         */
        public static void ValidateFilled(object sender, Label label)
        {
            if (!string.IsNullOrEmpty(((TextBox)sender).Text))
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
        public static void ValidateState(KeyPressEventArgs e, Label label)
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
         * ZIP VALIDATION
         */
        public static void ValidateZip(KeyPressEventArgs e, Label label)
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
            if (((TextBox)sender).Text.Length == 5 || ((TextBox)sender).Text.Length == 10)
            {
                label.ForeColor = System.Drawing.Color.Black;
            }
            else
            {
                label.ForeColor = System.Drawing.Color.Crimson;
            }
        }
    }
}
