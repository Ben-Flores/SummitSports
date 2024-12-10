using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace SummitSportsApp
{
    internal class clsHTML
    {
        private static StringBuilder html = new StringBuilder();
        private static StringBuilder css = new StringBuilder();

        public static StringBuilder GenerateReceipt(Order order, int orderID)
        {
            string customerName = "";
            string managerName = "";
            if (clsSQL.OpenConnection())
            {
                customerName = clsSQL.FindName(order.personID);
                if (order.managerID != 0)
                    managerName = clsSQL.FindName(order.managerID);
            }

            css.AppendLine("<style>");
            css.AppendLine("body {margin: auto; padding-top: 20; font-family: rockwell; text-align:center; max-width: 600; background-color:DimGray}");
            css.AppendLine("table {margin: auto; width: 100%; border: 3px solid black; border-collapse: collapse}");
            css.AppendLine("td, th {background-color: gainsboro; padding: 5px; text-align:right; font-weight: bold; border: 3px solid black; border-collapse: collapse}");
            css.AppendLine("th {font-size: 20}");
            css.AppendLine("#left {text-align:left}");
            css.AppendLine("h1 {}");
            css.AppendLine("h2 {text-align:left}");
            css.AppendLine("h3 {text-align:right}");
            css.AppendLine("#gainsboro {color: gainsboro; font-size: 24}");
            css.AppendLine("</style>");

            html.AppendLine("<html>");
            html.AppendLine($"<head>{css}<title>Your Receipt</title></head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>Summit Sports Purchase<br>" + DateTime.Now + "</h1>");
            html.AppendLine($"<h2>Customer: " + customerName + "</h2>");
            if (order.managerID != 0)
                html.AppendLine($"<h2>Sales Associate: " + managerName + "</h2>");
            html.AppendLine($"<h2>OrderID: " + orderID + "</h2>");
            //html.AppendLine($"<h3>Your Receipt - " + DateTime.Now + "</h3>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><th id=\"left\">Item</th><th>Item Price</th><th>Quantity</th><th>Total Price</th></tr>");
            html.AppendLine("<tr><td colspan=4></td></tr>");

            string name;
            decimal price;
            int qty;
            decimal total;
            decimal subtotal = 0;

            for (int i = 0; i < order.inventoryIDs.Count; i++)
            {
                DataRow[] result = clsSQL.DataTable.Select("InventoryID = " + order.inventoryIDs[i]);
                name = result[0]["ItemName"].ToString();
                price = (decimal)result[0]["RetailPrice"];
                qty = order.quantities[i];
                total = price * qty;
                subtotal += total;

                html.Append("<tr>");
                html.Append($"<td id=\"left\">{name}</td>");
                html.Append($"<td>{price.ToString("C")}</td>");
                html.Append($"<td>{qty}</td>");
                html.Append($"<td>{total.ToString("C")}</td>");
                html.Append("</tr>");
            }
            html.AppendLine("</table>");
            html.AppendLine($"<h3>Subtotal: {subtotal.ToString("C")}</h3>");

            if (order.discount != null)
            {
                html.AppendLine($"<h3>Discount ({order.discount.discountCode}): {order.discounted}</h3>");
                html.AppendLine($"<h3>Discounted Total: {order.discountedTotal}</h3>");
                html.AppendLine($"<h3>Tax (8.25%): {order.discountedTax}</h3>");
                html.AppendLine($"<h3 id=\"gainsboro\">Total Due: {order.grandTotal}</h3>");
            }
            else
            {
                html.AppendLine($"<h3>Tax (8.25%): {(subtotal * .0825m).ToString("C")}</h3>");
                html.AppendLine($"<h3 id=\"gainsboro\">Total Due: {(subtotal * 1.0825m).ToString("C")}</h3>");
            }
            html.AppendLine("</body></html>");
            return html;
        }

        public static void PrintReport(StringBuilder html)
        {
            try
            {
                string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\Summit Sports";
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                DateTime now = DateTime.Now;
                string filename = now.ToString("yyyy-MM-dd-HHmmss");
                using (StreamWriter writer = new StreamWriter(path + "\\" + filename + " - Receipt.html", false))
                {
                    writer.WriteLine(html);
                }
                Process.Start(path + "\\" + filename + " - Receipt.html");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show("You do not have write permissions for this feature.", "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void ClearReport()
        {
            html = new StringBuilder();
            css = new StringBuilder();
        }
    }
}
