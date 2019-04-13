namespace CustomerData
{
    partial class Form1
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbxSelection = new System.Windows.Forms.GroupBox();
            this.radRes = new System.Windows.Forms.RadioButton();
            this.radCom = new System.Windows.Forms.RadioButton();
            this.radInd = new System.Windows.Forms.RadioButton();
            this.pnlInd = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.unit = new System.Windows.Forms.Label();
            this.txtNoPeak = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPeak = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblBill = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtKwh = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblResidential = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblTotalCustomer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblResTotal = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblComTotal = new System.Windows.Forms.Label();
            this.lblIndTotal = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.Statistics = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lstCust = new System.Windows.Forms.ListView();
            this.chAcct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.gbxSelection.SuspendLayout();
            this.pnlInd.SuspendLayout();
            this.Statistics.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:  ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(21, 131);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 22);
            this.txtName.TabIndex = 1;
            this.txtName.Tag = "Customer Name";
            // 
            // txtAccount
            // 
            this.txtAccount.Location = new System.Drawing.Point(21, 64);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(177, 22);
            this.txtAccount.TabIndex = 3;
            this.txtAccount.Tag = "Customer Account Number";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Account No.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbxSelection);
            this.groupBox1.Controls.Add(this.pnlInd);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.lblBill);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtKwh);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtAccount);
            this.groupBox1.Controls.Add(this.lblResidential);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 29);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 634);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Information";
            // 
            // gbxSelection
            // 
            this.gbxSelection.BackColor = System.Drawing.Color.Transparent;
            this.gbxSelection.Controls.Add(this.radRes);
            this.gbxSelection.Controls.Add(this.radCom);
            this.gbxSelection.Controls.Add(this.radInd);
            this.gbxSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxSelection.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gbxSelection.Location = new System.Drawing.Point(16, 208);
            this.gbxSelection.Name = "gbxSelection";
            this.gbxSelection.Size = new System.Drawing.Size(337, 43);
            this.gbxSelection.TabIndex = 36;
            this.gbxSelection.TabStop = false;
            this.gbxSelection.Text = "Select your type";
            // 
            // radRes
            // 
            this.radRes.AutoSize = true;
            this.radRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radRes.ForeColor = System.Drawing.Color.Black;
            this.radRes.Location = new System.Drawing.Point(6, 13);
            this.radRes.Name = "radRes";
            this.radRes.Size = new System.Drawing.Size(98, 22);
            this.radRes.TabIndex = 9;
            this.radRes.TabStop = true;
            this.radRes.Text = "Residential";
            this.radRes.UseVisualStyleBackColor = true;
            this.radRes.CheckedChanged += new System.EventHandler(this.radRes_CheckedChanged_1);
            // 
            // radCom
            // 
            this.radCom.AutoSize = true;
            this.radCom.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radCom.ForeColor = System.Drawing.Color.Black;
            this.radCom.Location = new System.Drawing.Point(118, 13);
            this.radCom.Name = "radCom";
            this.radCom.Size = new System.Drawing.Size(107, 22);
            this.radCom.TabIndex = 10;
            this.radCom.TabStop = true;
            this.radCom.Text = "Commercial";
            this.radCom.UseVisualStyleBackColor = true;
            this.radCom.CheckedChanged += new System.EventHandler(this.radCom_CheckedChanged_1);
            // 
            // radInd
            // 
            this.radInd.AutoSize = true;
            this.radInd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radInd.ForeColor = System.Drawing.Color.Black;
            this.radInd.Location = new System.Drawing.Point(247, 13);
            this.radInd.Name = "radInd";
            this.radInd.Size = new System.Drawing.Size(84, 22);
            this.radInd.TabIndex = 11;
            this.radInd.TabStop = true;
            this.radInd.Text = "Industrial";
            this.radInd.UseVisualStyleBackColor = true;
            this.radInd.CheckedChanged += new System.EventHandler(this.radInd_CheckedChanged_1);
            // 
            // pnlInd
            // 
            this.pnlInd.BackColor = System.Drawing.Color.Transparent;
            this.pnlInd.Controls.Add(this.label6);
            this.pnlInd.Controls.Add(this.label5);
            this.pnlInd.Controls.Add(this.label9);
            this.pnlInd.Controls.Add(this.unit);
            this.pnlInd.Controls.Add(this.txtNoPeak);
            this.pnlInd.Controls.Add(this.label11);
            this.pnlInd.Controls.Add(this.label12);
            this.pnlInd.Controls.Add(this.txtPeak);
            this.pnlInd.Location = new System.Drawing.Point(10, 282);
            this.pnlInd.Name = "pnlInd";
            this.pnlInd.Size = new System.Drawing.Size(235, 159);
            this.pnlInd.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(161, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 23);
            this.label6.TabIndex = 47;
            this.label6.Text = "kWh";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(161, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 23);
            this.label5.TabIndex = 46;
            this.label5.Text = "kWh";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(401, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "kWh";
            // 
            // unit
            // 
            this.unit.AutoSize = true;
            this.unit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unit.ForeColor = System.Drawing.Color.Black;
            this.unit.Location = new System.Drawing.Point(399, 19);
            this.unit.Name = "unit";
            this.unit.Size = new System.Drawing.Size(41, 20);
            this.unit.TabIndex = 25;
            this.unit.Text = "kWh";
            // 
            // txtNoPeak
            // 
            this.txtNoPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNoPeak.Location = new System.Drawing.Point(10, 127);
            this.txtNoPeak.Name = "txtNoPeak";
            this.txtNoPeak.Size = new System.Drawing.Size(145, 26);
            this.txtNoPeak.TabIndex = 24;
            this.txtNoPeak.Tag = "Electricity Usage :  None Peak Hours";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(95, 18);
            this.label11.TabIndex = 14;
            this.label11.Text = "Peak Hours: ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(5, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 18);
            this.label12.TabIndex = 22;
            this.label12.Text = "No Peak Hours: ";
            // 
            // txtPeak
            // 
            this.txtPeak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeak.Location = new System.Drawing.Point(10, 42);
            this.txtPeak.Name = "txtPeak";
            this.txtPeak.Size = new System.Drawing.Size(145, 26);
            this.txtPeak.TabIndex = 18;
            this.txtPeak.Tag = "Electricity Usage:  Peak Hours";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(143, 599);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 29);
            this.btnClear.TabIndex = 42;
            this.btnClear.Text = "C&lear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click_1);
            // 
            // lblBill
            // 
            this.lblBill.BackColor = System.Drawing.Color.Transparent;
            this.lblBill.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBill.ForeColor = System.Drawing.Color.Black;
            this.lblBill.Location = new System.Drawing.Point(10, 507);
            this.lblBill.Name = "lblBill";
            this.lblBill.Size = new System.Drawing.Size(235, 29);
            this.lblBill.TabIndex = 38;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(10, 599);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(108, 29);
            this.btnCalculate.TabIndex = 39;
            this.btnCalculate.Text = "&Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtKwh
            // 
            this.txtKwh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKwh.Location = new System.Drawing.Point(16, 303);
            this.txtKwh.Name = "txtKwh";
            this.txtKwh.Size = new System.Drawing.Size(145, 26);
            this.txtKwh.TabIndex = 40;
            this.txtKwh.Tag = "Electricity Usage";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 474);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(147, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Charge Amount: ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(167, 307);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 18);
            this.label15.TabIndex = 37;
            this.label15.Text = "kWh";
            // 
            // lblResidential
            // 
            this.lblResidential.AutoSize = true;
            this.lblResidential.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResidential.ForeColor = System.Drawing.Color.Black;
            this.lblResidential.Location = new System.Drawing.Point(19, 261);
            this.lblResidential.Name = "lblResidential";
            this.lblResidential.Size = new System.Drawing.Size(59, 18);
            this.lblResidential.TabIndex = 36;
            this.lblResidential.Text = "Usage: ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 23);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type: ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnAdd
            // 
            this.btnAdd.AutoSize = true;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(303, 669);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblTotalCustomer
            // 
            this.lblTotalCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalCustomer.Location = new System.Drawing.Point(43, 73);
            this.lblTotalCustomer.Name = "lblTotalCustomer";
            this.lblTotalCustomer.Size = new System.Drawing.Size(177, 25);
            this.lblTotalCustomer.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(40, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(255, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "Total Number of Customers";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblResTotal
            // 
            this.lblResTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblResTotal.Location = new System.Drawing.Point(23, 74);
            this.lblResTotal.Name = "lblResTotal";
            this.lblResTotal.Size = new System.Drawing.Size(125, 28);
            this.lblResTotal.TabIndex = 21;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotalAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmount.Location = new System.Drawing.Point(43, 507);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(177, 25);
            this.lblTotalAmount.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(20, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(92, 23);
            this.label14.TabIndex = 29;
            this.label14.Text = "Residential";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label16
            // 
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(20, 117);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 23);
            this.label16.TabIndex = 30;
            this.label16.Text = "Commercial";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(20, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 23);
            this.label18.TabIndex = 31;
            this.label18.Text = "Industrial";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblComTotal
            // 
            this.lblComTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblComTotal.Location = new System.Drawing.Point(23, 146);
            this.lblComTotal.Name = "lblComTotal";
            this.lblComTotal.Size = new System.Drawing.Size(125, 28);
            this.lblComTotal.TabIndex = 32;
            // 
            // lblIndTotal
            // 
            this.lblIndTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIndTotal.Location = new System.Drawing.Point(23, 225);
            this.lblIndTotal.Name = "lblIndTotal";
            this.lblIndTotal.Size = new System.Drawing.Size(125, 28);
            this.lblIndTotal.TabIndex = 33;
            // 
            // label17
            // 
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(40, 463);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(255, 23);
            this.label17.TabIndex = 34;
            this.label17.Text = "Total Sum of Charge Amount";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Statistics
            // 
            this.Statistics.Controls.Add(this.groupBox2);
            this.Statistics.Controls.Add(this.label10);
            this.Statistics.Controls.Add(this.lblTotalCustomer);
            this.Statistics.Controls.Add(this.label17);
            this.Statistics.Controls.Add(this.lblTotalAmount);
            this.Statistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Statistics.Location = new System.Drawing.Point(902, 29);
            this.Statistics.Name = "Statistics";
            this.Statistics.Size = new System.Drawing.Size(323, 634);
            this.Statistics.TabIndex = 35;
            this.Statistics.TabStop = false;
            this.Statistics.Text = "Statistics";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.lblResTotal);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.lblIndTotal);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblComTotal);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(43, 139);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(208, 311);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sum of Each Type";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWarning.ForeColor = System.Drawing.Color.LightPink;
            this.lblWarning.Location = new System.Drawing.Point(694, 589);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 25);
            this.lblWarning.TabIndex = 46;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1137, 669);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(88, 29);
            this.btnExit.TabIndex = 43;
            this.btnExit.Text = "&Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // lstCust
            // 
            this.lstCust.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chAcct,
            this.chName,
            this.chType,
            this.chAmount});
            this.lstCust.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCust.FullRowSelect = true;
            this.lstCust.GridLines = true;
            this.lstCust.Location = new System.Drawing.Point(409, 29);
            this.lstCust.Name = "lstCust";
            this.lstCust.Size = new System.Drawing.Size(467, 634);
            this.lstCust.TabIndex = 47;
            this.lstCust.UseCompatibleStateImageBehavior = false;
            this.lstCust.View = System.Windows.Forms.View.Details;
            // 
            // chAcct
            // 
            this.chAcct.Text = "Account No.";
            this.chAcct.Width = 100;
            // 
            // chName
            // 
            this.chName.Text = "Name";
            this.chName.Width = 150;
            // 
            // chType
            // 
            this.chType.Text = "Type";
            // 
            // chAmount
            // 
            this.chAmount.Text = "Bill Amount";
            this.chAmount.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1255, 708);
            this.Controls.Add(this.lstCust);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.Statistics);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbxSelection.ResumeLayout(false);
            this.gbxSelection.PerformLayout();
            this.pnlInd.ResumeLayout(false);
            this.pnlInd.PerformLayout();
            this.Statistics.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalCustomer;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblResTotal;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblComTotal;
        private System.Windows.Forms.Label lblIndTotal;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox Statistics;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox gbxSelection;
        private System.Windows.Forms.RadioButton radRes;
        private System.Windows.Forms.RadioButton radCom;
        private System.Windows.Forms.RadioButton radInd;
        private System.Windows.Forms.Panel pnlInd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label unit;
        private System.Windows.Forms.TextBox txtNoPeak;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPeak;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblBill;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtKwh;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblResidential;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListView lstCust;
        private System.Windows.Forms.ColumnHeader chAcct;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chType;
        private System.Windows.Forms.ColumnHeader chAmount;
    }
}

