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

        StringBuilder searchFilter = new StringBuilder();
        StringBuilder categoriesFilter = new StringBuilder();

        public frmShop(frmLogon parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
        }

        public frmShop(frmLogon parentForm, bool guest)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetCustomerInventory(dgvItems, clbCategories, this);
            btnAdd.Visible = false;
            btnRemove.Visible = false;
            lblGuest.Visible = true;
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
            for (int i = 1; i < clbCategories.Items.Count; i++)
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
                    for (int i = 1; i <= (int)row["Quantity"]; i++)
                    {
                        cbxQuantity.Items.Add(i.ToString());
                    }
                    cbxQuantity.SelectedIndex = 0;
                    using (MemoryStream ms = new MemoryStream((byte[])row["ItemImage"]))
                    {
                        Image image = Image.FromStream(ms);
                        pbxItem.Image = image;
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
            }
        }
    }
}
