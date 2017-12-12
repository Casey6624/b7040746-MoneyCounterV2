using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money_Counter
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // Function which "refreshes" the total each time a button is clicked. This is called on every add coin button.
        private void addCoins()
        {
            //Takes the text from the label (num of coins) and multiples by the worth of the coin
            int valueOf1P = Convert.ToInt16(lblNumOf1P.Text);
            int valueOf2P = Convert.ToInt16(lblNumOf2P.Text) * 2;
            int valueOf5P = Convert.ToInt16(lblNumOf5P.Text) * 5;
            int valueOf10P = Convert.ToInt16(lblNumOf10P.Text) * 10;
            int valueOf20P = Convert.ToInt16(lblNumOf20P.Text) * 20;
            int valueOf50P = Convert.ToInt16(lblNumOf50P.Text) * 50;
            int valueOfQuid = Convert.ToInt16(lblNumOfQuid.Text) * 100;
            int valueOf2Quid = Convert.ToInt16(lblNumOf2Quid.Text) * 200;

            int totalValueP = valueOf1P + valueOf2P + valueOf5P + valueOf10P + valueOf20P + valueOf50P + valueOfQuid + valueOf2Quid;
            txtTotalValueP.Text = totalValueP.ToString();
            // Divide by 100 to make 
            double totalValuePounds = Convert.ToDouble(totalValueP) / 100.00;
            /* https://docs.microsoft.com/en-us/dotnet/standard/base-types/standard-numeric-format-strings
             used the Microsoft link above as a reference to format the total of P into 2 decimal pound format. E.g £2.50
             */

            txtTotalValuePounds.Text = totalValuePounds.ToString("F");
        }
        // Total Credit Function which checks to see if a credit value has been entered and if so divides the total value of coins by this credit value.
        public void totalCredits()
        {
            int creditTotal = 0;
            int creditValue = Convert.ToInt16(txtCostPerCredit.Text);
            // Validates whether the credit cost is 0 or if it has been changed
            if (creditValue != 0)
            {
                creditTotal = Convert.ToInt16(txtTotalValueP.Text) / creditValue;
                txtNumOfCredits.Text = creditTotal.ToString();
            }
            else
            {
                //prompt user to enter a cost of credit
                MessageBox.Show("You have not set the Cost of a Credit.");
            }
        }

        // The code which adds an extra coin for each respective button 
        private void btnAdd1P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf1P.Text = (int.Parse(lblNumOf1P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }
        private void btnAdd2P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf2P.Text = (int.Parse(lblNumOf2P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAdd5P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf5P.Text = (int.Parse(lblNumOf5P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAdd10P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf10P.Text = (int.Parse(lblNumOf10P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAdd20P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf20P.Text = (int.Parse(lblNumOf20P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAdd50P_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf50P.Text = (int.Parse(lblNumOf50P.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAddQuid_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOfQuid.Text = (int.Parse(lblNumOfQuid.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }

        private void btnAdd2Quid_Click(object sender, EventArgs e)
        {
            if (txtCostPerCredit.Text != "0")
            {
                lblNumOf2Quid.Text = (int.Parse(lblNumOf2Quid.Text) + 1).ToString();
            }
            // The addCoins method is called
            addCoins();
            // The totalCredits method is called 
            totalCredits();
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Resets the text boxes back to "0" string
            txtTotalValueP.Text = "0";
            txtTotalValuePounds.Text = "0";
            txtCostPerCredit.Text = "0";
            txtNumOfCredits.Text = "0";
            // Resets the labels back to "0" string
            lblNumOf1P.Text = "0";
            lblNumOf2P.Text = "0";
            lblNumOf5P.Text = "0";
            lblNumOf10P.Text = "0";
            lblNumOf20P.Text = "0";
            lblNumOf50P.Text = "0";
            lblNumOfQuid.Text = "0";
            lblNumOf2Quid.Text = "0";

        }
    }
}

    

