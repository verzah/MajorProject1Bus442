
namespace GavinMajorProject1
{
    partial class VehicleLoanCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VehicleLoanCalculator));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTop = new System.Windows.Forms.Label();
            this.lblBottom = new System.Windows.Forms.Label();
            this.lblLoanAmount = new System.Windows.Forms.Label();
            this.lblAPR = new System.Windows.Forms.Label();
            this.radioButton6 = new System.Windows.Forms.RadioButton();
            this.groupBoxMonths = new System.Windows.Forms.GroupBox();
            this.radioButton24 = new System.Windows.Forms.RadioButton();
            this.radioButton12 = new System.Windows.Forms.RadioButton();
            this.radioButton18 = new System.Windows.Forms.RadioButton();
            this.txtLoanAmount = new System.Windows.Forms.TextBox();
            this.comboBoxAPR = new System.Windows.Forms.ComboBox();
            this.checkBoxRebate = new System.Windows.Forms.CheckBox();
            this.txtRebate = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalLoans = new System.Windows.Forms.Label();
            this.lblTotalInterest = new System.Windows.Forms.Label();
            this.lstAllLoans = new System.Windows.Forms.ListBox();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblInterest = new System.Windows.Forms.Label();
            this.lblPrincipal = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblTotalInterestOutput = new System.Windows.Forms.Label();
            this.lblTotalLoansOutput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBoxMonths.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(666, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTop
            // 
            this.lblTop.AutoSize = true;
            this.lblTop.BackColor = System.Drawing.Color.Firebrick;
            this.lblTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTop.Location = new System.Drawing.Point(290, 12);
            this.lblTop.Name = "lblTop";
            this.lblTop.Size = new System.Drawing.Size(227, 16);
            this.lblTop.TabIndex = 1;
            this.lblTop.Text = "Academic and Industry Collaboration";
            // 
            // lblBottom
            // 
            this.lblBottom.AutoSize = true;
            this.lblBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBottom.Location = new System.Drawing.Point(298, 28);
            this.lblBottom.Name = "lblBottom";
            this.lblBottom.Size = new System.Drawing.Size(209, 24);
            this.lblBottom.TabIndex = 2;
            this.lblBottom.Text = "Vehicle Loan Calculator";
            // 
            // lblLoanAmount
            // 
            this.lblLoanAmount.AutoSize = true;
            this.lblLoanAmount.Location = new System.Drawing.Point(36, 97);
            this.lblLoanAmount.Name = "lblLoanAmount";
            this.lblLoanAmount.Size = new System.Drawing.Size(73, 13);
            this.lblLoanAmount.TabIndex = 3;
            this.lblLoanAmount.Text = "Loan Amount:";
            // 
            // lblAPR
            // 
            this.lblAPR.AutoSize = true;
            this.lblAPR.Location = new System.Drawing.Point(24, 124);
            this.lblAPR.Name = "lblAPR";
            this.lblAPR.Size = new System.Drawing.Size(85, 13);
            this.lblAPR.TabIndex = 4;
            this.lblAPR.Text = "Annual APR (%):";
            // 
            // radioButton6
            // 
            this.radioButton6.AutoSize = true;
            this.radioButton6.Location = new System.Drawing.Point(21, 19);
            this.radioButton6.Name = "radioButton6";
            this.radioButton6.Size = new System.Drawing.Size(31, 17);
            this.radioButton6.TabIndex = 5;
            this.radioButton6.TabStop = true;
            this.radioButton6.Text = "6";
            this.radioButton6.UseVisualStyleBackColor = true;
            // 
            // groupBoxMonths
            // 
            this.groupBoxMonths.Controls.Add(this.radioButton24);
            this.groupBoxMonths.Controls.Add(this.radioButton12);
            this.groupBoxMonths.Controls.Add(this.radioButton18);
            this.groupBoxMonths.Controls.Add(this.radioButton6);
            this.groupBoxMonths.Location = new System.Drawing.Point(293, 97);
            this.groupBoxMonths.Name = "groupBoxMonths";
            this.groupBoxMonths.Size = new System.Drawing.Size(141, 81);
            this.groupBoxMonths.TabIndex = 6;
            this.groupBoxMonths.TabStop = false;
            this.groupBoxMonths.Text = "Loan Months:";
            // 
            // radioButton24
            // 
            this.radioButton24.AutoSize = true;
            this.radioButton24.Location = new System.Drawing.Point(85, 42);
            this.radioButton24.Name = "radioButton24";
            this.radioButton24.Size = new System.Drawing.Size(37, 17);
            this.radioButton24.TabIndex = 7;
            this.radioButton24.TabStop = true;
            this.radioButton24.Text = "24";
            this.radioButton24.UseVisualStyleBackColor = true;
            // 
            // radioButton12
            // 
            this.radioButton12.AutoSize = true;
            this.radioButton12.Location = new System.Drawing.Point(21, 42);
            this.radioButton12.Name = "radioButton12";
            this.radioButton12.Size = new System.Drawing.Size(37, 17);
            this.radioButton12.TabIndex = 7;
            this.radioButton12.TabStop = true;
            this.radioButton12.Text = "12";
            this.radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton18
            // 
            this.radioButton18.AutoSize = true;
            this.radioButton18.Location = new System.Drawing.Point(85, 19);
            this.radioButton18.Name = "radioButton18";
            this.radioButton18.Size = new System.Drawing.Size(37, 17);
            this.radioButton18.TabIndex = 7;
            this.radioButton18.TabStop = true;
            this.radioButton18.Text = "18";
            this.radioButton18.UseVisualStyleBackColor = true;
            // 
            // txtLoanAmount
            // 
            this.txtLoanAmount.Location = new System.Drawing.Point(116, 97);
            this.txtLoanAmount.Name = "txtLoanAmount";
            this.txtLoanAmount.Size = new System.Drawing.Size(100, 20);
            this.txtLoanAmount.TabIndex = 7;
            // 
            // comboBoxAPR
            // 
            this.comboBoxAPR.FormattingEnabled = true;
            this.comboBoxAPR.Items.AddRange(new object[] {
            "2.5",
            "5.0",
            "7.8",
            "12.0"});
            this.comboBoxAPR.Location = new System.Drawing.Point(116, 124);
            this.comboBoxAPR.Name = "comboBoxAPR";
            this.comboBoxAPR.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAPR.TabIndex = 8;
            this.comboBoxAPR.Text = "2.5";
            // 
            // checkBoxRebate
            // 
            this.checkBoxRebate.AutoSize = true;
            this.checkBoxRebate.Location = new System.Drawing.Point(27, 160);
            this.checkBoxRebate.Name = "checkBoxRebate";
            this.checkBoxRebate.Size = new System.Drawing.Size(67, 17);
            this.checkBoxRebate.TabIndex = 9;
            this.checkBoxRebate.Text = "Rebate?";
            this.checkBoxRebate.UseVisualStyleBackColor = true;
            this.checkBoxRebate.CheckedChanged += new System.EventHandler(this.checkBoxRebate_CheckedChanged);
            // 
            // txtRebate
            // 
            this.txtRebate.Enabled = false;
            this.txtRebate.Location = new System.Drawing.Point(116, 160);
            this.txtRebate.Name = "txtRebate";
            this.txtRebate.Size = new System.Drawing.Size(100, 20);
            this.txtRebate.TabIndex = 10;
            this.txtRebate.TextChanged += new System.EventHandler(this.txtRebate_TextChanged);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(666, 231);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 33);
            this.btnCalculate.TabIndex = 11;
            this.btnCalculate.Text = "Calculate Loan";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(666, 271);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(100, 34);
            this.btnAccept.TabIndex = 12;
            this.btnAccept.Text = "Accept Loan";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(666, 312);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(100, 38);
            this.btnDisplay.TabIndex = 13;
            this.btnDisplay.Text = "Display All Loans";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(666, 357);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 56);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.lblTotalLoansOutput);
            this.groupBox1.Controls.Add(this.lblTotalInterestOutput);
            this.groupBox1.Controls.Add(this.lblTotalLoans);
            this.groupBox1.Controls.Add(this.lblTotalInterest);
            this.groupBox1.Location = new System.Drawing.Point(644, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(122, 121);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalLoans
            // 
            this.lblTotalLoans.AutoSize = true;
            this.lblTotalLoans.Location = new System.Drawing.Point(6, 55);
            this.lblTotalLoans.Name = "lblTotalLoans";
            this.lblTotalLoans.Size = new System.Drawing.Size(66, 13);
            this.lblTotalLoans.TabIndex = 2;
            this.lblTotalLoans.Text = "Total Loans:";
            // 
            // lblTotalInterest
            // 
            this.lblTotalInterest.AutoSize = true;
            this.lblTotalInterest.Location = new System.Drawing.Point(6, 16);
            this.lblTotalInterest.Name = "lblTotalInterest";
            this.lblTotalInterest.Size = new System.Drawing.Size(72, 13);
            this.lblTotalInterest.TabIndex = 0;
            this.lblTotalInterest.Text = "Total Interest:";
            // 
            // lstAllLoans
            // 
            this.lstAllLoans.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAllLoans.FormattingEnabled = true;
            this.lstAllLoans.ItemHeight = 14;
            this.lstAllLoans.Location = new System.Drawing.Point(27, 221);
            this.lstAllLoans.Name = "lstAllLoans";
            this.lstAllLoans.Size = new System.Drawing.Size(601, 396);
            this.lstAllLoans.TabIndex = 16;
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonth.Location = new System.Drawing.Point(27, 202);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(44, 16);
            this.lblMonth.TabIndex = 17;
            this.lblMonth.Text = "Month";
            // 
            // lblInterest
            // 
            this.lblInterest.AutoSize = true;
            this.lblInterest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInterest.Location = new System.Drawing.Point(99, 202);
            this.lblInterest.Name = "lblInterest";
            this.lblInterest.Size = new System.Drawing.Size(51, 16);
            this.lblInterest.TabIndex = 18;
            this.lblInterest.Text = "Interest";
            // 
            // lblPrincipal
            // 
            this.lblPrincipal.AutoSize = true;
            this.lblPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrincipal.Location = new System.Drawing.Point(166, 202);
            this.lblPrincipal.Name = "lblPrincipal";
            this.lblPrincipal.Size = new System.Drawing.Size(60, 16);
            this.lblPrincipal.TabIndex = 19;
            this.lblPrincipal.Text = "Principal";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayment.Location = new System.Drawing.Point(258, 202);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(61, 16);
            this.lblPayment.TabIndex = 20;
            this.lblPayment.Text = "Payment";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(341, 202);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(58, 16);
            this.lblBalance.TabIndex = 21;
            this.lblBalance.Text = "Balance";
            // 
            // lblTotalInterestOutput
            // 
            this.lblTotalInterestOutput.AutoSize = true;
            this.lblTotalInterestOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalInterestOutput.Location = new System.Drawing.Point(9, 33);
            this.lblTotalInterestOutput.Name = "lblTotalInterestOutput";
            this.lblTotalInterestOutput.Size = new System.Drawing.Size(82, 13);
            this.lblTotalInterestOutput.TabIndex = 3;
            this.lblTotalInterestOutput.Text = "                         ";
            // 
            // lblTotalLoansOutput
            // 
            this.lblTotalLoansOutput.AutoSize = true;
            this.lblTotalLoansOutput.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTotalLoansOutput.Location = new System.Drawing.Point(9, 78);
            this.lblTotalLoansOutput.Name = "lblTotalLoansOutput";
            this.lblTotalLoansOutput.Size = new System.Drawing.Size(82, 13);
            this.lblTotalLoansOutput.TabIndex = 4;
            this.lblTotalLoansOutput.Text = "                         ";
            // 
            // VehicleLoanCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(800, 638);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.lblPrincipal);
            this.Controls.Add(this.lblInterest);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.lstAllLoans);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtRebate);
            this.Controls.Add(this.checkBoxRebate);
            this.Controls.Add(this.comboBoxAPR);
            this.Controls.Add(this.txtLoanAmount);
            this.Controls.Add(this.groupBoxMonths);
            this.Controls.Add(this.lblAPR);
            this.Controls.Add(this.lblLoanAmount);
            this.Controls.Add(this.lblBottom);
            this.Controls.Add(this.lblTop);
            this.Controls.Add(this.pictureBox1);
            this.Name = "VehicleLoanCalculator";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBoxMonths.ResumeLayout(false);
            this.groupBoxMonths.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTop;
        private System.Windows.Forms.Label lblBottom;
        private System.Windows.Forms.Label lblLoanAmount;
        private System.Windows.Forms.Label lblAPR;
        private System.Windows.Forms.RadioButton radioButton6;
        private System.Windows.Forms.GroupBox groupBoxMonths;
        private System.Windows.Forms.RadioButton radioButton24;
        private System.Windows.Forms.RadioButton radioButton12;
        private System.Windows.Forms.RadioButton radioButton18;
        private System.Windows.Forms.TextBox txtLoanAmount;
        private System.Windows.Forms.ComboBox comboBoxAPR;
        private System.Windows.Forms.CheckBox checkBoxRebate;
        private System.Windows.Forms.TextBox txtRebate;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalLoans;
        private System.Windows.Forms.Label lblTotalInterest;
        private System.Windows.Forms.ListBox lstAllLoans;
        private System.Windows.Forms.Label lblMonth;
        private System.Windows.Forms.Label lblInterest;
        private System.Windows.Forms.Label lblPrincipal;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblTotalLoansOutput;
        private System.Windows.Forms.Label lblTotalInterestOutput;
    }
}

