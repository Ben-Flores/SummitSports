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
    public partial class frmShop : Form
    {

        frmLogon parentForm;
        int personID;

        StringBuilder searchFilter = new StringBuilder();
        StringBuilder categoriesFilter = new StringBuilder();

        public frmShop(frmLogon parentForm, int personID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.personID = personID;
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            frmCart.InventoryIDs.Clear();
            frmCart.Quantities.Clear();
        }

        public frmShop(frmLogon parentForm, bool guest)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            btnAdd.Visible = false;
            btnRemove.Visible = false;
            lblGuest.Visible = true;
            frmCart.InventoryIDs.Clear();
            frmCart.Quantities.Clear();
        }

        private void frmShop_Load(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
        }

        private void frmShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
            parentForm.ClearFields();
            parentForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
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

        private void btnSearch_Click(object sender, EventArgs e)
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
                DataRow[] result =  clsSQL.DataTable.Select("InventoryID = " + id);
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
                    using (MemoryStream ms = new MemoryStream((byte[])row["ItemImage"]))
                    {
                        Image image = Image.FromStream(ms);
                        pbxItem.Image = image;
                    }
                }
                if (frmCart.InventoryIDs.Count < 1)
                {
                    lblCartQty.Text = "0";
                }
                else
                {
                    for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
                    {
                        if (frmCart.InventoryIDs[i] == id)
                        {
                            lblCartQty.Text = frmCart.Quantities[i].ToString();
                            btnRemove.Enabled = true;
                            break;
                        }
                        if (i == frmCart.InventoryIDs.Count - 1)
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

            if (frmCart.InventoryIDs.Count < 1)
            {
                frmCart.InventoryIDs.Add(id);
                frmCart.Quantities.Add(qty);
            }
            else
            {
                for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
                {
                    if (frmCart.InventoryIDs[i] == id)
                    {
                        frmCart.Quantities[i] += qty;
                        break;
                    }
                    if (i == frmCart.InventoryIDs.Count - 1)
                    {
                        frmCart.InventoryIDs.Add(id);
                        frmCart.Quantities.Add(qty);
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

            for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
            {
                if (frmCart.InventoryIDs[i] == id)
                {
                    lblCartQty.Text = frmCart.Quantities[i].ToString();
                    break;
                }
                if (i == frmCart.InventoryIDs.Count - 1)
                {
                    lblCartQty.Text = "0";
                }
            }

            lblCartItems.Text = frmCart.InventoryIDs.Count.ToString();

            btnRemove.Enabled = true;
            btnCart.Enabled = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;

            for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
            {
                if (frmCart.InventoryIDs[i] == id)
                {
                    DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + id);
                    result[0]["Quantity"] = (int)result[0]["Quantity"] + frmCart.Quantities[i];
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
                    frmCart.InventoryIDs.RemoveAt(i);
                    frmCart.Quantities.RemoveAt(i);
                    break;
                }
            }

            lblCartQty.Text = "0";
            btnRemove.Enabled = false;

            if (frmCart.InventoryIDs.Count < 1)
            {
                lblCartItems.Text = "0";
                btnCart.Enabled = false;
            }
            else
            {
                lblCartItems.Text = frmCart.InventoryIDs.Count.ToString();
            }
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
            frmCart frmCart = new frmCart(this, personID);
            frmCart.ShowDialog();
        }

        public void ReloadCartItems()
        {
            if (frmCart.InventoryIDs.Count < 1)
            {
                lblCartItems.Text = "0";
                btnCart.Enabled = false;
            }
            else
            {
                lblCartItems.Text = frmCart.InventoryIDs.Count.ToString();
            }
        }

        public void ResetShop()
        {
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            dgvItems.ClearSelection();
            ReloadCartItems();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, hlpHelp.HelpNamespace, HelpNavigator.Topic, "Topic4_Shop.htm");
        }
    }
}
