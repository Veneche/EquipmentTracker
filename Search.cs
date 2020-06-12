using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApp1
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        private void btnDispatchSearch_Click(object sender, EventArgs e)
        {
            string[] headers = new string[] { "Dispatch Number", "Canister ID", "Flow Controller ID", "Certification Number", "Date Sent", "Client", "Number of Cans Sent", "Accessories Sent" };
            int count = 0;

            //clear listview
            lstSearch.Items.Clear();

            //display headers
            if (lstSearch.Columns.Count == 0)
            {
                foreach (var header in headers)
                {
                    lstSearch.Columns.Add(new ColumnHeader());
                    lstSearch.Columns[count].Text = header;
                    count += 1;
                }
            }
            else if (lstSearch.Columns.Count > 0 && lstSearch.Columns[3].Text != "Certification Number")
            {
                for (int i = 3; i < 8; i++)
                {
                    lstSearch.Columns[i].Text = headers[i];
                }
            }
            

            //get selected option
            var selectedSearch = cmbDisp.SelectedIndex;
            var strSelected = "";

            switch (selectedSearch)
            {
                case 0:
                    strSelected = "Canister_ID";
                    break;
                case 1:
                    strSelected = "FlowController_ID";
                    break;
                case 2:
                    strSelected = "Date_sent";
                    break;
                case 3:
                    strSelected = "Client";
                    break;
                case 4:
                    strSelected = "Dispatch_Number";
                    break;
                case 5:
                    strSelected = "Certification_Number";
                    break;
                default:
                    strSelected = "none";
                    break;
            }

            //get search value
            var searchValue = txtDispSearch.Text;

            //read and display data
            readData("Dispatch", strSelected, searchValue, "Date_Sent");

            //autosize columns
            foreach (ColumnHeader column in lstSearch.Columns)
            {
                column.Width = -2;
            }
        }

        

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDispSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnDispatchSearch_Click(sender, e);

                e.Handled = true;

            }
        }

        private void btnReceiptSearch_Click(object sender, EventArgs e)
        {
            string[] headers = new string[] { "Dispatch Number", "Canister ID", "Flow Controller ID", "Date Received", "Report Number", "Client", "Accessories Returned", "Comments" };
            int count = 0;

            //clear listview
            lstSearch.Items.Clear();

            //display headers
            if (lstSearch.Columns.Count == 0)
            {
                foreach (var header in headers)
                {
                    lstSearch.Columns.Add(new ColumnHeader());
                    lstSearch.Columns[count].Text = header;
                    count += 1;
                }
            }
            else if (lstSearch.Columns.Count > 0 && lstSearch.Columns[3].Text != "Date Received")
            {
                for (int i = 3; i < 8; i++)
                {
                    lstSearch.Columns[i].Text = headers[i];
                }
            }


            //get selected option
            var selectedSearch = cmbReceipt.SelectedIndex;
            var strSelected = "";

            switch (selectedSearch)
            {
                case 0:
                    strSelected = "Canister_ID";
                    break;
                case 1:
                    strSelected = "FlowController_ID";
                    break;
                case 2:
                    strSelected = "Date_Received";
                    break;
                case 3:
                    strSelected = "Client";
                    break;
                case 4:
                    strSelected = "Dispatch_Number";
                    break;
                case 5:
                    strSelected = "Report_Number";
                    break;
                default:
                    strSelected = "none";
                    break;
            }

            //get search value
            var searchValue = txtRecSearch.Text;

            //read and display data
            readData("Receipt", strSelected, searchValue, "Date_Received");

            //autosize columns
            foreach (ColumnHeader column in lstSearch.Columns)
            {
                column.Width = -2;
            }
        }


        public void readData(string dispOrRec, string strSearch, string strSearchWord,string strOrderCol)
        {
            // Connection string and SQL query  
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\Data\AirToxics.mdb";
            string strSQL;

            //if none display all
            if (strSearch == "none" | strSearchWord == "")
            {
                strSQL = "SELECT * FROM " + dispOrRec + " ORDER BY " + strOrderCol + " DESC";
            }
            else
            //else search
            {
                DateTime datetimenew;

                //if date then convert date to datetime type
                if (strSearch.Contains("Date"))
                {
                    datetimenew = Convert.ToDateTime(strSearchWord);
                    strSQL = "SELECT * FROM " + dispOrRec + " WHERE " + strSearch + " = #" + strSearchWord + "# ORDER BY " + strOrderCol + " DESC";
                } else
                {
                    strSQL = "SELECT * FROM " + dispOrRec + " WHERE " + strSearch + "='" + strSearchWord + "' ORDER BY " + strOrderCol + " DESC";
                }

                
            }

            // Create a connection  
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                // Create a command and set its connection  
                OleDbCommand command = new OleDbCommand(strSQL, connection);
                // Open the connection and execute the select command.  
                try
                {
                    // Open connecton  
                    connection.Open();

                    // Execute command  
                    using (OleDbDataReader reader = command.ExecuteReader())
                    {
                        Console.WriteLine("------------Original data----------------");
                        while (reader.Read())
                        {

                            //remove time from datetime field
                            string datetime;
                            int pos;
                            string date;

                            string[] row = { };


                            if (dispOrRec == "Dispatch")
                            {
                                datetime = reader["Date_Sent"].ToString();
                                pos = datetime.IndexOf(" ");
                                date = datetime.Substring(0, pos);

                                row = new string[8] { reader["Dispatch_Number"].ToString(), reader["Canister_ID"].ToString(), reader["FlowController_ID"].ToString(), reader["Certification_Number"].ToString(), date, reader["Client"].ToString(), reader["No_of_cans"].ToString(), reader["Accessories_sent"].ToString() };
                            }
                            else if (dispOrRec == "Receipt")
                            {
                                datetime = reader["Date_Received"].ToString();
                                pos = datetime.IndexOf(" ");
                                date = datetime.Substring(0, pos);

                                row = new string[8] { reader["Dispatch_Number"].ToString(), reader["Canister_ID"].ToString(), reader["FlowController_ID"].ToString(), date, reader["Report_Number"].ToString(), reader["Client"].ToString(), reader["Accessories_returned"].ToString(), reader["Comments"].ToString() };
                            }


                            var listViewItem = new ListViewItem(row);

                            lstSearch.Items.Add(listViewItem);


                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                // The connection is automatically closed becasuse of using block.  
            }
        }

        private void txtRecSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnReceiptSearch_Click(sender, e);

                e.Handled = true;

            }
        }

        private void cmbDisp_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbDisp.SelectedIndex)
            {
                case 0:
                    lblDisp.Text = "Enter Can ID:";
                    break;
                case 1:
                    lblDisp.Text = "Enter FC ID:";
                    break;
                case 2:
                    lblDisp.Text = "Enter Date Sent as YYYY/MM/DD:";
                    break;
                case 3:
                    lblDisp.Text = "Enter Client name:";
                    break;
                case 4:
                    lblDisp.Text = "Enter Dispatch Number:";
                    break;
                case 5:
                    lblDisp.Text = "Enter Cert Number:";
                    break;
                default:
                    break;
            }
        }

        private void cmbReceipt_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbReceipt.SelectedIndex)
            {
                case 0:
                    lblRec.Text = "Enter Can ID:";
                    break;
                case 1:
                    lblRec.Text = "Enter FC ID:";
                    break;
                case 2:
                    lblRec.Text = "Enter Date Received as YYYY/MM/DD:";
                    break;
                case 3:
                    lblRec.Text = "Enter Client name:";
                    break;
                case 4:
                    lblRec.Text = "Enter Dispatch Number:";
                    break;
                case 5:
                    lblRec.Text = "Enter Report Number:";
                    break;
                default:
                    break;
            }
        }
    }
}
