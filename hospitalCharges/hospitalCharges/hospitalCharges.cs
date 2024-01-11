/*
Auth: Brian Schmidt
Date: 12/3/2023
Desc: Create an application that calculates the total cost of a hospital stay. 
The daily base charge is $350. The hospital also charges for medication, surgical fees, 
lab fees, and physical rehab. The application should accept the following input:• 
The number of days spent in the hospital • The amount of medication charges• 
The amount of surgical charges• The amount of lab fees• The amount of physical rehabilitation 
chargesCreate and use the following value-returning methods in the application:•
CalcStayCharges—Calculates and returns the base charges for the hospital stay. This is computed as $350 times 
the number of days in the hospital.• CalcMiscCharges—Calculates and returns the total of the medication, 
surgical, lab, and physical rehabilitation charges.• CalcTotalCharges—Calculates and returns the total charges.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hospitalCharges
{
    public partial class hospitalCharges : Form
    {
        public hospitalCharges()
        {
            InitializeComponent();
        }

        // pass by value method for the days stayed in the hospital
        private decimal calcStayCharges(decimal days)
        {
            return days * 350;
        }

        // pass by value method for the total charges of medications, surgurys, labs, and rehab
        private decimal calcMiscCharges(decimal totalMeds, decimal totalSurgical, decimal totalLabs, decimal totalRehab) 
        {
            return totalMeds + totalSurgical + totalLabs + totalRehab;
        }

        // pass by value method for the total charges for the whole hospital stay including all charges
        private decimal calcTotalCharges(decimal daysStayed, decimal otherTotal) 
        {
            return daysStayed + otherTotal;        
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // close the application
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // clear the input and output fields
            hospitalStayTextbox.Text = "0";
            medicationAmountTextbox.Text = "0";
            surgicalAmountTextbox.Text = "0";
            labAmountTextbox.Text = "0";
            rehabAmountTextbox.Text = "0";
            totalStayOutputLable.Text = "$0.00";
            totalOtherOutputLabel.Text = "$0.00";
            totalCostOutputLabel.Text = "$0.00";
            // return focus to the days stayed textbox
            hospitalStayTextbox.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declare the variables needed
            decimal calcTotalCharges, calcMiscTotals, calcStayCharges, days, totalMeds, totalSurgical, totalLabs, totalRehab;
            
            // take in the number of days stayed in the hospital
            if (decimal.TryParse(hospitalStayTextbox.Text, out days))
            {
            }
            else
            {
                // display an error message
                MessageBox.Show("Enter a valid number of days stayed in the hospital");
            }

            // Calculate the charges for the amount of days stayed in the hospital
            calcStayCharges = 350 * days;
            totalStayOutputLable.Text = calcStayCharges.ToString("c");

            // take in the amount spent on medications
            if (decimal.TryParse(medicationAmountTextbox.Text, out totalMeds)) 
            {
            }
            else
            {
                // display and error message
                MessageBox.Show("Enter a valid cost for the medications recieved");
            }

            // take in the amount spent on surgury
            if (decimal.TryParse(surgicalAmountTextbox.Text, out totalSurgical))
            {
            }
            else
            {
                // display and error message
                MessageBox.Show("Enter a valid cost for the surgury recieved");
            }

            // take in the amount spent on Labs
            if (decimal.TryParse(labAmountTextbox.Text, out totalLabs))
            {
            }
            else
            {
                // display and error message
                MessageBox.Show("Enter a valid cost for the labs recieved");
            }

            // take in the amount spent on Rehab
            if (decimal.TryParse(rehabAmountTextbox.Text, out totalRehab))
            {
            }
            else
            {
                // display and error message
                MessageBox.Show("Enter a valid cost for the Rehabilitation recieved");
            }

            // Calculate the charges for all other charges
            calcMiscTotals = totalMeds + totalSurgical + totalLabs + totalRehab;
            totalOtherOutputLabel.Text = calcMiscTotals.ToString("c");

            // Calculate the total Charges
            calcTotalCharges = calcMiscTotals + calcStayCharges;
            totalCostOutputLabel.Text = calcTotalCharges.ToString("c");

        }
    }
}
