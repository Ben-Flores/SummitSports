using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    public partial class frmNewPassword : Form
    {
        Form parentForm;
        string user;

        public frmNewPassword(string user, Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
        }

        private void frmNewPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateReset(tbxPassword, tbxConfirm))
            {
                clsSQL.ResetPassword(user, tbxPassword.Text, this);
            }
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidatePass(e);
        }

        private void tbxConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidatePass(e);
        }

        private void tbxPassword_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidatePassRequirements((TextBox)sender, lblPassword);
            clsValidation.ValidatePassConfirm(tbxConfirm, (TextBox)sender, lblConfirm, lblPassword);
        }

        private void tbxConfirm_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidatePassConfirm((TextBox)sender, tbxPassword, lblConfirm, lblPassword);

        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar != '\0')
            {
                tbxPassword.PasswordChar = '\0';
                tbxConfirm.PasswordChar = '\0';
            }
            else
            {
                tbxPassword.PasswordChar = '●';
                tbxConfirm.PasswordChar = '●';
            }
        }
    }
}
