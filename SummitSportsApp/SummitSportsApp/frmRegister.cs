using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Just for my reference: Form panels are at location 12, 69

namespace SummitSportsApp
{
    public partial class frmRegister : Form
    {
        Form parentForm;

        public frmRegister(Form parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            pnlPersonalInfo.Visible = true;
            pnlCredentials.Visible = false;
            pnlQuestions.Visible = false;
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.Show();
        }

        // PAGE NAVIGATION

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            // clsValidation.ValidatePersonalInfo();
            pnlPersonalInfo.Visible = false;
            pnlCredentials.Visible = true;
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            pnlCredentials.Visible = false;
            pnlPersonalInfo.Visible = true;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            pnlCredentials.Visible = false;
            pnlQuestions.Visible = true;
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            pnlQuestions.Visible = false;
            pnlCredentials.Visible = true;
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {

        }

        // FIELD VALIDATION

            // Are the required fields filled?

        private void tbxFirstName_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblFirstName);
        }

        private void tbxLastName_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblLastName);
        }

        private void tbxAddress1_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblAddress1);
        }

        private void tbxCity_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblCity);
        }

            // Are the fields in the right format?

        private void tbxState_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateStateFormat(sender, lblState);
        }

        private void tbxZip_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.FormatZip(sender); // App adds hyphen so user don't have to
            clsValidation.ValidateZipFormat(sender, lblZip);
        }

            // Validating actual characters

        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidateState(e, lblState);
        }

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidateZip(e, lblState);
        }
    }
}
