using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Globalization;
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

        public static void PrintReceipt(StringBuilder html)
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
                using (StreamWriter writer = new StreamWriter(path + "\\" + filename + " - Report.html", false))
                {
                    writer.WriteLine(html);
                }
                Process.Start(path + "\\" + filename + " - Report.html");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.ToString());
                MessageBox.Show("You do not have write permissions for this feature.", "Error with System Permissions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region reports

        public static StringBuilder GenerateInventoryReport(string title)
        {
            css.AppendLine("<style>");
            css.AppendLine("body {margin: auto; padding-top: 20; font-family: rockwell; text-align:center; max-width: 1500; background-color:DimGray}");
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
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>{title}<br>" + DateTime.Now + "</h1>");
            //html.AppendLine($"<h3>Your Receipt - " + DateTime.Now + "</h3>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><th id=\"left\">ID</th><th id=\"left\">Item</th><th id=\"left\">Category</th><th>Price</th><th>Cost</th><th>Quantity</th><th>Threshold</th></tr>");
            html.AppendLine("<tr><td colspan=7></td></tr>");

            int id;
            string name;
            string category;
            decimal price;
            decimal cost;
            int qty;
            int thr;

            for (int i = 0; i < clsSQL.DataTable.Rows.Count; i++)
            {
                DataRow result = clsSQL.DataTable.Rows[i];

                id = (int)result["InventoryID"];
                name = result["ItemName"].ToString();
                category = result["CategoryName"].ToString();
                price = (decimal)result["RetailPrice"];
                cost = (decimal)result["Cost"];
                qty = (int)result["Quantity"];
                thr = (int)result["RestockThreshold"];

                html.Append("<tr>");
                html.Append($"<td id=\"left\">{id}</td>");
                html.Append($"<td id=\"left\">{name}</td>");
                html.Append($"<td id=\"left\">{category}</td>");
                html.Append($"<td>{price.ToString("C")}</td>");
                html.Append($"<td>{cost.ToString("C")}</td>");
                html.Append($"<td>{qty}</td>");
                html.Append($"<td>{thr}</td>");
                html.Append("</tr>");
            }
            html.AppendLine("</body></html>");
            return html;
        }

        public static StringBuilder GenerateUserReport(string title)
        {
            css.AppendLine("<style>");
            css.AppendLine("body {margin: auto; padding-top: 20; font-family: rockwell; text-align:center; max-width: 1500; background-color:DimGray}");
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
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>{title}<br>" + DateTime.Now + "</h1>");
            //html.AppendLine($"<h3>Your Receipt - " + DateTime.Now + "</h3>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><th id=\"left\">ID</th><th id=\"left\">Username</th><th id=\"left\">Name</th><th id=\"left\">Address Line 1</th><th id=\"left\">Address Line 2</th><th id=\"left\">Address Line 3</th><th id=\"left\">City</th><th id=\"left\">State</th><th id=\"left\">ZIP</th><th id=\"left\">Email</th><th id=\"left\">Phone #1</th><th id=\"left\">Phone #2</th></tr>");
            html.AppendLine("<tr><td colspan=12></td></tr>");

            int id;
            string user;
            string name;
            string addy1;
            string addy2;
            string addy3;
            string city;
            string state;
            string zip;
            string email;
            string phone1;
            string phone2;

            for (int i = 0; i < clsSQL.DataTable.Rows.Count; i++)
            {
                DataRow result = clsSQL.DataTable.Rows[i];

                id = (int)result["PersonID"];
                user = result["LogonName"].ToString();
                name = result["FullName"].ToString();
                addy1 = result["Address1"].ToString();
                addy2 = result["Address2"].ToString();
                addy3 = result["Address3"].ToString();
                city = result["City"].ToString();
                state = result["State"].ToString();
                zip = result["Zipcode"].ToString();
                email = result["Email"].ToString();
                phone1 = result["PhonePrimary"].ToString();
                phone2 = result["PhoneSecondary"].ToString();

                html.Append("<tr>");
                html.Append($"<td id=\"left\">{id}</td>");
                html.Append($"<td id=\"left\">{user}</td>");
                html.Append($"<td id=\"left\">{name}</td>");
                html.Append($"<td id=\"left\">{addy1}</td>");
                html.Append($"<td id=\"left\">{addy2}</td>");
                html.Append($"<td id=\"left\">{addy3}</td>");
                html.Append($"<td id=\"left\">{city}</td>");
                html.Append($"<td id=\"left\">{state}</td>");
                html.Append($"<td id=\"left\">{zip}</td>");
                html.Append($"<td id=\"left\">{email}</td>");
                html.Append($"<td id=\"left\">{phone1}</td>");
                html.Append($"<td id=\"left\">{phone2}</td>");
                html.Append("</tr>");
            }
            html.AppendLine("</body></html>");
            return html;
        }

        public static StringBuilder GenerateSalesReport(string title, string start, string end)
        {
            css.AppendLine("<style>");
            css.AppendLine("body {margin: auto; padding-top: 20; font-family: rockwell; text-align:center; max-width: 1500; background-color:DimGray}");
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
            html.AppendLine($"<head>{css}<title>{title}</title></head>");
            html.AppendLine("<body>");
            html.AppendLine($"<h1>{title}<br>" + DateTime.Now + "</h1>");
            if (start.Equals(end))
                html.AppendLine($"<h1>{DateTime.ParseExact(start, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy")}</h1>");
            else
                html.AppendLine($"<h1>{DateTime.ParseExact(start, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy")} - {DateTime.ParseExact(end, "yyyy-MM-dd", CultureInfo.InvariantCulture).ToString("MM/dd/yyyy")}</h1>");
            //html.AppendLine($"<h3>Your Receipt - " + DateTime.Now + "</h3>");

            html.AppendLine("<table>");
            html.AppendLine("<tr><th id=\"left\">Order</th><th id=\"left\">Date</th><th id=\"left\">PersonID</th><th id=\"left\">Name</th><th id=\"left\">Item Name</th><th id=\"left\">Quantity</th><th id=\"left\">Total</th></tr>");
            html.AppendLine("<tr><td colspan=7></td></tr>");

            int orderid;
            string date;
            int personid;
            string name;
            string item;
            int qty;
            decimal total;
            decimal grandtotal = 0;

            for (int i = 0; i < clsSQL.DataTable.Rows.Count; i++)
            {
                DataRow result = clsSQL.DataTable.Rows[i];

                orderid = (int)result["OrderID"];
                date = result["OrderDate"].ToString();
                personid = (int)result["PersonID"];
                name = result["Name"].ToString();
                item = result["ItemName"].ToString();
                qty = (int)result["Quantity"];
                total = (decimal)result["Total"];
                grandtotal += total;

                html.Append("<tr>");
                html.Append($"<td id=\"left\">{orderid}</td>");
                html.Append($"<td id=\"left\">{DateTime.Parse(date).ToString("MM/dd/yyyy")}</td>");
                html.Append($"<td id=\"left\">{personid}</td>");
                html.Append($"<td id=\"left\">{name}</td>");
                html.Append($"<td id=\"left\">{item}</td>");
                html.Append($"<td id=\"left\">{qty}</td>");
                html.Append($"<td id=\"left\">{total}</td>");
                html.Append("</tr>");
            }
            html.AppendLine($"<h3 id=\"gainsboro\">Grand Total: {grandtotal.ToString("C")}</h3>");
            html.AppendLine("</body></html>");
            return html;
        }

        #endregion


        public static void ClearReport()
        {
            html = new StringBuilder();
            css = new StringBuilder();
        }
    }
}
