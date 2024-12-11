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
    public partial class frmUsers : Form
    {
        frmManagerLaunchpad parentForm;

        public frmUsers(frmManagerLaunchpad parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomers(dgvCustomers, this);
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
    }
}
