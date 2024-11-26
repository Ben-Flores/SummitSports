using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    public partial class frmNewPassword : Form
    {
        public frmNewPassword()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateReset(tbxPassword, tbxConfirm))
            {
                MessageBox.Show("Reset Successful");
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
    }
}
