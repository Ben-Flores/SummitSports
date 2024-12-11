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
    public partial class frmPOS : Form
    {
        frmManagerLaunchpad parentForm;
        int personID;
        int managerID;

        StringBuilder searchFilter = new StringBuilder();
        StringBuilder categoriesFilter = new StringBuilder();

        public frmPOS(frmManagerLaunchpad parentForm, int managerID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.managerID = managerID;
            clsSQL.GetCustomers(dgvCustomers, this);
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            frmPOSCart.InventoryIDs.Clear();
            frmPOSCart.Quantities.Clear();
            frmCart.InventoryIDs.Clear();
            frmCart.Quantities.Clear();
        }

        private void frmPOS_Load(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
            dgvCustomers.ClearSelection();
        }

        private void frmPOS_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fullFilter;
            // dgvItems.ClearSelection();
            categoriesFilter.Clear();
            categoriesFilter.Append("CategoryID in (");
            foreach (int index in clbCategories.CheckedIndices)
            {
                categoriesFilter.Append(clsSQL.CategoriesList[index].categoryID.ToString() + ", ");
            }
            categoriesFilter.Append("0)");
            // MessageBox.Show(filter.ToString());

            if (searchFilter.ToString() != "")
            {
                fullFilter = categoriesFilter.ToString() + " And " + searchFilter.ToString();
            }
            else
            {
                fullFilter = categoriesFilter.ToString();
            }

            (dgvItems.DataSource as DataTable).DefaultView.RowFilter = fullFilter;
            dgvItems.ClearSelection();
        }

        private void tbxSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string fullFilter;
            // dgvItems.ClearSelection();
            searchFilter.Clear();
            searchFilter.Append("ItemName Like '%" + tbxSearch.Text + "%'");

            if (categoriesFilter.ToString() != "")
            {
                fullFilter = categoriesFilter.ToString() + " And " + searchFilter.ToString();
            }
            else
            {
                fullFilter = searchFilter.ToString();
            }

            (dgvItems.DataSource as DataTable).DefaultView.RowFilter = fullFilter;
            dgvItems.ClearSelection();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbxSearch.Text = "";
            for (int i = 0; i < clbCategories.Items.Count; i++)
            {
                clbCategories.SetItemChecked(i, true);
            }
            searchFilter.Clear();
            categoriesFilter.Clear();
            (dgvItems.DataSource as DataTable).DefaultView.RowFilter = "";
            dgvItems.ClearSelection();
        }

        private void dgvItems_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvItems.SelectedRows.Count > 0)
            {
                // MessageBox.Show(dgvItems.SelectedRows[0].Cells["InventoryID"].Value.ToString());
                int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;
                DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + id);
                foreach (var row in result)
                {
                    lblItemName.Text = (string)row["ItemName"];
                    lblItemDescription.Text = (string)row["ItemDescription"];
                    lblRetailPrice.Text = ((decimal)row["RetailPrice"]).ToString("C");
                    lblTotalPrice.Text = ((decimal)row["RetailPrice"]).ToString("C");
                    cbxQuantity.Items.Clear();
                    if ((int)row["Quantity"] < 1)
                    {
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        for (int i = 1; i <= (int)row["Quantity"]; i++)
                        {
                            cbxQuantity.Items.Add(i.ToString());
                        }
                        cbxQuantity.SelectedIndex = 0;
                        btnAdd.Enabled = true;
                    }
                    if (row["ItemImage"] != DBNull.Value)
                    {
                        using (MemoryStream ms = new MemoryStream((byte[])row["ItemImage"]))
                        {
                            Image image = Image.FromStream(ms);
                            pbxItem.Image = image;
                        }
                    }
                    else
                    {
                        pbxItem.Image = Resources.iconNormal;
                    }
                }
                if (frmPOSCart.InventoryIDs.Count < 1)
                {
                    lblCartQty.Text = "0";
                }
                else
                {
                    for (int i = 0; i < frmPOSCart.InventoryIDs.Count; i++)
                    {
                        if (frmPOSCart.InventoryIDs[i] == id)
                        {
                            lblCartQty.Text = frmPOSCart.Quantities[i].ToString();
                            btnRemove.Enabled = true;
                            break;
                        }
                        if (i == frmPOSCart.InventoryIDs.Count - 1)
                        {
                            lblCartQty.Text = "0";
                            btnRemove.Enabled = false;
                        }
                    }
                }
            }
            else
            {
                lblItemName.Text = "Select an item from the grid above ▲";
                lblItemDescription.Text = "...and see more details here.";
                lblRetailPrice.Text = "$0.00";
                cbxQuantity.Items.Clear();
                lblTotalPrice.Text = "$0.00";
                lblCartQty.Text = "";
                pbxItem.Image = Resources.iconNormal;
                btnAdd.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        private void cbxQuantity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = (Convert.ToInt32(cbxQuantity.SelectedItem) * Convert.ToDecimal(lblRetailPrice.Text.Substring(1))).ToString("C");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;
            int qty = Convert.ToInt32(cbxQuantity.SelectedItem);

            if (frmPOSCart.InventoryIDs.Count < 1)
            {
                frmPOSCart.InventoryIDs.Add(id);
                frmPOSCart.Quantities.Add(qty);
            }
            else
            {
                for (int i = 0; i < frmPOSCart.InventoryIDs.Count; i++)
                {
                    if (frmPOSCart.InventoryIDs[i] == id)
                    {
                        frmPOSCart.Quantities[i] += qty;
                        break;
                    }
                    if (i == frmPOSCart.InventoryIDs.Count - 1)
                    {
                        frmPOSCart.InventoryIDs.Add(id);
                        frmPOSCart.Quantities.Add(qty);
                        break;
                    }
                }
            }

            DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + id);
            result[0]["Quantity"] = (int)result[0]["Quantity"] - qty;
            cbxQuantity.Items.Clear();
            if ((int)result[0]["Quantity"] < 1)
            {
                btnAdd.Enabled = false;
            }
            else
            {
                for (int i = 1; i <= (int)result[0]["Quantity"]; i++)
                {
                    cbxQuantity.Items.Add(i.ToString());
                }
                cbxQuantity.SelectedIndex = 0;
                btnAdd.Enabled = true;
            }

            for (int i = 0; i < frmPOSCart.InventoryIDs.Count; i++)
            {
                if (frmPOSCart.InventoryIDs[i] == id)
                {
                    lblCartQty.Text = frmPOSCart.Quantities[i].ToString();
                    break;
                }
                if (i == frmPOSCart.InventoryIDs.Count - 1)
                {
                    lblCartQty.Text = "0";
                }
            }

            int cartItems = 0;
            for (int i = 0; i < frmPOSCart.Quantities.Count; i++)
            {
                cartItems += frmPOSCart.Quantities[i];
            }
            lblCartItems.Text = cartItems.ToString();

            btnRemove.Enabled = true;
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                btnCart.Enabled = true;
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;

            for (int i = 0; i < frmPOSCart.InventoryIDs.Count; i++)
            {
                if (frmPOSCart.InventoryIDs[i] == id)
                {
                    DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + id);
                    result[0]["Quantity"] = (int)result[0]["Quantity"] + frmPOSCart.Quantities[i];
                    cbxQuantity.Items.Clear();
                    if ((int)result[0]["Quantity"] < 1)
                    {
                        btnAdd.Enabled = false;
                    }
                    else
                    {
                        for (int j = 1; j <= (int)result[0]["Quantity"]; j++)
                        {
                            cbxQuantity.Items.Add(j.ToString());
                        }
                        cbxQuantity.SelectedIndex = 0;
                        btnAdd.Enabled = true;
                    }
                    frmPOSCart.InventoryIDs.RemoveAt(i);
                    frmPOSCart.Quantities.RemoveAt(i);
                    break;
                }
            }

            lblCartQty.Text = "0";
            btnRemove.Enabled = false;

            if (frmPOSCart.InventoryIDs.Count < 1)
            {
                lblCartItems.Text = "0";
                btnCart.Enabled = false;
            }
            else
            {
                int cartItems = 0;
                for (int i = 0; i < frmPOSCart.Quantities.Count; i++)
                {
                    cartItems += frmPOSCart.Quantities[i];
                }
                lblCartItems.Text = cartItems.ToString();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
            frmPOSCart frmPOSCart = new frmPOSCart(this, personID, managerID);
            frmPOSCart.ShowDialog();
        }

        public void ReloadCartItems()
        {
            if (frmPOSCart.InventoryIDs.Count < 1)
            {
                lblCartItems.Text = "0";
                btnCart.Enabled = false;
            }
            else
            {
                int cartItems = 0;
                for (int i = 0; i < frmPOSCart.Quantities.Count; i++)
                {
                    cartItems += frmPOSCart.Quantities[i];
                }
                lblCartItems.Text = cartItems.ToString();
            }
        }

        public void ResetShop()
        {
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            dgvItems.ClearSelection();

            btnCustomerReset_Click(null, null);

            ReloadCartItems();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic4_Shop.htm");
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                int customerID = (int)dgvCustomers.SelectedRows[0].Cells["id"].Value;
                personID = customerID;
                if (frmPOSCart.InventoryIDs.Count > 0)
                    btnCart.Enabled = true;
            }
            else
            {
                btnCart.Enabled = false;
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
            btnCart.Enabled = false;
        }
    }
}
