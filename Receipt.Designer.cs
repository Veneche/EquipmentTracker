namespace WindowsFormsApp1
{
    partial class frmReceipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.chkAccs = new System.Windows.Forms.CheckedListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnRemFC = new System.Windows.Forms.Button();
            this.btnRemCan = new System.Windows.Forms.Button();
            this.btnRecSubmit = new System.Windows.Forms.Button();
            this.lstFCs = new System.Windows.Forms.ListBox();
            this.txtFC = new System.Windows.Forms.TextBox();
            this.txtCan = new System.Windows.Forms.TextBox();
            this.lstCans = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dtPickerDisp = new System.Windows.Forms.DateTimePicker();
            this.txtNoCans = new System.Windows.Forms.TextBox();
            this.txtReportNo = new System.Windows.Forms.TextBox();
            this.txtDispNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtComments = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Receipt Info below";
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
            this.chkAccs.Location = new System.Drawing.Point(464, 89);
            this.chkAccs.Name = "chkAccs";
            this.chkAccs.Size = new System.Drawing.Size(144, 90);
            this.chkAccs.TabIndex = 42;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(461, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(128, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Accessories received";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnRemFC
            // 
            this.btnRemFC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemFC.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemFC.Location = new System.Drawing.Point(306, 292);
            this.btnRemFC.Name = "btnRemFC";
            this.btnRemFC.Size = new System.Drawing.Size(120, 23);
            this.btnRemFC.TabIndex = 40;
            this.btnRemFC.Text = "Remove FC";
            this.btnRemFC.UseVisualStyleBackColor = false;
            this.btnRemFC.Click += new System.EventHandler(this.btnRemFC_Click);
            // 
            // btnRemCan
            // 
            this.btnRemCan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnRemCan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRemCan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemCan.ForeColor = System.Drawing.Color.Black;
            this.btnRemCan.Location = new System.Drawing.Point(176, 292);
            this.btnRemCan.Name = "btnRemCan";
            this.btnRemCan.Size = new System.Drawing.Size(124, 23);
            this.btnRemCan.TabIndex = 39;
            this.btnRemCan.Text = "Remove can";
            this.btnRemCan.UseVisualStyleBackColor = false;
            this.btnRemCan.Click += new System.EventHandler(this.btnRemCan_Click);
            // 
            // btnRecSubmit
            // 
            this.btnRecSubmit.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRecSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecSubmit.ForeColor = System.Drawing.Color.White;
            this.btnRecSubmit.Location = new System.Drawing.Point(480, 328);
            this.btnRecSubmit.Name = "btnRecSubmit";
            this.btnRecSubmit.Size = new System.Drawing.Size(109, 45);
            this.btnRecSubmit.TabIndex = 38;
            this.btnRecSubmit.Text = "Submit";
            this.btnRecSubmit.UseVisualStyleBackColor = false;
            this.btnRecSubmit.Click += new System.EventHandler(this.btnRecSubmit_Click);
            // 
            // lstFCs
            // 
            this.lstFCs.FormattingEnabled = true;
            this.lstFCs.Location = new System.Drawing.Point(306, 123);
            this.lstFCs.Name = "lstFCs";
            this.lstFCs.Size = new System.Drawing.Size(120, 160);
            this.lstFCs.TabIndex = 37;
            // 
            // txtFC
            // 
            this.txtFC.Location = new System.Drawing.Point(306, 89);
            this.txtFC.Name = "txtFC";
            this.txtFC.Size = new System.Drawing.Size(120, 20);
            this.txtFC.TabIndex = 36;
            this.txtFC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFC_KeyPress);
            // 
            // txtCan
            // 
            this.txtCan.Location = new System.Drawing.Point(176, 89);
            this.txtCan.Name = "txtCan";
            this.txtCan.Size = new System.Drawing.Size(124, 20);
            this.txtCan.TabIndex = 35;
            this.txtCan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCan_KeyPress);
            // 
            // lstCans
            // 
            this.lstCans.FormattingEnabled = true;
            this.lstCans.Location = new System.Drawing.Point(176, 123);
            this.lstCans.Name = "lstCans";
            this.lstCans.Size = new System.Drawing.Size(124, 160);
            this.lstCans.TabIndex = 34;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(303, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(28, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "FCs";
            // 
            // dtPickerDisp
            // 
            this.dtPickerDisp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPickerDisp.Location = new System.Drawing.Point(22, 89);
            this.dtPickerDisp.Name = "dtPickerDisp";
            this.dtPickerDisp.Size = new System.Drawing.Size(100, 20);
            this.dtPickerDisp.TabIndex = 32;
            this.dtPickerDisp.Value = new System.DateTime(2020, 5, 27, 13, 8, 59, 0);
            // 
            // txtNoCans
            // 
            this.txtNoCans.Location = new System.Drawing.Point(22, 295);
            this.txtNoCans.Name = "txtNoCans";
            this.txtNoCans.ReadOnly = true;
            this.txtNoCans.Size = new System.Drawing.Size(100, 20);
            this.txtNoCans.TabIndex = 31;
            // 
            // txtReportNo
            // 
            this.txtReportNo.Location = new System.Drawing.Point(22, 240);
            this.txtReportNo.Name = "txtReportNo";
            this.txtReportNo.Size = new System.Drawing.Size(100, 20);
            this.txtReportNo.TabIndex = 30;
            // 
            // txtDispNo
            // 
            this.txtDispNo.Location = new System.Drawing.Point(22, 139);
            this.txtDispNo.Name = "txtDispNo";
            this.txtDispNo.Size = new System.Drawing.Size(100, 20);
            this.txtDispNo.TabIndex = 29;
            this.txtDispNo.TextChanged += new System.EventHandler(this.txtDispNo_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 173);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Client";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 276);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "No of cans sent";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Dispatch No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Report No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(173, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Cans";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Date";
            // 
            // txtClient
            // 
            this.txtClient.Location = new System.Drawing.Point(22, 189);
            this.txtClient.Name = "txtClient";
            this.txtClient.Size = new System.Drawing.Size(100, 20);
            this.txtClient.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 43;
            this.label10.Text = "Comments";
            // 
            // txtComments
            // 
            this.txtComments.Location = new System.Drawing.Point(464, 221);
            this.txtComments.Multiline = true;
            this.txtComments.Name = "txtComments";
            this.txtComments.Size = new System.Drawing.Size(144, 87);
            this.txtComments.TabIndex = 44;
            // 
            // frmReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(629, 388);
            this.Controls.Add(this.txtComments);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chkAccs);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnRemFC);
            this.Controls.Add(this.btnRemCan);
            this.Controls.Add(this.btnRecSubmit);
            this.Controls.Add(this.lstFCs);
            this.Controls.Add(this.txtFC);
            this.Controls.Add(this.txtCan);
            this.Controls.Add(this.lstCans);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dtPickerDisp);
            this.Controls.Add(this.txtNoCans);
            this.Controls.Add(this.txtReportNo);
            this.Controls.Add(this.txtDispNo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtClient);
            this.Controls.Add(this.label1);
            this.Name = "frmReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AirToxics - Equipment Tracker";
            this.Activated += new System.EventHandler(this.frmReceipt_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox chkAccs;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnRemFC;
        private System.Windows.Forms.Button btnRemCan;
        private System.Windows.Forms.Button btnRecSubmit;
        private System.Windows.Forms.ListBox lstFCs;
        private System.Windows.Forms.TextBox txtFC;
        private System.Windows.Forms.TextBox txtCan;
        private System.Windows.Forms.ListBox lstCans;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtPickerDisp;
        private System.Windows.Forms.TextBox txtNoCans;
        private System.Windows.Forms.TextBox txtReportNo;
        private System.Windows.Forms.TextBox txtDispNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtComments;
    }
}