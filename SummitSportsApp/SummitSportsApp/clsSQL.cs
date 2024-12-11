using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

namespace SummitSportsApp
{
    internal class clsSQL
    {
        private const string CONNECTION_STRING = @"Server=3.130.26.194;" + "Database=inew233xfa24;" +
            "User ID=bfloresFA24;password=cpt_Tstc1";
        private static SqlConnection connection;
        private static SqlCommand command;
        private static SqlDataAdapter dataAdapter;
        private static DataTable dataTable;
        private static DataTable customersTable;
        private const string SCHEMA_NAME = "bfloresFA24.";

        public static DataTable DataTable
        {
            get { return dataTable; }
            set { dataTable = value; }
        }

        public static bool OpenConnection()
        {
            try
            {
                connection = new SqlConnection(CONNECTION_STRING);
                connection.Open();
                Debug.WriteLine("Database Connection Opened Successfully");
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Database connection unsuccessful\nSorry, please try again later.", "Error Opening Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static void CloseConnection()
        {
            try
            {
                if (connection != null)
                {
                   connection.Close();
                   connection.Dispose();
                }
                if (command != null)
                    command.Dispose();
                if (dataAdapter != null)
                    dataAdapter.Dispose();
                if (DataTable != null)
                    dataTable.Dispose();
                Debug.WriteLine("Database Connection Closed Successfully.");
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Database connection unable to close", "Error Closing Database Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #region logon

        public static int VerifyUser(string user, string pass, bool verifyPass, Label lblError, ref int personID)
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                if (verifyPass)
                    command = new SqlCommand("Select LogonName, Password, PositionID, PersonID From " + SCHEMA_NAME + "Logon", connection);
                else
                    command = new SqlCommand("Select LogonName From " + SCHEMA_NAME + "Logon", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    DataRow row = dataTable.Rows[i];
                    if (row["LogonName"].ToString().ToLower() == user.ToLower())
                    {
                        if (verifyPass)
                        {
                            if (row["Password"].ToString() == pass)
                            {
                                personID = (int)row["PersonID"];
                                return (int)row["PositionID"];
                            }
                            else
                            {
                                lblError.Text = "Incorrect password.";
                                //MessageBox.Show("Incorrect password.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                return 0;
                            }
                        }
                        else
                        {
                            return 1;
                        }
                    }
                    else
                    {
                        if (i == dataTable.Rows.Count - 1 && pass != "checkUnique") 
                        {
                            lblError.Text = "Username not found.";
                            //MessageBox.Show("Username not found.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            //return false;
                        }
                    }
                }
                return 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to verify credentials.\nSorry, please try again later.", "Error Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }

        public static void PopulateQuestions(ComboBox question1, ComboBox question2, ComboBox question3, ref List<int>set1, ref List<int> set2, ref List<int> set3, frmRegister form)
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select * From " + SCHEMA_NAME + "SecurityQuestions", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                foreach (DataRow row in dataTable.Rows) 
                {
                    if ((int)row["SetID"] == 1)
                    {
                        question1.Items.Add(row["QuestionPrompt"]);
                        set1.Add((int)row["QuestionID"]);
                    }
                    else if ((int)row["SetID"] == 2)
                    {
                        question2.Items.Add(row["QuestionPrompt"]);
                        set2.Add((int)row["QuestionID"]);
                    }
                    else if ((int)row["SetID"] == 3)
                    {
                        question3.Items.Add(row["QuestionPrompt"]);
                        set3.Add((int)row["QuestionID"]);
                    }
                }

                question1.SelectedIndex = 0;
                question2.SelectedIndex = 0;
                question3.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to retrieve security questions.\nSorry, please try again later.", "Error Retrieving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static void FetchQuestions(string user, Label question1, Label question2, Label question3, ref List<string> answers, Form form)
        {
            try
            {
                int q1, q2, q3;

                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select FirstChallengeQuestion, SecondChallengeQuestion, ThirdChallengeQuestion, FirstChallengeAnswer, SecondChallengeAnswer, ThirdChallengeAnswer From " + SCHEMA_NAME + "Logon Where LogonName = '" + user +  "';", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                DataRow row = dataTable.Rows[0];

                q1 = (int)row[0];
                q2 = (int)row[1];
                q3 = (int)row[2];

                answers.Add(row[3].ToString());
                answers.Add(row[4].ToString());
                answers.Add(row[5].ToString());

                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select QuestionPrompt From " + SCHEMA_NAME + "SecurityQuestions Where QuestionID = " + q1 + ";", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                question1.Text = dataTable.Rows[0][0].ToString();

                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select QuestionPrompt From " + SCHEMA_NAME + "SecurityQuestions Where QuestionID = " + q2 + ";", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                question2.Text = dataTable.Rows[0][0].ToString();

                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select QuestionPrompt From " + SCHEMA_NAME + "SecurityQuestions Where QuestionID = " + q3 + ";", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);
                question3.Text = dataTable.Rows[0][0].ToString();

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to retrieve security questions.\nSorry, please try again later.", "Error Retrieving Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static void CreateNewUser(NewUser n, frmRegister form)
        {
            try
            {
                StringBuilder cmd = new StringBuilder();


                // Person Table Command
                cmd.Append("Insert Into " + SCHEMA_NAME + "Person (NameFirst, NameLast, Address1, City, State, Zipcode");

                if (n.title != "")
                    cmd.Append(", Title");
                if (n.mName != "")
                    cmd.Append(", NameMiddle");
                if (n.suffix != "")
                    cmd.Append(", Suffix");
                if (n.addy2 != "")
                    cmd.Append(", Address2");
                if (n.addy3 != "")
                    cmd.Append(", Address3");
                if (n.email != "")
                    cmd.Append(", Email");
                if (n.phone1 != "")
                    cmd.Append(", PhonePrimary");
                if (n.phone2 != "")
                    cmd.Append(", PhoneSecondary");

                cmd.Append(") " +
                    "Output INSERTED.PersonID " +
                    "Values ('" + n.fName + "', '" + n.lName + "', '" + n.addy1 + "', '" + n.city + "', '" + n.state + "', '" + n.zip + "'");

                if (n.title != "")
                    cmd.Append(", '" + n.title + "'");
                if (n.mName != "")
                    cmd.Append(", '" + n.mName + "'");
                if (n.suffix != "")
                    cmd.Append(", '" + n.suffix + "'");
                if (n.addy2 != "")
                    cmd.Append(", '" + n.addy2 + "'");
                if (n.addy3 != "")
                    cmd.Append(", '" + n.addy3 + "'");
                if (n.email != "")
                    cmd.Append(", '" + n.email + "'");
                if (n.phone1 != "")
                    cmd.Append(", '" + n.phone1 + "'");
                if (n.phone2 != "")
                    cmd.Append(", '" + n.phone2 + "'");

                cmd.Append(");");
                // MessageBox.Show(cmd.ToString());

                command = new SqlCommand(cmd.ToString(), connection);
                int personID = (int)command.ExecuteScalar();
                // MessageBox.Show(personID.ToString()); 

                cmd.Clear();

                cmd.Append("Insert Into " + SCHEMA_NAME + "Logon (PersonID, LogonName, Password, FirstChallengeQuestion, FirstChallengeAnswer, SecondChallengeQuestion, SecondChallengeAnswer, ThirdChallengeQuestion, ThirdChallengeAnswer, PositionID) Values (" +
                    personID + ", '" + n.user + "', '" + n.pass + "', " + n.question1 + ", '" + n.answer1 + "', " + n.question2 + ", '" + n.answer2 + "', " + n.question3 + ", '" + n.answer3 + "', 1002);");

                command = new SqlCommand(cmd.ToString(), connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Your account has been registered!", "Registration Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to save your account.\nSorry, please try again later.", "Error Registering Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static void ResetPassword(string user, string pass, Form form)
        {
            try
            {
                command = new SqlCommand("Update " + SCHEMA_NAME + "Logon Set Password = '" + pass + "' Where LogonName = '" + user + "';", connection);
                command.ExecuteNonQuery();
                MessageBox.Show("Your password has been reset!", "Password Reset Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                form.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to reset your password.\nSorry, please try again later.", "Password Reset Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        #endregion

        #region customer

        private static List<Category> categoriesList = new List<Category>();
        public static List<Category> CategoriesList
        {
            get { return categoriesList; }
        }

        public static void GetCustomerInventory(DataGridView dgv, CheckedListBox clb, Form form)
        {
            try
            {
                GetCategories(clb);
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select InventoryID, ItemName, ItemDescription, i.CategoryID, CategoryName, RetailPrice, Quantity, ItemImage From " + SCHEMA_NAME + "Inventory as i Join " + SCHEMA_NAME + "Categories as c On i.CategoryID = c.CategoryID Where Discontinued = 0 OR Discontinued Is Null Order By CategoryID, ItemName;", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
                dgv.Columns["inventoryID"].DataPropertyName = "InventoryID";
                dgv.Columns["itemName"].DataPropertyName = "ItemName";
                dgv.Columns["categoryName"].DataPropertyName = "CategoryName";
                dgv.Columns["retailPrice"].DataPropertyName = "RetailPrice";
                dgv.Columns["quantity"].DataPropertyName = "Quantity";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to get inventory items.\nSorry, please try again later.", "Inventory Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static void GetCategories(CheckedListBox clb)
        {
            categoriesList.Clear();
            clb.Items.Clear();
            try
            {
                command = new SqlCommand("Select CategoryID, CategoryName From " + SCHEMA_NAME + "Categories;", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    categoriesList.Add(new Category(reader.GetInt32(0), reader.GetString(1)));
                }
                foreach (Category category in categoriesList)
                {
                    clb.Items.Add(category.categoryName);
                    clb.SetItemChecked(clb.Items.Count  - 1, true);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                throw ex;
            }
        }

        public static bool FindDiscount(TextBox codeBox, ref Discount discount)
        {
            try
            {
                command = new SqlCommand("Select DiscountID, DiscountCode, DiscountLevel, InventoryID, DiscountType, DiscountPercentage, DiscountDollarAmount, ExpirationDate From " + SCHEMA_NAME + "Discounts Where DiscountCode = '" + codeBox.Text.ToUpper() + "';", connection);
                SqlDataReader reader = command.ExecuteReader();
                if (!reader.HasRows)
                {
                    codeBox.ForeColor = System.Drawing.Color.Crimson;
                    reader.Close();
                    return false;
                }
                else
                {
                    while (reader.Read())
                    {
                        if (reader.GetDateTime(7) < DateTime.Now.Date) // expired?
                        {
                            codeBox.ForeColor = System.Drawing.Color.Crimson;
                            reader.Close();
                            return false;
                        }
                        else
                        {
                            discount = new Discount();
                            discount.discountID = reader.GetInt32(0);
                            discount.discountCode = reader.GetString(1);
                            discount.discountLevel = reader.GetInt32(2);
                            if (reader[3] != DBNull.Value)
                                discount.inventoryID = reader.GetInt32(3);
                            discount.discountType = reader.GetInt32(4);
                            if (reader[5] != DBNull.Value)
                                discount.discountPercentage = reader.GetDecimal(5);
                            if (reader[6] != DBNull.Value)
                                discount.discountDollarAmount = reader.GetDecimal(6);
                            reader.Close();
                            return true;
                        }
                    }
                }
                reader.Close();
                return false;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to get discount codes.\nSorry, please try again later.", "Discount Code Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static string FindName(int personID)
        {
            try
            {
                command = new SqlCommand("Select NameFirst, NameLast From " + SCHEMA_NAME + "Person as p Join " + SCHEMA_NAME + "Logon as l On p.PersonID = l.PersonID Where p.PersonID = " + personID + ";", connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string fullName = reader.GetString(0) + " " + reader.GetString(1);
                    reader.Close();
                    return fullName;
                }
                reader.Close();
                return "";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                // MessageBox.Show("Unable to get customer details.\nSorry, please try again later.", "Customer Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }
        }

        public static bool UpdateDatabaseQuantities()
        {
            try
            {
                for (int i = 0; i < frmCart.InventoryIDs.Count; i++)
                {
                    command = new SqlCommand("Update " + SCHEMA_NAME + "Inventory Set Quantity = Quantity - " + frmCart.Quantities[i] + " Where InventoryID = " + frmCart.InventoryIDs[i] + ";", connection);
                    command.ExecuteNonQuery();
                }
                for (int i = 0; i < frmPOSCart.InventoryIDs.Count; i++)
                {
                    command = new SqlCommand("Update " + SCHEMA_NAME + "Inventory Set Quantity = Quantity - " + frmPOSCart.Quantities[i] + " Where InventoryID = " + frmPOSCart.InventoryIDs[i] + ";", connection);
                    command.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to complete order.\nSorry, please try again later.", "Customer Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool InsertOrder(Order order, ref int orderID)
        {
            try
            {
                StringBuilder cmd = new StringBuilder();

                cmd.Append("Insert into " + SCHEMA_NAME + "Orders (PersonID, OrderDate, CC_Number, ExpDate, CCV");
                if (order.discount != null && order.discount.discountLevel == 0)
                    cmd.Append(", DiscountID");
                if (order.managerID != 0)
                    cmd.Append(", EmployeeID");
                cmd.Append(") Output INSERTED.OrderID Values (" + order.personID + ", '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + order.cardNumber + "', '" + order.expDate + "', '" + order.ccv + "'");
                if (order.discount != null && order.discount.discountLevel == 0)
                    cmd.Append(", " + order.discount.discountID);
                if (order.managerID != 0)
                    cmd.Append(", " + order.managerID);
                cmd.Append(");");

                //MessageBox.Show(cmd.ToString());

                command = new SqlCommand(cmd.ToString(), connection);
                int OrderID = (int)command.ExecuteScalar();
                orderID = OrderID;

                cmd.Clear();

                for (int i = 0; i < order.inventoryIDs.Count; i++) {
                    cmd.Append("Insert into " + SCHEMA_NAME + "OrderDetails (OrderID, InventoryID, Quantity");
                    if (order.discount != null && order.discount.inventoryID == order.inventoryIDs[i])
                        cmd.Append(", DiscountID");
                    cmd.Append(") Values (" + OrderID + ", " + order.inventoryIDs[i] + ", " + order.quantities[i]);
                    if (order.discount != null && order.discount.inventoryID == order.inventoryIDs[i])
                        cmd.Append(", " + order.discount.discountID);
                    cmd.Append(");");

                    command = new SqlCommand (cmd.ToString(), connection);
                    command.ExecuteNonQuery();
                    cmd.Clear();
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to complete order.\nSorry, please try again later.", "Customer Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        #endregion

        #region manager

        public static void GetCustomers(DataGridView dgv, Form form)
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                customersTable = new DataTable();
                command = new SqlCommand("Select PersonID, (Coalesce((Title + ' '), '') + NameFirst + ' ' + Coalesce((NameMiddle + ' '), '') + NameLast + Coalesce((' ' + Suffix), '')) as [FullName], Email, PhonePrimary, PhoneSecondary From " + SCHEMA_NAME + "Person Where PersonDeleted = 0 OR PersonDeleted Is Null Order By PersonID;", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(customersTable);

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = customersTable;
                dgv.Columns["ID"].DataPropertyName = "PersonID";
                dgv.Columns["name"].DataPropertyName = "FullName";
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to fetch customers.\nSorry, please try again later.", "Customer Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static void GetManagerInventory(DataGridView dgv, CheckedListBox clb, Form form)
        {
            try
            {
                GetCategories(clb);
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select InventoryID, ItemName, ItemDescription, i.CategoryID, CategoryName, RetailPrice, Cost, Quantity, RestockThreshold, ItemImage, Discontinued From " + SCHEMA_NAME + "Inventory as i Join " + SCHEMA_NAME + "Categories as c On i.CategoryID = c.CategoryID Order By CategoryID, ItemName;", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                dgv.AutoGenerateColumns = false;
                dgv.DataSource = dataTable;
                dgv.Columns["inventoryID"].DataPropertyName = "InventoryID";
                dgv.Columns["itemName"].DataPropertyName = "ItemName";
                dgv.Columns["categoryName"].DataPropertyName = "CategoryName";
                dgv.Columns["retailPrice"].DataPropertyName = "RetailPrice";
                dgv.Columns["cost"].DataPropertyName = "Cost";
                dgv.Columns["quantity"].DataPropertyName = "Quantity";
                dgv.Columns["restockThreshold"].DataPropertyName = "RestockThreshold";
                dgv.Columns["discontinued"].DataPropertyName = "Discontinued";

            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to get inventory items.\nSorry, please try again later.", "Inventory Request Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                form.Close();
            }
        }

        public static bool UpdateInventoryRow(int id, string name, string description, decimal price, decimal cost, int qty, int thr)
        {
            try
            {
                command = new SqlCommand("Update " + SCHEMA_NAME + "Inventory Set ItemName = '" + name + "', ItemDescription = '" + description + "', RetailPrice = " + price + ", Cost = " + cost + ", Quantity = " + qty + ", RestockThreshold = " + thr + "Where InventoryID = " + id + ";", connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to update inventory item.\nSorry, please try again later.", "Inventory Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool DiscontinueInventoryRow(int id)
        {
            try
            {
                command = new SqlCommand("Update " + SCHEMA_NAME + "Inventory Set Discontinued = 1 Where InventoryID = " + id + ";", connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to update inventory item.\nSorry, please try again later.", "Inventory Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool UpdateImage(int id, byte[] image)
        {
            try
            {
                command = new SqlCommand("Update " + SCHEMA_NAME + "Inventory Set ItemImage = (@Image) Where InventoryID = " + id + ";", connection);
                SqlParameter cmdParams = command.Parameters.AddWithValue("@Image", image);
                cmdParams.DbType = DbType.Binary;
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                MessageBox.Show("Unable to update inventory item image.\nSorry, please try again later.", "Inventory Update Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        #endregion
    }
}
