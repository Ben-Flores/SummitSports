using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace SummitSportsApp
{
    public partial class frmCart : Form
    {
        frmShop parentForm;

        private static decimal subtotal, discount, discounttotal, tax, grandtotal;
        private const decimal TAX_RATE = .0825m;

        private static List<int> inventoryIDs = new List<int>();
        private static List<int> quantities = new List<int>();

        public static List<int> InventoryIDs
        {
            get { return inventoryIDs; }
            set { inventoryIDs = value; }
        }

        public static List<int> Quantities
        {
            get { return quantities; }
            set { quantities = value; }
        }

        public frmCart(frmShop parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;
        }

        private void frmCart_Load(object sender, EventArgs e)
        {
            subtotal = 0;
            string name;
            decimal price;
            int qty;
            decimal total;
            int index;

            lblDiscountTitle.Visible = false;
            lblDiscount.Visible = false;
            lblDiscountedTotalTitle.Visible = false;
            lblDiscountedTotal.Visible = false;

            dgvCart.ColumnCount = 5;
            dgvCart.Columns[0].Name = "Item:";
            dgvCart.Columns[1].Name = "Item Price:";
            dgvCart.Columns[2].Name = "Quantity:";
            dgvCart.Columns[3].Name = "Total Price:";
            dgvCart.Columns[4].Name = "Index";
            dgvCart.Columns[4].Visible = false;
            for (int i = 0; i < inventoryIDs.Count; i++)
            {
                DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + inventoryIDs[i]);
                name = result[0]["ItemName"].ToString();
                price = (decimal)result[0]["RetailPrice"];
                qty = quantities[i];
                total = price * qty;
                index = i;

                subtotal += total;

                string[] row = new string[] { name, price.ToString("C"), qty.ToString(), total.ToString("C"), index.ToString()};
                dgvCart.Rows.Add(row);
            }

            tax = subtotal * TAX_RATE;
            grandtotal = subtotal + tax;
            lblSubtotal.Text = subtotal.ToString("C");
            lblTax.Text = tax.ToString("C");
            lblTotal.Text = grandtotal.ToString("C");

            dgvCart.ClearSelection();
        }

        private void frmCart_FormClosed(object sender, FormClosedEventArgs e)
        {
            // parentForm.Close();
        }

        private void ReloadDGV()
        {
            dgvCart.Rows.Clear();
            subtotal = 0;
            if (inventoryIDs.Count > 0)
            {
                string name;
                decimal price;
                int qty;
                decimal total;
                int index;


                for (int i = 0; i < inventoryIDs.Count; i++)
                {
                    DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + inventoryIDs[i]);
                    name = result[0]["ItemName"].ToString();
                    price = (decimal)result[0]["RetailPrice"];
                    qty = quantities[i];
                    total = price * qty;
                    index = i;
                    subtotal += total;
                    string[] row = new string[] { name, price.ToString("C"), qty.ToString(), total.ToString("C"), index.ToString() };
                    dgvCart.Rows.Add(row);
                }

            }
            else
            {
                btnClear.Enabled = false;
                btnCheckout.Enabled = false;
                btnDiscount.Enabled = false;
            }
                tax = subtotal * TAX_RATE;
                grandtotal = subtotal + tax;
                lblSubtotal.Text = subtotal.ToString("C");
                lblTax.Text = tax.ToString("C");
                lblTotal.Text = grandtotal.ToString("C");

                dgvCart.ClearSelection();
        }

        private void dgvCart_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCart.SelectedRows.Count > 0)
            {
                btnRemove.Enabled = true;
                // btnClear.Enabled = true;
                // btnCheckout.Enabled = true;
            }
            else
            {
                btnRemove.Enabled = false;
                // btnClear.Enabled = false;
                // btnCheckout.Enabled = false;
            }
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = Convert.ToInt32(dgvCart.SelectedRows[0].Cells["Index"].Value);
            int id = inventoryIDs[index];
            DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + id);
            result[0]["Quantity"] = (int)result[0]["Quantity"] + frmCart.Quantities[index];
            frmCart.InventoryIDs.RemoveAt(index);
            frmCart.Quantities.RemoveAt(index);
            // dgvCart.Rows.RemoveAt(dgvCart.CurrentCell.RowIndex);
            ReloadDGV();
            parentForm.ReloadCartItems();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
            {
                DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + inventoryIDs[i]);
                result[0]["Quantity"] = (int)result[0]["Quantity"] + frmCart.Quantities[i];
            }
            inventoryIDs.Clear();
            quantities.Clear();
            ReloadDGV();
            parentForm.ReloadCartItems();
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {

        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }
    }
}
