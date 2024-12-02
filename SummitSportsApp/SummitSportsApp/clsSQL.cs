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

        public static int VerifyUser(string user, string pass, bool verifyPass)
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                if (verifyPass)
                    command = new SqlCommand("Select LogonName, Password, PositionID From " + SCHEMA_NAME + "Logon", connection);
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
                                return (int)row["PositionID"];
                            }
                            else
                            {
                                MessageBox.Show("Incorrect password.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                            MessageBox.Show("Username not found.", "Login Unsuccessful", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
    }
}
