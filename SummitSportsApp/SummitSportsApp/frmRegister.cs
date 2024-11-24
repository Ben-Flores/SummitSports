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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext1_Click(object sender, EventArgs e)
        {
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
    }
}
