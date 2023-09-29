using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GavinMajorProject1
{
    public partial class VehicleLoanCalculator : Form
    {
        double interestTotal = 0;
        double principalTotal = 0;
        double fullPaymentTotal = 0;
       
       
        public VehicleLoanCalculator()
        {
            InitializeComponent();
        }

       

        private void checkBoxRebate_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBoxRebate.Checked)
            {
                txtRebate.Enabled = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            lstAllLoans.Items.Clear();
            lblTotalInterestOutput.Text = "                         ";
            lblTotalLoansOutput.Text = "                         ";
            double loan;
            if (double.TryParse(txtLoanAmount.Text, out loan)== false)
            {
                MessageBox.Show("Please enter a valid input to continue!");
                txtLoanAmount.Focus();
                txtLoanAmount.SelectAll();
                return;
            }
                double rate = Convert.ToDouble(comboBoxAPR.Text);
   
            if (loan == 0 || rate == 0)
            {
                MessageBox.Show("Enter a number other than 0!");
                txtLoanAmount.Focus();
                txtLoanAmount.Select();
                return;
            }
            int months;
            if (radioButton6.Checked)
            {
                months = 6;
            }
            else if (radioButton12.Checked)
            {
                months = 12;
            }
            else if (radioButton18.Checked)
            {
                months = 18;
            }
            else if (radioButton24.Checked)
            {
                months = 24;
            }
            else
            {
                months = 6;
            }
            
            if (checkBoxRebate.Checked)
            {
                double rebate = double.Parse(txtRebate.Text);
                loan = loan - rebate;
            }

            rate = rate / 100;

            //principal
            double principalPayment = principalPayment = rate / 12 * (loan + 0 * Math.Pow(1 + rate / 12, months)) / ((Math.Pow(1 + rate / 12, months) - 1) * (1 + rate / 12 * 0));

            //interest
            double interest = loan * (rate / 12);

            //ammortization schedule list
            for (int monthsCounter = 1; monthsCounter <= months; monthsCounter++)
            {
                double fullPayment = principalPayment + interest;
                loan = loan - principalPayment;

                interestTotal += interest;
                principalTotal += principalPayment;
                fullPaymentTotal += fullPayment;

                string formatString = "{0,5}{1,12}{2,12}{3,12}{4,12}";

                string monthsString = monthsCounter.ToString();
                string interestString = interest.ToString("c2");
                string principalString = principalPayment.ToString("c2");
                string fullPaymentString = fullPayment.ToString("c2");
                string balanceString = loan.ToString("c2");

                string totalString = String.Format(formatString, monthsString, interestString, principalString, fullPaymentString, balanceString);
                
                lstAllLoans.Items.Add(totalString);

                interest = loan * (rate / 12);
                principalPayment = fullPayment - interest;
            }
            string formatStringTotals = "{0,5}{1,12}{2,12}{3,12}";
            lstAllLoans.Items.Add("");
            string totals = String.Format(formatStringTotals, "Total", interestTotal.ToString("c2"), principalTotal.ToString("c2"), fullPaymentTotal.ToString("c2"));
            lstAllLoans.Items.Add(totals);


        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            lstAllLoans.Items.Clear();
            txtLoanAmount.Clear();
            txtRebate.Clear();
            comboBoxAPR.SelectedIndex = 0;
            checkBoxRebate.Checked = false;
            txtRebate.Enabled = false;
            radioButton6.Checked = true;
            txtLoanAmount.Focus();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lblTotalLoansOutput.Text = principalTotal.ToString("c2");
            lblTotalInterestOutput.Text = interestTotal.ToString("c2");
        }

        private void txtRebate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
