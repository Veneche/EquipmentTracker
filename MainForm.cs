using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDispatch_Click(object sender, EventArgs e)
        {
            frmDispatch frmDispatch = new frmDispatch();
            frmDispatch.Show();

            
            
        }

        private void btnReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt frmReceipt = new frmReceipt();
            frmReceipt.Show();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }
    }
}
