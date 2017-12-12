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

    }
}
    

