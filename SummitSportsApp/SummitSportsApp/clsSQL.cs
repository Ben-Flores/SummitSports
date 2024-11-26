using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

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

        public static void PopulateQuestions(ComboBox question1, ComboBox question2, ComboBox question3)
        {
            try
            {
                dataAdapter = new SqlDataAdapter();
                dataTable = new DataTable();
                command = new SqlCommand("Select * From " + SCHEMA_NAME + "SecurityQuestions", connection);
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(dataTable);

                //MessageBox.Show(DataTable.Rows.Count.ToString());
                foreach (DataRow row in dataTable.Rows) 
                {
                    if ((int)row["SetID"] == 1)
                    {
                        question1.Items.Add(row["QuestionPrompt"]);
                    }
                    else if ((int)row["SetID"] == 2)
                    {
                        question2.Items.Add(row["QuestionPrompt"]);
                    }
                    else if ((int)row["SetID"] == 3)
                    {
                        question3.Items.Add(row["QuestionPrompt"]);
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
            }
        }
    }
}
