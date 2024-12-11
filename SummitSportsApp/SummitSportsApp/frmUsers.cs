using SummitSportsApp.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    public partial class frmUsers : Form
    {
        frmManagerLaunchpad parentForm;

        public frmUsers(frmManagerLaunchpad parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomersToEdit(dgvCustomers, this);
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();
        }

        private void frmUsers_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxCustomer_KeyUp(object sender, KeyEventArgs e)
        {
            string filter = "Convert(PersonID, System.String) Like '%" + tbxCustomer.Text + "%' OR " + "FullName Like '%" + tbxCustomer.Text + "%' OR " + "Email Like '%" + tbxCustomer.Text + "%' OR " + "PhonePrimary Like '%" + tbxCustomer.Text + "%' OR " + "PhoneSecondary Like '%" + tbxCustomer.Text + "%'";

            (dgvCustomers.DataSource as DataTable).DefaultView.RowFilter = filter;
            dgvCustomers.ClearSelection();
        }

        private void btnCustomerReset_Click(object sender, EventArgs e)
        {
            tbxCustomer.Text = "";
            (dgvCustomers.DataSource as DataTable).DefaultView.RowFilter = "";
            dgvCustomers.ClearSelection();
            btnCart.Enabled = false;
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int id = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
                DataRow[] result = clsSQL.CustomersTable.Select("PersonID = " + id);
                foreach (var row in result)
                {
                    tbxFirstName.Text = (string)row["NameFirst"];
                    tbxLastName.Text = (string)row["NameLast"];
                    tbxAddress1.Text = (string)row["Address1"];
                    tbxCity.Text = (string)row["City"];
                    tbxState.Text = (string)row["State"];
                    tbxZip.Text = (string)row["Zipcode"];
                    if (row["Title"] != DBNull.Value)
                        tbxTitle.Text = (string)row["Title"];
                    if (row["NameMiddle"] != DBNull.Value)
                        tbxMiddleName.Text = (string)row["NameMiddle"];
                    if (row["Suffix"] != DBNull.Value)
                        tbxSuffix.Text = (string)row["Suffix"];
                    if (row["Address2"] != DBNull.Value)
                        tbxAddress2.Text = (string)row["Address2"];
                    if (row["Address3"] != DBNull.Value)
                        tbxAddress3.Text = (string)row["Address3"];
                    if (row["Email"] != DBNull.Value)
                        tbxEmail.Text = (string)row["Email"];
                    if (row["PhonePrimary"] != DBNull.Value)
                        tbxPhone1.Text = (string)row["PhonePrimary"];
                    if (row["PhoneSecondary"] != DBNull.Value)
                        tbxPhone2.Text = (string)row["PhoneSecondary"];
                }
                btnResetUser.Enabled = true;
                btnUpdateUser.Enabled = true;
                btnDisableUser.Enabled = true;
                btnDeleteUser.Enabled = true;
            }
            else
            {
                tbxFirstName.Text = "";
                tbxLastName.Text = "";
                tbxAddress1.Text = "";
                tbxCity.Text = "";
                tbxState.Text = "";
                tbxZip.Text = "";
                tbxTitle.Text = "";
                tbxMiddleName.Text = "";
                tbxSuffix.Text = "";
                tbxAddress2.Text = "";
                tbxAddress3.Text = "";
                tbxEmail.Text = "";
                tbxPhone1.Text = "";
                tbxPhone2.Text = "";
                btnResetUser.Enabled = false;
                btnUpdateUser.Enabled = false;
                btnDisableUser.Enabled = false;
                btnDeleteUser.Enabled = false;
            }
        }

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
            //lblError1.Text = "";
            clsValidation.ValidateState(e);
        }

        private void tbxZip_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lblError1.Text = "";
            clsValidation.ValidateZip(e);
        }

        private void tbxPhone1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lblError1.Text = "";
            clsValidation.ValidatePhone(e);
        }

        private void tbxPhone2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //lblError1.Text = "";
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

        private void btnResetUser_Click(object sender, EventArgs e)
        {
            int index = dgvCustomers.CurrentCell.RowIndex;
            dgvCustomers.ClearSelection();
            dgvCustomers.Rows[index].Selected = true;
        }

        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
            tbxMiddleName.Text = tbxMiddleName.Text.Trim();
            tbxSuffix.Text = tbxSuffix.Text.Trim();
            tbxTitle.Text = tbxTitle.Text.Trim();
            tbxAddress2.Text = tbxAddress2.Text.Trim();
            tbxAddress3.Text = tbxAddress3.Text.Trim();
            if (clsValidation.ValidatePersonalInfo(tbxFirstName, tbxLastName, tbxAddress1, tbxCity, tbxState, tbxZip, tbxEmail, tbxPhone1, tbxPhone2, lblError1))
            {
                if (clsSQL.UpdateCustomerRow(id, tbxFirstName.Text, tbxLastName.Text, tbxAddress1.Text, tbxCity.Text, tbxState.Text, tbxZip.Text, tbxEmail.Text, tbxPhone1.Text, tbxPhone2.Text, tbxTitle.Text, tbxMiddleName.Text, tbxSuffix.Text, tbxAddress2.Text, tbxAddress3.Text))
                {
                    clsSQL.GetCustomersToEdit(dgvCustomers, this);
                    dgvCustomers.ClearSelection();
                    btnCustomerReset_Click(null, null);
                }
            }
            else // this call for email validation is to avoid confusing the stupid people that insist on breaking my database by entering space as an email
            {
                clsValidation.ValidateEmailFormat(tbxEmail, lblEmail);
            }
        }

        private void btnDisableUser_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
            if (clsSQL.DisableUser(id))
            {
                clsSQL.GetCustomersToEdit(dgvCustomers, this);
                dgvCustomers.ClearSelection();
                btnCustomerReset_Click(null, null);
            }
        }

        private void tbxFirstName_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblFirstName);
        }

        private void tbxLastName_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblLastName);
        }

        private void tbxAddress1_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblAddress1);
        }

        private void tbxCity_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateFilled(sender, lblCity);
        }

        private void tbxState_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateStateFormat(sender, lblState);
        }

        private void tbxZip_TextChanged(object sender, EventArgs e)
        {
            //clsValidation.FormatZip(sender); // App adds hyphen so user don't have to
            clsValidation.ValidateZipFormat(sender, lblZip);
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidateEmailFormat(sender, lblEmail);
        }

        private void tbxPhone1_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidatePhoneFormat(sender, lblPhone1);

        }

        private void tbxPhone2_TextChanged(object sender, EventArgs e)
        {
            clsValidation.ValidatePhoneFormat(sender, lblPhone2);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = (int)dgvCustomers.SelectedRows[0].Cells["ID"].Value;
            if (clsSQL.DeleteUser(id))
            {
                clsSQL.GetCustomersToEdit(dgvCustomers, this);
                dgvCustomers.ClearSelection();
                btnCustomerReset_Click(null, null);
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(this, 1002);
            if (!frmRegister.IsDisposed)
            {
                frmRegister.ShowDialog();
            }
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(this, 1001);
            if (!frmRegister.IsDisposed)
            {
                frmRegister.ShowDialog();
            }
        }

        private void btnNewManager_Click(object sender, EventArgs e)
        {
            frmRegister frmRegister = new frmRegister(this, 1000);
            if (!frmRegister.IsDisposed)
            {
                frmRegister.ShowDialog();
            }
        }

        public void RefreshUsers()
        {
            clsSQL.GetCustomersToEdit(dgvCustomers, this);
            dgvCustomers.ClearSelection();
            btnCustomerReset_Click(null, null);
        }
    }
}
