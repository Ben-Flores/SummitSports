﻿using System;
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
        frmLogon parentForm;
        NewUser newUser = new NewUser();
        List<int> set1 = new List<int>();
        List<int> set2 = new List<int>();
        List<int> set3 = new List<int>();


        public frmRegister(frmLogon parentForm)
        {
            this.parentForm = parentForm;
            InitializeComponent();
            pnlPersonalInfo.Visible = true;
            pnlCredentials.Visible = false;
            pnlQuestions.Visible = false;
            clsSQL.PopulateQuestions(cbxQuestion1, cbxQuestion2, cbxQuestion3, ref set1, ref set2, ref set3, this);
        }

        private void frmRegister_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.ClearFields();
            parentForm.Show();
        }

        // PAGE NAVIGATION

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clsSQL.CloseConnection();
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
            tbxMiddleName.Text = tbxMiddleName.Text.Trim();
            tbxSuffix.Text = tbxSuffix.Text.Trim();
            tbxTitle.Text = tbxTitle.Text.Trim();
            tbxAddress2.Text = tbxAddress2.Text.Trim();
            tbxAddress3.Text = tbxAddress3.Text.Trim();

            if (clsValidation.ValidatePersonalInfo(tbxFirstName, tbxLastName, tbxAddress1, tbxCity, tbxState, tbxZip, tbxEmail, tbxPhone1, tbxPhone2, lblError1))
            {
                newUser.title = tbxTitle.Text;
                newUser.fName = tbxFirstName.Text;
                newUser.mName = tbxMiddleName.Text;
                newUser.lName = tbxLastName.Text;
                newUser.suffix = tbxSuffix.Text;
                newUser.addy1 = tbxAddress1.Text;
                newUser.addy2 = tbxAddress2.Text;
                newUser.addy3 = tbxAddress3.Text;
                newUser.city = tbxCity.Text;
                newUser.state = tbxState.Text;
                newUser.zip = tbxZip.Text;
                newUser.email = tbxEmail.Text;
                newUser.phone1 = tbxPhone1.Text;
                newUser.phone2 = tbxPhone2.Text;
                
                pnlPersonalInfo.Visible = false;
                pnlCredentials.Visible = true;
            }
            else // this call for email validation is to avoid confusing the stupid people that insist on breaking my database by entering space as an email
            {
                clsValidation.ValidateEmailFormat(tbxEmail, lblEmail);
            }
        }

        private void btnBack2_Click(object sender, EventArgs e)
        {
            pnlCredentials.Visible = false;
            pnlPersonalInfo.Visible = true;
        }

        private void btnNext2_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateCredentials(tbxUsername, tbxPassword, tbxConfirm, lblError2))
            {
                newUser.user = tbxUsername.Text;
                newUser.pass = tbxPassword.Text;

                pnlCredentials.Visible = false;
                pnlQuestions.Visible = true;
            }
        }

        private void btnBack3_Click(object sender, EventArgs e)
        {
            pnlQuestions.Visible = false;
            pnlCredentials.Visible = true;
            
        }

        private void btnNext3_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateQuestions(tbxQuestion1, tbxQuestion2, tbxQuestion3, lblError3))
            {
                newUser.question1 = set1[cbxQuestion1.SelectedIndex];
                newUser.question2 = set2[cbxQuestion2.SelectedIndex];
                newUser.question3 = set3[cbxQuestion3.SelectedIndex];
                newUser.answer1 = tbxQuestion1.Text;
                newUser.answer2 = tbxQuestion2.Text;
                newUser.answer3 = tbxQuestion3.Text;

                clsSQL.CreateNewUser(newUser, this);
            }
        }

        // FIELD VALIDATION

        // PAGE 1

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

            // Validating characters

        private void tbxState_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = ""; 
            clsValidation.ValidateState(e);
        }

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = ""; 
            clsValidation.ValidateZip(e);
        }

        private void tbxPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = ""; 
            clsValidation.ValidatePhone(e);
        }

        private void tbxPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = ""; 
            clsValidation.ValidatePhone(e);
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

        private void tbxEmail_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateEmailFormat(sender, lblEmail);
        }

        

        private void tbxPhone1_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.FormatPhone(sender);
            clsValidation.ValidatePhoneFormat(sender, lblPhone1);
        }

        

        private void tbxPhone2_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.FormatPhone(sender);
            clsValidation.ValidatePhoneFormat(sender, lblPhone2);
        }

        // PAGE 2

            // Change instructions panel

        private void tbxUsername_Enter(object sender, EventArgs e)
        {
            gbxCredentials.Text = "Username Requirements:";
            lblRequirements.Text = "8-20 characters long.\r\nCannot begin with a number.\r\nCannot contain special characters.\r\nCannot contain spaces.";
        }

        private void tbxPassword_Enter(object sender, EventArgs e)
        {
            gbxCredentials.Text = "Password Requirements:";
            lblRequirements.Text = "8-20 characters long.\r\nMust contain at least 3 of the following:\r\n   Uppercase Letters\r\n   Lowercase Letters\r\n   Numbers\r\n   Special Characters ! @ # $ % ^ & * ( )";
        }

        private void tbxConfirm_Enter(object sender, EventArgs e)
        {
            gbxCredentials.Text = "Password Requirements:";
            lblRequirements.Text = "8-20 characters long.\r\nMust contain at least 3 of the following:\r\n   Uppercase Letters\r\n   Lowercase Letters\r\n   Numbers\r\n   Special Characters ! @ # $ % ^ & * ( )";
        }

            // Validating characters input

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError2.Text = ""; 
            clsValidation.ValidateUser(e);
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError2.Text = "";
            clsValidation.ValidatePass(e);
        }

        private void tbxConfirm_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError2.Text = "";
            clsValidation.ValidatePass(e);
        }

            // Validating entire submission

        private void tbxUsername_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateUserRequirements((TextBox)sender, lblUsername);
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

        // PAGE 3

            // Are the answers filled out?

        private void tbxQuestion1_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblQuestion1);
        }

        private void tbxQuestion2_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblQuestion2);
        }

        private void tbxQuestion3_KeyUp(object sender, KeyEventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblQuestion3);
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

        private void btnHelp1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic2_Register.htm");
        }

        private void btnHelp2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic2_Register.htm");
        }

        private void btnHelp3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic2_Register.htm");
        }

        private void tbxFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxLastName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxMiddleName_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxSuffix_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxTitle_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxAddress1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxAddress2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxAddress3_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }

        private void tbxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError1.Text = "";
        }
    }
}
