using Lab2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerData
{

    /* CPRG 200 Part 2: Lab Assignment 2
     * Purpose: This application allow users to calucate electricity bills based on their kWh usage and customer type
     *          Also it enables users to see the statstics of customer information, 
     *          and it creates a single text file that contains customer information on each line
     * Author: MK Kim
     * Student ID: 662580
     */
    public partial class Form1 : Form
    {
        //INSTANT VARIABLES//

        

        private const decimal FLAT_RES = 6.00m;  // Residential Flat Rate (0 kWh)
        private const decimal RATE_RES = 0.052m; // Residential Regular Rate (After 0 kWh)

        private const decimal FLAT_COM = 60.00m; // Commerical Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_COM = 0.045m; // Commercial Regular Rate (After 1000 kWh)

        private const decimal FLAT_IND_PEAK = 76.00m; // Indusrial Peak Hours Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_IND_PEAK = 0.065m; // Indusrial Peak Hours Regular Rate (After 1000 kWh)

        private const decimal FLAT_IND_NO_PEAK = 40.00m; // Indusrial Non-Peak Hours Flat Rate (Between 0 and 1000 kWh)
        private const decimal RATE_IND_NO_PEAK = 0.028m; // Indusrial Non-Peak Hours Regular Rate (After 1000 kWh)

        List<Customer> customers = new List<Customer>();
        Customer customer;

        

        private string name; 
        private int acct;
        private char type;
        private decimal amount = 0;

        private int usage;
        private int usagePeak;
        private int usageNoPeak;

        public Form1()
        {
            InitializeComponent();
        }


        // Calculate Button
        private void btnCalculate_Click_1(object sender, EventArgs e)
        {

            // validates value
            if (Validator.IsPresent(txtName))
                name = txtName.Text;
          
            

            if(Validator.IsPresent(txtAccount) &&
               Validator.IsInteger(txtAccount) && 
               Validator.IsNonNegativeInteger(txtAccount))
            acct = Convert.ToInt32(txtAccount.Text);


            customer = new Customer(acct, name, type);


            if (radRes.Checked)
            {
                customer.Type = 'R';
                if (Validator.IsPresent(txtKwh) && Validator.IsInteger(txtKwh) && Validator.IsNonNegativeInteger(txtKwh))
                {
                    usage = Convert.ToInt32(txtKwh.Text);
                    customer.CalculateCharge('R', usage, 0, 0);
                }                  
            }

            else if(radCom.Checked)
            {
                customer.Type = 'C';
                if (Validator.IsPresent(txtKwh) && Validator.IsInteger(txtKwh) && Validator.IsNonNegativeInteger(txtKwh))
                {
                    usage = Convert.ToInt32(txtKwh.Text);
                    customer.CalculateCharge('C', usage, 0, 0);
                }
            }

            else if (radInd.Checked)
            {
                customer.Type = 'I';
                 if (Validator.IsPresent(txtPeak) && Validator.IsInteger(txtPeak) && Validator.IsNonNegativeInteger(txtPeak)
                     && Validator.IsPresent(txtNoPeak) && Validator.IsInteger(txtNoPeak) && Validator.IsNonNegativeInteger(txtNoPeak))
                {
                    usagePeak = Convert.ToInt32(txtPeak.Text);
                    usageNoPeak = Convert.ToInt32(txtNoPeak.Text);
                    customer.CalculateCharge('I', 0, usagePeak, usageNoPeak);
                }
                
            }
            
            lblBill.Text = customer.Amount.ToString("c");


            
        }
        // ADD
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
         
                customers.Add(customer);
                DisplayCustomers();
                DisplayStatistics();
           
        }

       

        private void DisplayCustomers()
        {
            
            
            lstCust.Items.Clear();
            foreach (Customer c in customers)
            {

                var row = c.ToString();
                //var row = new String[] { c.AccountNo.ToString(), c.Name, c.Type.ToString(), c.Amount.ToString("c") };
                var lvi = new ListViewItem(row);
                lvi.Tag = c;
                lstCust.Items.Add(lvi);
            }
        }

        private void DisplayStatistics()
        {
            decimal resTotal = 0;
            decimal comTotal = 0;
            decimal indTotal = 0;
            

            // total amount of charge
            lblTotalCustomer.Text = customers.Count().ToString();

            // total amount of each type
            foreach (Customer c in customers)
            {
                if (c.Type.Equals('R'))
                {
                    resTotal += c.Amount;
                }
                else if (c.Type.Equals('C'))
                {
                    comTotal += c.Amount;
                }
                else if (c.Type.Equals('I'))
                {
                    indTotal += c.Amount;
                }

            }

            decimal totalAmount = resTotal + comTotal + indTotal;

            lblResTotal.Text = resTotal.ToString("c");
            lblComTotal.Text = comTotal.ToString("c");
            lblIndTotal.Text = indTotal.ToString("c");
            lblTotalAmount.Text = totalAmount.ToString("c");


        }


        
        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.ActiveControl = txtAccount;
            customers = CustomerDB.GetCustomers();
            DisplayCustomers();
            DisplayStatistics();
            radRes.Checked = true;
            pnlInd.Visible = false;
        }

       

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            lblBill.Text = "";
            txtNoPeak.Text = "";
            txtPeak.Text = "";
            txtKwh.Text = "";
            txtAccount.Text = "";
            txtName.Text = "";
            txtAccount.Focus();
            radRes.Checked = true;

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void radRes_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlInd.Visible = false;
            lblBill.Text = "";
            txtNoPeak.Text = "";
            txtPeak.Text = "";
            txtKwh.Text = "";
           
        }

        private void radCom_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlInd.Visible = false;
            lblBill.Text = "";
            txtNoPeak.Text = "";
            txtPeak.Text = "";
            txtKwh.Text = "";
           
        }

        private void radInd_CheckedChanged_1(object sender, EventArgs e)
        {
            pnlInd.Visible = true;
            lblBill.Text = "";
            txtNoPeak.Text = "";
            txtPeak.Text = "";
            txtKwh.Text = "";
           
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            CustomerDB.SaveProducts(customers);
        }
    }
}
