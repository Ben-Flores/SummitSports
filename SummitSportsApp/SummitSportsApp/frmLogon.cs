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
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();
        }

        private void frmLogon_FormClosing(object sender, FormClosingEventArgs e)
        {
            clsSQL.CloseConnection();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateLogonFilled(tbxUsername.Text, tbxPassword.Text, true))
            {
                if (clsSQL.OpenConnection())
                {
                    int position = clsSQL.VerifyUser(tbxUsername.Text, tbxPassword.Text, true);
                    if (position != 0)
                    {
                        switch (position)
                        {
                            case 1000:
                                MessageBox.Show("Logged in as MANAGER", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 1001:
                                MessageBox.Show("Logged in as EMPLOYEE", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                MessageBox.Show("Logged in as CUSTOMER", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                        clsSQL.CloseConnection();
                        tbxUsername.Text = "";
                        tbxPassword.Text = "";
                    }
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateLogonFilled(tbxUsername.Text, "pass not verified", false))
            {
                if (clsSQL.OpenConnection())
                {
                    if (clsSQL.VerifyUser(tbxUsername.Text, "pass not verified", false) != 0)
                    {
                        frmReset frmReset = new frmReset(this);
                        frmReset.Show();
                        this.Hide();
                    }
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (clsSQL.OpenConnection())
            {
                frmRegister frmRegister = new frmRegister(this);
                if (!frmRegister.IsDisposed)
                {
                    frmRegister.Show();
                    this.Hide();
                }
            }
        }
    }
}
