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
    public partial class frmReset : Form
    {
        frmLogon parentForm;
        List<string> answers = new List<string>();
        string user;
        public frmReset(frmLogon parentForm, string user)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.user = user;
            clsSQL.FetchQuestions(user, lblQuestion1, lblQuestion2, lblQuestion3, ref answers, this);
        }

        private void frmReset_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.ClearFields();
            parentForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // clsSQL.CloseConnection();
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateQuestions(tbxQuestion1, tbxQuestion2, tbxQuestion3, lblError))
            {
                if (clsValidation.ValidateAnswers(tbxQuestion1, tbxQuestion2 , tbxQuestion3, answers))
                {
                    frmNewPassword frmNewPassword = new frmNewPassword(user, this);
                    frmNewPassword.ShowDialog();
                }
                else
                {
                    lblError.Text = "One or more of your answers is not correct.";
                    //MessageBox.Show("One or more of your answers is not correct.", "Password Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic3_Reset.htm");
        }

        private void tbxQuestion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
        }

        private void tbxQuestion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
        }

        private void tbxQuestion3_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
        }
    }
}
