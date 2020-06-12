using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1
{
    public partial class frmDispatch : Form
    {
        public frmDispatch()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    //get textbox value
            //    var txtValue = textBox5.Text;

            //    //add textbox value to listbox
            //    listBox1.Items.Add(txtValue);

            //    //clear textbox and focus
            //    textBox5.Clear();
            //    textBox5.Focus();

            //    e.Handled = true;
            //    e.SuppressKeyPress = true;
            //}
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

        private void btnRemCan_Click(object sender, EventArgs e)
        {
            var selectedCan = lstCans.SelectedIndex;

            if (selectedCan >= 0) {
                lstCans.Items.RemoveAt(selectedCan);

                txtNoCans.Text = lstCans.Items.Count.ToString();
            }
            
        }

        private void frmDispatch_Activated(object sender, EventArgs e)
        {
            txtNoCans.Text = "0";
            dtPickerDisp.Value = DateTime.Today;
        }

        private void txtFC_TextChanged(object sender, EventArgs e)
        {

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

        private void btnRemFC_Click(object sender, EventArgs e)
        {
            var selectedFC = lstFCs.SelectedIndex;

            if (selectedFC >= 0)
            {
                lstFCs.Items.RemoveAt(selectedFC);

                
            }
        }

        private void btnDispSubmit_Click(object sender, EventArgs e)
        {
            var dateSent = dtPickerDisp.Value;
            var client = txtClient.Text;
            var dispNo = txtDispNo.Text;
            var certNo = txtCertNo.Text;
            var noCans = txtNoCans.Text;
            var canId = "";
            var fcId = "";
            var accSent = "";

            foreach (var item in chkAccs.CheckedItems)
            {
                if (accSent == "")
                {
                    accSent += item;
                } else
                {
                    accSent += "," + item;
                }
                
            }

            if (accSent == "")
            {
                accSent = "N/A";
            }

            if (client == "" | dispNo == "" | certNo == "" | lstCans.Items.Count < 1 | lstFCs.Items.Count < 1)
            {
                MessageBox.Show("Please ensure all fields have been populated. If some info is unavailable or not applicable please put 'N/A' in the relevant input."); 
            } else
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

                    addData(dateSent, client, dispNo, certNo, noCans, canId, fcId, accSent);

                }

                // show completed msg and ask to populate order form

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show("Dispatch information for " + dispNo + " has been successfully added. Do you wish to populate the order form for this order?", "Done", buttons);
                if (result == DialogResult.Yes)
                {
                    btnOrderForm_Click(sender, e);
                    //open order form and populate with data

                }
                else
                {
                    // Do nothing 
                }

                //MessageBox.Show("Dispatch information for " + dispNo + " has been successfully added.");
                //clearFields();
            }

            
        }

        public void addData(DateTime dateSent, string client, string dispNo, string certNo, string noCans, string canId, string fcId, string accSent)
        {
            // Connection string and SQL query  
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=..\..\Data\AirToxics.mdb";
            string strSQL = "INSERT INTO Dispatch(Dispatch_Number, Canister_ID, FlowController_ID, Certification_Number, Date_Sent, Client, No_of_cans, Accessories_sent) VALUES ('" + dispNo + "','" + canId + "','" + fcId + "','" + certNo + "','" + dateSent + "','" + client + "','" + noCans + "','" + accSent + "')";
            
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
            txtCertNo.Clear();

            txtNoCans.Text = "0";

            lstCans.Items.Clear();
            lstFCs.Items.Clear();

            while (chkAccs.CheckedIndices.Count > 0)
                chkAccs.SetItemChecked(chkAccs.CheckedIndices[0], false);
        }


        public void populateOrderForm(string dispSearch, string[] cans, string[] fcs, string certNo)
        {
            //open order register filepath: M:\Production\Client Container orders\Brisbane - AirToxics\QS3100_R0_Client Order Tracker_2020_Summa Canisters.xlsx

            //test locally first
            //D:\Documents\Projects\test2\testfiles\testtracker.xlsx

            //Create an excel application object

             Excel.Application excelAppObj = new Excel.Application();
            excelAppObj.DisplayAlerts = false;


            //Open the excel work book
            //Excel.Workbook workBook = excelAppObj.Workbooks.Open(@"D:\Documents\Projects\test2\testfiles\testtracker.xlsx"); //test
            Excel.Workbook workBook = excelAppObj.Workbooks.Open(@"M:\Production\Client Container orders\Brisbane - AirToxics\QS3100_R0_Client Order Tracker_2020_Summa Canisters.xlsx");
            string dispNo = "";
            string link = "";

            try
            {
                //Get the first sheet of the selected work book
                for (int i = 1; i < workBook.Sheets.Count+1; i++)
                {
                    Excel.Worksheet worksheet = (Excel.Worksheet)workBook.Worksheets.get_Item(i);



                    int lastRow = worksheet.Cells.SpecialCells(XlCellType.xlCellTypeLastCell, Type.Missing).Row;

                    //get dispno and link
                    for (int introw = 1; introw <= lastRow; introw++)
                    {
                        dispNo = worksheet.Cells[introw, 2].value;

                        //find relevant dispno
                        if (dispNo == dispSearch)
                        {
                            link = worksheet.Cells[introw, 3].value;
                            break;
                        }
                    }

                    //copy file path of orderform filepath : M:\Production\Client Container orders\Brisbane - AirToxics\ + filepath in order tracker
                    //string orderFormLink = @"D:\Documents\Projects\test2\testfiles\" + link;
                    string orderFormLink = @"M:\Production\Client Container orders\Brisbane - AirToxics\template\orderformTemplate.xlsx";


                    Console.WriteLine(dispNo + " - " + orderFormLink);
                }
                
            }
            catch (Exception)
            { 

                throw;
            }
            finally
            {
                workBook.Close();
            }
            

            //open orderform template
            //Create an excel application object
            Excel.Application excelAppObj2 = new Excel.Application();
            excelAppObj2.DisplayAlerts = false;

            //Open the excel work book
            Excel.Workbook wkbOrder = excelAppObj2.Workbooks.Open(@"M:\Production\Client Container orders\Brisbane - AirToxics\template\orderformTemplate.xlsx");

            try
            {
                //Get the first sheet of the selected work book
                Excel.Worksheet wsOrder = (Excel.Worksheet)wkbOrder.Worksheets.get_Item(1);

                //add cans, fcs, and cert no to form
                wsOrder.Cells[2, 2].value = certNo;
                wsOrder.Cells[2, 1].value = @"M:\Production\Client Container orders\Brisbane - AirToxics\" + link;

                for (int i = 0; i < cans.Length; i++)
                {
                    wsOrder.Cells[2 + i, 3].value = cans[i];
                }

                for (int i = 0; i < fcs.Length; i++)
                {
                    wsOrder.Cells[2 + i, 4].value = fcs[i];
                }


                //save
                string fileName;

                DateTime today = DateTime.Today;
                if (today != null)
                {
                    try
                    {
                        string strToday = today.ToString();
                        int pos = strToday.IndexOf(" ");
                        string strDate = strToday.Substring(0, pos);
                        strDate = strDate.Replace("/", "_");
                        string strTime = strToday.Substring(pos + 1, strToday.Length);
                        strTime = strTime.Replace(":", "");

                        fileName = @"M:\Production\Client Container orders\Brisbane - AirToxics\template\" + dispSearch + "_OrderFormData_" + strDate + "_" + strTime + ".xlsx";
                    }
                    catch (Exception)
                    {
                        Random random = new Random();
                        int ranNum = random.Next();

                        fileName = @"M:\Production\Client Container orders\Brisbane - AirToxics\template\" + dispSearch + "_OrderFormData_" + ranNum.ToString() + "_" + ".xlsx";
                    }
                    
                } else
                {
                    Random random = new Random();
                    int ranNum = random.Next();

                    fileName = @"M:\Production\Client Container orders\Brisbane - AirToxics\template\" + dispSearch + "_OrderFormData_" + ranNum.ToString() + "_" + ".xlsx";
                }
                

                
                //string fileName = @"D:\Documents\Projects\test2\testfiles\" + dispSearch + "_OrderFormData_" + strDate + ".xlsx";

                //Save work book (.xlsx format)
                wkbOrder.SaveAs(fileName, Excel.XlFileFormat.xlOpenXMLWorkbook);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                throw;
            }
            finally
            {
                wkbOrder.Close();
            }

            //open file explorer with template and file explorer with orderform
            OpenFolder(@"M:\Production\Client Container orders\Brisbane - AirToxics\template\");
            int posLastSlash = link.LastIndexOf(@"\",link.Length);
            string linkPath = link.Substring(0, posLastSlash+1);
            OpenFolder(@"M:\Production\Client Container orders\Brisbane - AirToxics\" + linkPath);

        }

        private void btnOrderForm_Click(object sender, EventArgs e)
        {
            string dispSearch = txtDispNo.Text;
            string certNo = txtCertNo.Text;
            int countCan = lstCans.Items.Count;
            int countFc = lstFCs.Items.Count;

            string test = lstCans.Items.ToString();

            string[] cans = new string[countCan];
            string[] fcs = new string[countFc];

            for (int i = 0; i < countCan; i++)
            {
                cans[i] = lstCans.Items[i].ToString();
            }

            for (int i = 0; i < countFc; i++)
            {
                fcs[i] = lstFCs.Items[i].ToString();
            }

            if (countCan == 0 | countFc == 0)
            {
                MessageBox.Show("Please enter can and FC IDs.", "Error");
            }
            else if (dispSearch == "")
            {
                MessageBox.Show("Please enter dispatch number", "Error");
            }
            else if (certNo == "")
            {
                MessageBox.Show("Please enter cert number", "Error");
            }
            else
            {
                //testExcel(dispSearch);
                populateOrderForm(dispSearch, cans, fcs, certNo);

                //show message
                MessageBox.Show("Orderform data saved", "Success");
            }
            
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void OpenFolder(string folderPath)
        {
            if (Directory.Exists(folderPath))
            {
                ProcessStartInfo startInfo = new ProcessStartInfo
                {
                    Arguments = folderPath,
                    FileName = "explorer.exe"
                };

                Process.Start(startInfo);
            }
            else
            {
                MessageBox.Show(string.Format("{0} Directory does not exist!", folderPath));
            }
        }
    }
}
