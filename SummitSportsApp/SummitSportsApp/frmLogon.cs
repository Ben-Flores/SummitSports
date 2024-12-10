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

        public void ClearFields()
        {
            tbxUsername.Text = "";
            tbxPassword.Text = "";
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
            if (clsValidation.ValidateLogonFilled(tbxUsername.Text, tbxPassword.Text, true, lblError))
            {
                if (clsSQL.OpenConnection())
                {
                    int personID = 0;
                    int position = clsSQL.VerifyUser(tbxUsername.Text, tbxPassword.Text, true, lblError, ref personID);
                    if (position != 0)
                    {
                        switch (position)
                        {
                            case 1000:
                                frmManagerLaunchpad frmManagerLaunchpad = new frmManagerLaunchpad(this, personID);
                                frmManagerLaunchpad.Show();
                                this.Hide();
                                //MessageBox.Show("Logged in as MANAGER", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            case 1001:
                                MessageBox.Show("Logged in as EMPLOYEE", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                            default:
                                frmShop frmShop = new frmShop(this, personID);
                                if (!frmShop.IsDisposed)
                                {
                                    frmShop.Show();
                                    this.Hide();
                                }
                                //MessageBox.Show("Logged in as CUSTOMER", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                break;
                        }
                        // clsSQL.CloseConnection();
                        tbxUsername.Text = "";
                        tbxPassword.Text = "";
                    }
                    clsSQL.CloseConnection();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (clsValidation.ValidateLogonFilled(tbxUsername.Text, "pass not verified", false, lblError))
            {
                if (clsSQL.OpenConnection())
                {
                    int x = 0;
                    if (clsSQL.VerifyUser(tbxUsername.Text, "pass not verified", false, lblError, ref x) != 0)
                    {
                        frmReset frmReset = new frmReset(this, tbxUsername.Text);
                        if (!frmReset.IsDisposed)
                        {
                            frmReset.Show();
                            this.Hide();
                        }
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

        private void btnPeek_Click(object sender, EventArgs e)
        {
            if (tbxPassword.PasswordChar != '\0')
                tbxPassword.PasswordChar = '\0';
            else
                tbxPassword.PasswordChar = '●';
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic1_Login.htm");
        }

        private void tbxUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
        }

        private void tbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            lblError.Text = "";
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
            if (clsSQL.OpenConnection())
            {
                frmShop frmShop = new frmShop(this, true);
                if (!frmShop.IsDisposed)
                {
                    frmShop.Show();
                    this.Hide();
                }
            }
        }
    }
}
