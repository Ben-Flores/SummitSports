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
        int personID;

        private static decimal subtotal, discount, discounttotal, tax, grandtotal;
        private const decimal TAX_RATE = .0825m;

        private static List<int> inventoryIDs = new List<int>();
        private static List<int> quantities = new List<int>();
        private static Discount cartDiscount = null;
        private static Discount potentialCartDiscount = null;

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

        public frmCart(frmShop parentForm, int personID)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.personID = personID;
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

            ReloadDiscount();

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

            ReloadDiscount();

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

        private void tbxDiscount_TextChanged(object sender, EventArgs e)
        {
            tbxDiscount.ForeColor = Color.Black;
            if (tbxDiscount.Text.Length > 0 && inventoryIDs.Count > 0)
            {
                btnDiscount.Enabled = true;
            }
            else
            {
                btnDiscount.Enabled = false;
            }
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
            frmCheckout frmCheckout = new frmCheckout(this);
            frmCheckout.ShowDialog();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {
            if (clsSQL.OpenConnection())
            {
                if (clsSQL.FindDiscount(tbxDiscount, ref potentialCartDiscount))
                {
                    //MessageBox.Show(cartDiscount.ToString());
                    if (CheckPotentialDiscount())
                        ReloadDiscount();
                }
                clsSQL.CloseConnection();
            }
        }

        private bool CheckPotentialDiscount()
        {
            if (potentialCartDiscount.discountLevel == 1)
            {
                for (int i = 0; i < inventoryIDs.Count; i++)
                {
                    if (inventoryIDs[i] == potentialCartDiscount.inventoryID)
                    {
                        cartDiscount = potentialCartDiscount;
                        return true;
                    }
                }
                tbxDiscount.ForeColor = Color.Crimson;
                potentialCartDiscount = null;
                return false;
            }
            else
            {
                cartDiscount = potentialCartDiscount;
                return true;
            }
        }

        private void ReloadDiscount()
        {
            if (inventoryIDs.Count < 1 || cartDiscount == null)
            {
                lblDiscount.Visible = false;
                lblDiscountedTotal.Visible = false;
                lblDiscountTitle.Visible = false;
                lblDiscountedTotalTitle.Visible = false;

                cartDiscount = null;
                tbxDiscount.Text = "";
            }
            else
            {
                if (cartDiscount.discountLevel == 0)
                {
                    if (cartDiscount.discountType == 0)
                    {
                        discount = -cartDiscount.discountPercentage * subtotal;
                        discounttotal = subtotal + discount;
                    }
                    else
                    {
                        discount = -cartDiscount.discountDollarAmount;
                        discounttotal = subtotal + discount;
                    }

                    tax = discounttotal * TAX_RATE;
                    grandtotal = discounttotal + tax;
                    lblTax.Text = tax.ToString("C");
                    lblTotal.Text = grandtotal.ToString("C");

                    lblDiscount.Text = "- " + (-discount).ToString("C");
                    lblDiscountedTotal.Text = discounttotal.ToString("C");

                    lblDiscount.Visible = true;
                    lblDiscountedTotal.Visible = true;
                    lblDiscountTitle.Visible = true;
                    lblDiscountedTotalTitle.Visible = true;

                }
                else
                {
                    for (int i = 0; i < inventoryIDs.Count; i++)
                    {
                        if (inventoryIDs[i] == cartDiscount.inventoryID)
                        {
                            if (cartDiscount.discountType == 0)
                            {
                                DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + inventoryIDs[i]);
                                decimal price = (decimal)result[0]["RetailPrice"];
                                int qty = quantities[i];
                                decimal total = price * qty;

                                discount = -cartDiscount.discountPercentage * total;
                                discounttotal = subtotal + discount;
                            }
                            else
                            {
                                int qty = quantities[i];
                                discount = -cartDiscount.discountDollarAmount * qty;
                                discounttotal = subtotal + discount;
                            }

                            tax = discounttotal * TAX_RATE;
                            grandtotal = discounttotal + tax;
                            lblTax.Text = tax.ToString("C");
                            lblTotal.Text = grandtotal.ToString("C");

                            lblDiscount.Text = "- " + (-discount).ToString("C");
                            lblDiscountedTotal.Text = discounttotal.ToString("C");

                            lblDiscount.Visible = true;
                            lblDiscountedTotal.Visible = true;
                            lblDiscountTitle.Visible = true;
                            lblDiscountedTotalTitle.Visible = true;

                            break;
                        }
                        if (i == inventoryIDs.Count - 1)
                        {
                            tbxDiscount.ForeColor = Color.Crimson;
                            cartDiscount = null;
                            ReloadDiscount();
                        }
                    }
                }
                if (cartDiscount != null)
                    tbxDiscount.Text = cartDiscount.discountCode;
            }
        }

        public void CreateOrder(string cardNumber, string ccv, string expDate)
        {
            int orderID = 0;
            Order order = new Order(personID, inventoryIDs, quantities, cartDiscount, lblDiscount.Text, lblDiscountedTotal.Text, lblTax.Text, lblTotal.Text, cardNumber, ccv, expDate);

            if (clsSQL.OpenConnection())
            {
                if (clsSQL.UpdateDatabaseQuantities())
                {
                    if (clsSQL.InsertOrder(order, ref orderID))
                    {
                        clsHTML.ClearReport();
                        clsHTML.PrintReport(clsHTML.GenerateReport(order, orderID));

                        inventoryIDs.Clear();
                        quantities.Clear();
                        cartDiscount = null;
                        potentialCartDiscount = null;
                        parentForm.ResetShop();
                        this.Close();
                    }
                }
            }
        }
    }
}
