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
    public partial class frmNewInventory : Form
    {
        frmInventory parentForm;
        List<int> categoryIDs = new List<int>();

        public frmNewInventory(frmInventory parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            clsSQL.PopulateCategories(cbxCategories, ref categoryIDs, this);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            tbxItemName.Text = tbxItemName.Text.Trim();
            tbxDescription.Text = tbxDescription.Text.Trim();
            if (clsValidation.ValidateInventoryItem(tbxItemName, tbxDescription, tbxPrice, tbxCost, tbxQuantity, tbxThreshold, lblError))
            {
                if (clsSQL.AddInventoryRow(tbxItemName.Text, tbxDescription.Text, Convert.ToDecimal(tbxPrice.Text), Convert.ToDecimal(tbxCost.Text), Convert.ToInt32(tbxQuantity.Text), Convert.ToInt32(tbxThreshold.Text), categoryIDs[cbxCategories.SelectedIndex]))
                {
                    this.Close();
                }
            }
        }

        private void frmNewInventory_FormClosed(object sender, FormClosedEventArgs e)
        {
            parentForm.RefreshItems();
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
    }
}
