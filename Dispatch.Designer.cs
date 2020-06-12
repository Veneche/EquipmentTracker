namespace WindowsFormsApp1
{
    partial class frmDispatch
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
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDispNo = new System.Windows.Forms.TextBox();
            this.txtCertNo = new System.Windows.Forms.TextBox();
            this.txtNoCans = new System.Windows.Forms.TextBox();
            this.dtPickerDisp = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.lstCans = new System.Windows.Forms.ListBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.lstFCs = new System.Windows.Forms.ListBox();
            this.btnDispSubmit = new System.Windows.Forms.Button();
            this.btnRemCan = new System.Windows.Forms.Button();
            this.btnRemFC = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.chkAccs = new System.Windows.Forms.CheckedListBox();
            this.btnOrderForm = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(26, 132);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Dispatch Info below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Cans";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cert No";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dispatch No";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 269);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "No of cans";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(23, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Client";
            // 
            // txtDispNo
            // 
            this.txtDispNo.Location = new System.Drawing.Point(26, 182);
            this.txtDispNo.Name = "txtDispNo";
            this.txtDispNo.Size = new System.Drawing.Size(100, 20);
            this.txtDispNo.TabIndex = 8;
            // 
            // txtCertNo
            // 
            this.txtCertNo.Location = new System.Drawing.Point(26, 233);
            this.txtCertNo.Name = "txtCertNo";
            this.txtCertNo.Size = new System.Drawing.Size(100, 20);
            this.txtCertNo.TabIndex = 9;
            // 
            // txtNoCans
            // 
            this.txtNoCans.Location = new System.Drawing.Point(26, 285);
            this.txtNoCans.Name = "txtNoCans";
            this.txtNoCans.ReadOnly = true;
            this.txtNoCans.Size = new System.Drawing.Size(100, 20);
            this.txtNoCans.TabIndex = 10;
            // 
            // dtPickerDisp
            // 
            this.dtPickerDisp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDisp.Location = new System.Drawing.Point(26, 82);
            this.dtPickerDisp.Name = "dtPickerDisp";
            this.dtPickerDisp.Size = new System.Drawing.Size(100, 20);
            this.dtPickerDisp.TabIndex = 11;
            this.dtPickerDisp.Value = new System.DateTime(2020, 5, 27, 13, 8, 59, 0);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(356, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "FCs";
            // 
            // lstCans
            // 
            this.lstCans.FormattingEnabled = true;
            this.lstCans.Location = new System.Drawing.Point(180, 116);
            this.lstCans.Name = "lstCans";
            this.lstCans.Size = new System.Drawing.Size(124, 160);
            this.lstCans.TabIndex = 13;
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(180, 82);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(124, 20);
            this.txtCan.TabIndex = 14;
            this.txtCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCan_KeyPress);
            this.txtCan.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox5_KeyDown);
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(359, 82);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(120, 20);
            this.txtFC.TabIndex = 15;
            this.txtFC.TextChanged += new System.EventHandler(this.txtFC_TextChanged);
            this.txtFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFC_KeyPress);
            // 
            // lstFCs
            // 
            this.lstFCs.FormattingEnabled = true;
            this.lstFCs.Location = new System.Drawing.Point(359, 116);
            this.lstFCs.Name = "lstFCs";
            this.lstFCs.Size = new System.Drawing.Size(120, 160);
            this.lstFCs.TabIndex = 16;
            // 
            // btnDispSubmit
            // 
            this.btnDispSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnDispSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispSubmit.ForeColor = System.Drawing.Color.White;
            this.btnDispSubmit.Location = new System.Drawing.Point(535, 205);
            this.btnDispSubmit.Name = "btnDispSubmit";
            this.btnDispSubmit.Size = new System.Drawing.Size(144, 36);
            this.btnDispSubmit.TabIndex = 17;
            this.btnDispSubmit.Text = "Submit";
            this.btnDispSubmit.UseVisualStyleBackColor = false;
            this.btnDispSubmit.Click += new System.EventHandler(this.btnDispSubmit_Click);
            // 
            // btnRemCan
            // 
            this.btnRemCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemCan.ForeColor = System.Drawing.Color.Black;
            this.btnRemCan.Location = new System.Drawing.Point(180, 285);
            this.btnRemCan.Name = "btnRemCan";
            this.btnRemCan.Size = new System.Drawing.Size(124, 23);
            this.btnRemCan.TabIndex = 18;
            this.btnRemCan.Text = "Remove can";
            this.btnRemCan.UseVisualStyleBackColor = false;
            this.btnRemCan.Click += new System.EventHandler(this.btnRemCan_Click);
            // 
            // btnRemFC
            // 
            this.btnRemFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemFC.Location = new System.Drawing.Point(359, 285);
            this.btnRemFC.Name = "btnRemFC";
            this.btnRemFC.Size = new System.Drawing.Size(120, 23);
            this.btnRemFC.TabIndex = 19;
            this.btnRemFC.Text = "Remove FC";
            this.btnRemFC.UseVisualStyleBackColor = false;
            this.btnRemFC.Click += new System.EventHandler(this.btnRemFC_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(532, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Accessories sent";
            // 
            // chkAccs
            // 
            this.chkAccs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chkAccs.CheckOnClick = true;
            this.chkAccs.FormattingEnabled = true;
            this.chkAccs.Items.AddRange(new object[] {
            "T-Piece(s)",
            "Pressure Gauge(s)",
            "Female Quick Connect(s)",
            "Male Quick Connect(s)",
            "ALS Adapter",
            "Other"});
            this.chkAccs.Location = new System.Drawing.Point(535, 85);
            this.chkAccs.Name = "chkAccs";
            this.chkAccs.Size = new System.Drawing.Size(144, 90);
            this.chkAccs.TabIndex = 21;
            // 
            // btnOrderForm
            // 
            this.btnOrderForm.BackColor = System.Drawing.Color.Navy;
            this.btnOrderForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrderForm.ForeColor = System.Drawing.Color.White;
            this.btnOrderForm.Location = new System.Drawing.Point(535, 285);
            this.btnOrderForm.Name = "btnOrderForm";
            this.btnOrderForm.Size = new System.Drawing.Size(144, 23);
            this.btnOrderForm.TabIndex = 22;
            this.btnOrderForm.Text = "Copy to Order Form";
            this.btnOrderForm.UseVisualStyleBackColor = false;
            this.btnOrderForm.Click += new System.EventHandler(this.btnOrderForm_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(535, 255);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(144, 21);
            this.btnClear.TabIndex = 23;
            this.btnClear.Text = "Clear Fields";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmDispatch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(691, 330);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnOrderForm);
            this.Controls.Add(this.chkAccs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemFC);
            this.Controls.Add(this.btnRemCan);
            this.Controls.Add(this.btnDispSubmit);
            this.Controls.Add(this.lstFCs);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.lstCans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtPickerDisp);
            this.Controls.Add(this.txtNoCans);
            this.Controls.Add(this.txtCertNo);
            this.Controls.Add(this.txtDispNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtClient);
            this.Name = "frmDispatch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirToxics - Equipment Tracker";
            this.Activated += new System.EventHandler(this.frmDispatch_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDispNo;
        private System.Windows.Forms.TextBox txtCertNo;
        private System.Windows.Forms.TextBox txtNoCans;
        private System.Windows.Forms.DateTimePicker dtPickerDisp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lstCans;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.ListBox lstFCs;
        private System.Windows.Forms.Button btnDispSubmit;
        private System.Windows.Forms.Button btnRemCan;
        private System.Windows.Forms.Button btnRemFC;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckedListBox chkAccs;
        private System.Windows.Forms.Button btnOrderForm;
        private System.Windows.Forms.Button btnClear;
    }
}