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
    public partial class frmInventory : Form
    {
        frmManagerLaunchpad parentForm;

        StringBuilder searchFilter = new StringBuilder();
        StringBuilder categoriesFilter = new StringBuilder();

        public frmInventory(frmManagerLaunchpad parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.GetManagerInventory(dgvItems, clbCategories, this);
        }

        private void frmInventory_Load(object sender, EventArgs e)
        {
            dgvItems.ClearSelection();
        }

        private void frmInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsSQL.CloseConnection();
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
            tbxItemName.Text = "";
            tbxDescription.Text = "";
            tbxPrice.Text = "";
            tbxCost.Text = "";
            tbxQuantity.Text = "";
            tbxThreshold.Text = "";
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
                    tbxItemName.Text = (string)row["ItemName"];
                    tbxDescription.Text = (string)row["ItemDescription"];
                    tbxPrice.Text = ((decimal)row["RetailPrice"]).ToString("0.00");
                    tbxCost.Text = ((decimal)row["Cost"]).ToString("0.00");
                    tbxQuantity.Text = ((int)row["Quantity"]).ToString();
                    tbxThreshold.Text = ((int)row["RestockThreshold"]).ToString();
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
                btnResetItem.Enabled = true;
                btnUpdateItem.Enabled = true;
                btnDiscontinue.Enabled = true;
                btnImage.Enabled = true;
            }
            else
            {
                tbxItemName.Text = "";
                tbxDescription.Text = "";
                tbxPrice.Text = "";
                tbxCost.Text = "";
                tbxQuantity.Text = "";
                tbxThreshold.Text = "";
                pbxItem.Image = Resources.iconNormal;
                btnResetItem.Enabled = false;
                btnUpdateItem.Enabled = false;
                btnDiscontinue.Enabled = false;
                btnImage.Enabled = false;
            }
        }

        private void btnResetItem_Click(object sender, EventArgs e)
        {
            int index = dgvItems.CurrentCell.RowIndex;
            dgvItems.ClearSelection();
            dgvItems.Rows[index].Selected = true;
        }

        private void btnUpdateItem_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;
            if (clsSQL.UpdateInventoryRow(id, tbxItemName.Text, tbxDescription.Text, Convert.ToDecimal(tbxPrice.Text), Convert.ToDecimal(tbxCost.Text), Convert.ToInt32(tbxQuantity.Text), Convert.ToInt32(tbxThreshold.Text)))
            {
                clsSQL.GetManagerInventory(dgvItems, clbCategories, this);
                dgvItems.ClearSelection();
                btnReset_Click(null, null);
            }
        }

        private void btnDiscontinue_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;
            if (clsSQL.DiscontinueInventoryRow(id))
            {
                clsSQL.GetManagerInventory(dgvItems, clbCategories, this);
                dgvItems.ClearSelection();
                btnReset_Click(null, null);
            }
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            int id = (int)dgvItems.SelectedRows[0].Cells["InventoryID"].Value;

            OpenFileDialog openFile = new OpenFileDialog();
            openFile.ValidateNames = true;
            openFile.AddExtension = false;
            openFile.Filter = "Image File|*.png|Image File|*.jpg";
            openFile.Title = "Choose Image";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                byte[] image = File.ReadAllBytes(openFile.FileName);
                if (clsSQL.UpdateImage(id, image))
                {
                    clsSQL.GetManagerInventory(dgvItems, clbCategories, this);
                    dgvItems.ClearSelection();
                    btnReset_Click(null, null);
                }
            }
        }

        private void tbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidatePrice(e);
        }

        private void tbxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidateCost(e);
        }

        private void tbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidateQuantity(e);
        }

        private void tbxThreshold_KeyPress(object sender, KeyPressEventArgs e)
        {
            clsValidation.ValidateThreshold(e);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmNewInventory frmNewInventory = new frmNewInventory(this);
            if (!frmNewInventory.IsDisposed)
            {
                frmNewInventory.ShowDialog();
            }

        }

        public void RefreshItems()
        {
            clsSQL.GetManagerInventory(dgvItems, clbCategories, this);
            dgvItems.ClearSelection();
            btnReset_Click(null, null);
        }
    }
}
