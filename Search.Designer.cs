namespace WindowsFormsApp1
{
    partial class frmSearch
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstSearch = new System.Windows.Forms.ListView();
            this.btnDispatchSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReceiptSearch = new System.Windows.Forms.Button();
            this.txtDispSearch = new System.Windows.Forms.TextBox();
            this.cmbDisp = new System.Windows.Forms.ComboBox();
            this.cmbReceipt = new System.Windows.Forms.ComboBox();
            this.txtRecSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRec = new System.Windows.Forms.Label();
            this.lblDisp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSearch
            // 
            this.lstSearch.HideSelection = false;
            this.lstSearch.Location = new System.Drawing.Point(26, 174);
            this.lstSearch.Name = "lstSearch";
            this.lstSearch.Size = new System.Drawing.Size(1067, 364);
            this.lstSearch.TabIndex = 0;
            this.lstSearch.UseCompatibleStateImageBehavior = false;
            this.lstSearch.View = System.Windows.Forms.View.Details;
            // 
            // btnDispatchSearch
            // 
            this.btnDispatchSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnDispatchSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispatchSearch.Location = new System.Drawing.Point(349, 134);
            this.btnDispatchSearch.Name = "btnDispatchSearch";
            this.btnDispatchSearch.Size = new System.Drawing.Size(179, 25);
            this.btnDispatchSearch.TabIndex = 1;
            this.btnDispatchSearch.Text = "Search Dispatch";
            this.btnDispatchSearch.UseVisualStyleBackColor = false;
            this.btnDispatchSearch.Click += new System.EventHandler(this.btnDispatchSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Search Dispatch or Receipt Info";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnReceiptSearch
            // 
            this.btnReceiptSearch.BackColor = System.Drawing.Color.Gainsboro;
            this.btnReceiptSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceiptSearch.Location = new System.Drawing.Point(565, 134);
            this.btnReceiptSearch.Name = "btnReceiptSearch";
            this.btnReceiptSearch.Size = new System.Drawing.Size(182, 25);
            this.btnReceiptSearch.TabIndex = 5;
            this.btnReceiptSearch.Text = "Search Receipt";
            this.btnReceiptSearch.UseVisualStyleBackColor = false;
            this.btnReceiptSearch.Click += new System.EventHandler(this.btnReceiptSearch_Click);
            // 
            // txtDispSearch
            // 
            this.txtDispSearch.Location = new System.Drawing.Point(349, 108);
            this.txtDispSearch.Name = "txtDispSearch";
            this.txtDispSearch.Size = new System.Drawing.Size(179, 20);
            this.txtDispSearch.TabIndex = 7;
            this.txtDispSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDispSearch_KeyPress);
            // 
            // cmbDisp
            // 
            this.cmbDisp.FormattingEnabled = true;
            this.cmbDisp.Items.AddRange(new object[] {
            "Can ID",
            "FC ID",
            "Date Sent",
            "Client",
            "Dispatch Number",
            "Cert Number"});
            this.cmbDisp.Location = new System.Drawing.Point(349, 59);
            this.cmbDisp.Name = "cmbDisp";
            this.cmbDisp.Size = new System.Drawing.Size(179, 21);
            this.cmbDisp.TabIndex = 8;
            this.cmbDisp.SelectedIndexChanged += new System.EventHandler(this.cmbDisp_SelectedIndexChanged);
            // 
            // cmbReceipt
            // 
            this.cmbReceipt.FormattingEnabled = true;
            this.cmbReceipt.Items.AddRange(new object[] {
            "Can ID",
            "FC ID",
            "Date Received",
            "Client",
            "Dispatch Number",
            "Report Number"});
            this.cmbReceipt.Location = new System.Drawing.Point(565, 59);
            this.cmbReceipt.Name = "cmbReceipt";
            this.cmbReceipt.Size = new System.Drawing.Size(182, 21);
            this.cmbReceipt.TabIndex = 9;
            this.cmbReceipt.SelectedIndexChanged += new System.EventHandler(this.cmbReceipt_SelectedIndexChanged);
            // 
            // txtRecSearch
            // 
            this.txtRecSearch.Location = new System.Drawing.Point(565, 108);
            this.txtRecSearch.Name = "txtRecSearch";
            this.txtRecSearch.Size = new System.Drawing.Size(182, 20);
            this.txtRecSearch.TabIndex = 10;
            this.txtRecSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRecSearch_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Dispatch";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(615, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 12;
            this.label3.Text = "Receipt";
            // 
            // lblRec
            // 
            this.lblRec.AutoSize = true;
            this.lblRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRec.Location = new System.Drawing.Point(562, 92);
            this.lblRec.Name = "lblRec";
            this.lblRec.Size = new System.Drawing.Size(0, 13);
            this.lblRec.TabIndex = 13;
            // 
            // lblDisp
            // 
            this.lblDisp.AutoSize = true;
            this.lblDisp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisp.Location = new System.Drawing.Point(346, 92);
            this.lblDisp.Name = "lblDisp";
            this.lblDisp.Size = new System.Drawing.Size(0, 13);
            this.lblDisp.TabIndex = 14;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1125, 559);
            this.Controls.Add(this.lblDisp);
            this.Controls.Add(this.lblRec);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRecSearch);
            this.Controls.Add(this.cmbReceipt);
            this.Controls.Add(this.cmbDisp);
            this.Controls.Add(this.txtDispSearch);
            this.Controls.Add(this.btnReceiptSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDispatchSearch);
            this.Controls.Add(this.lstSearch);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirToxics - Equipment Tracker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstSearch;
        private System.Windows.Forms.Button btnDispatchSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReceiptSearch;
        private System.Windows.Forms.TextBox txtDispSearch;
        private System.Windows.Forms.ComboBox cmbDisp;
        private System.Windows.Forms.ComboBox cmbReceipt;
        private System.Windows.Forms.TextBox txtRecSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRec;
        private System.Windows.Forms.Label lblDisp;
    }
}

