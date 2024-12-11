using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummitSportsApp
{
    public partial class frmReports : Form
    {
        frmManagerLaunchpad parentForm;
        int personID;

        public frmReports(frmManagerLaunchpad parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomers(dgvCustomers, this);
            dgvCustomers.ClearSelection();
        }

        private void frmReports_Load(object sender, EventArgs e)
        {
            dgvCustomers.ClearSelection();

        }

        private void frmReports_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            if (clsSQL.GetAvailableInventory())
            {
                clsHTML.ClearReport();
                clsHTML.PrintReport(clsHTML.GenerateInventoryReport("Available Inventory"));
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            if (clsSQL.GetInventory())
            {
                clsHTML.ClearReport();
                clsHTML.PrintReport(clsHTML.GenerateInventoryReport("All Inventory"));
            }
        }

        private void btnRestock_Click(object sender, EventArgs e)
        {
            if (clsSQL.GetRestockInventory())
            {
                clsHTML.ClearReport();
                clsHTML.PrintReport(clsHTML.GenerateInventoryReport("Pending Restock"));
            }
        }

        private void btnDaily_Click(object sender, EventArgs e)
        {
            string startdate = dtpDate.Value.ToString("yyyy-MM-dd");
            string stopdate = startdate;

            if (personID == 0)
            {
                if (clsSQL.GetSales(startdate, stopdate))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Daily Sales", startdate, stopdate));
                }
            }
            else
            {
                if (clsSQL.GetSales(startdate, stopdate, personID))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Daily Sales", startdate, stopdate));
                }
            }
        }

        private void btnWeekly_Click(object sender, EventArgs e)
        {
            string startdate = dtpDate.Value.ToString("yyyy-MM-dd");
            string stopdate = dtpDate.Value.Add(new System.TimeSpan(6, 0, 0, 0)).ToString("yyyy-MM-dd");

            if (personID == 0)
            {
                if (clsSQL.GetSales(startdate, stopdate))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Weekly Sales", startdate, stopdate));
                }
            }
            else
            {
                if (clsSQL.GetSales(startdate, stopdate, personID))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Weekly Sales", startdate, stopdate));
                }
            }
        }

        private void btnMonthly_Click(object sender, EventArgs e)
        {
            string startdate = dtpDate.Value.ToString("yyyy-MM-dd");
            string stopdate = dtpDate.Value.Add(new System.TimeSpan(29, 0, 0, 0)).ToString("yyyy-MM-dd");

            if (personID == 0)
            {
                if (clsSQL.GetSales(startdate, stopdate, personID))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Monthly Sales", startdate, stopdate));
                }
            }
            else
            {
                if (clsSQL.GetSales(startdate, stopdate))
                {
                    clsHTML.ClearReport();
                    clsHTML.PrintReport(clsHTML.GenerateSalesReport("Monthly Sales", startdate, stopdate));
                }
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if (clsSQL.GetCustomersRep())
            {
                clsHTML.ClearReport();
                clsHTML.PrintReport(clsHTML.GenerateUserReport("Customer Info"));
            }
        }

        private void btnEmployee_Click(object sender, EventArgs e)
        {
            if (clsSQL.GetEmployeesRep())
            {
                clsHTML.ClearReport();
                clsHTML.PrintReport(clsHTML.GenerateUserReport("Employee/Manager Info"));
            }
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic6_Reports.htm");
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerID = (int)dgvCustomers.SelectedRows[0].Cells["id"].Value;
                personID = customerID;
            }
            else
            {
                personID = 0;
            }
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
        }
    }
}
