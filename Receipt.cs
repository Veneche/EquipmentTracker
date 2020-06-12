using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmReceipt : Form
    {
        public frmReceipt()
        {
            InitializeComponent();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //get textbox value
                var txtValue = txtCan.Text;

                //add textbox value to listbox
                lstCans.Items.Add(txtValue);

                //clear textbox and focus
                txtCan.Clear();
                txtCan.Focus();

                //update can count
                txtNoCans.Text = lstCans.Items.Count.ToString();
                e.Handled = true;

            }
        }

        private void txtFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                //get textbox value
                var txtValue = txtFC.Text;

                //add textbox value to listbox
                lstFCs.Items.Add(txtValue);

                //clear textbox and focus
                txtFC.Clear();
                txtFC.Focus();

                e.Handled = true;

            }
        }

        private void frmReceipt_Activated(object sender, EventArgs e)
        {
            dtPickerDisp.Value = DateTime.Today;
        }

        private void txtDispNo_TextChanged(object sender, EventArgs e)
        {
            //open db and search for dispNo
            if (txtDispNo.Text != "")
            {
                lstCans.Items.Clear();
                searchData(txtDispNo.Text);
            }
            
            
        }

        private void btnRemCan_Click(object sender, EventArgs e)
        {
            var selectedCan = lstCans.SelectedIndex;

            if (selectedCan >= 0)
            {
                lstCans.Items.RemoveAt(selectedCan);

                txtNoCans.Text = lstCans.Items.Count.ToString();
            }
        }

        private void btnRemFC_Click(object sender, EventArgs e)
        {
            var selectedFC = lstFCs.SelectedIndex;

            if (selectedFC >= 0)
            {
                lstFCs.Items.RemoveAt(selectedFC);


            }
        }

        public void searchData(string searchDispNo)
        {
            // Connection string and SQL query  
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\Data\AirToxics.mdb";
            string strSQL = "SELECT * FROM Dispatch";
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
                            
                            //Console.WriteLine("{0} - {1} - {2}", reader["Dispatch Number"].ToString(), reader["Canister ID"].ToString(), reader["Client"].ToString());

                            var dbDispNo = reader["Dispatch_Number"];

                            if (searchDispNo == dbDispNo.ToString())
                            {
                                //populate client, no cans sent,  populate cans sent
                                txtClient.Text = reader["Client"].ToString();
                                txtNoCans.Text = reader["No_of_cans"].ToString();
                                lstCans.Items.Add(reader["Canister_ID"]).ToString();

                                //check accs sent?
                            }


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

        private void btnRecSubmit_Click(object sender, EventArgs e)
        {
            var dateRec = dtPickerDisp.Value;
            var client = txtClient.Text;
            var dispNo = txtDispNo.Text;
            var reportNo = txtReportNo.Text;
            var noCans = txtNoCans.Text;
            var comments = txtComments.Text;
            var canId = "";
            var fcId = "";
            var accRec = "";

            foreach (var item in chkAccs.CheckedItems)
            {
                if (accRec == "")
                {
                    accRec += item;
                }
                else
                {
                    accRec += "," + item;
                }

            }

            if (accRec == "")
            {
                accRec = "N/A";
            }

            if (client == "" | dispNo == "" | reportNo == "" | lstCans.Items.Count < 1 | lstFCs.Items.Count < 1)
            {
                MessageBox.Show("Please ensure all fields have been populated. If some info is unavailable or not applicable please put 'N/A' in the relevant input.");
            }
            else
            {
                for (var i = 0; i < lstCans.Items.Count; i++)
                {
                    canId = lstCans.Items[i].ToString();

                    if (i < lstFCs.Items.Count)
                    {
                        fcId = lstFCs.Items[i].ToString();
                    }
                    else
                    {
                        fcId = "no FC";
                    }

                    addData(dateRec, client, dispNo, reportNo, noCans, canId, fcId, accRec, comments);

                }

                // show completed msg and clear fields
                MessageBox.Show("Receipt information for " + dispNo + " has been successfully added.");
                clearFields();
            }
        }

        public void addData(DateTime dateRec, string client, string dispNo, string reportNo, string noCans, string canId, string fcId, string accSent, string comments)
        {
            // Connection string and SQL query  
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\Data\AirToxics.mdb";
            string strSQL = "INSERT INTO Receipt(Dispatch_Number, Canister_ID, FlowController_ID, Date_Received, Report_Number, Client, Accessories_returned, Comments) VALUES ('" + dispNo + "','" + canId + "','" + fcId + "','"  + dateRec + "','" + reportNo + "','" + client + "','" + accSent + "','" + comments + "')";

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
                    command.ExecuteReader();


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    MessageBox.Show(ex.Message);
                }
                // The connection is automatically closed becasuse of using block.  
            }
        }


        public void clearFields()
        {
            txtDispNo.Clear();
            txtClient.Clear();
            txtReportNo.Clear();
            txtComments.Clear();

            txtNoCans.Text = "0";

            lstCans.Items.Clear();
            lstFCs.Items.Clear();

            while (chkAccs.CheckedIndices.Count > 0)
                chkAccs.SetItemChecked(chkAccs.CheckedIndices[0], false);
        }
    }
}
