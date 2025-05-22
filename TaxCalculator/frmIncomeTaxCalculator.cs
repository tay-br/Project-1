using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaxCalculator
{
    public partial class frmIncomeTaxCalculator : Form
    {
        //This form calculates the taxes owed for a user when the user enters their income into the form.
        public frmIncomeTaxCalculator()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Convert the text input entered into the txtTaxableIncome textbox into a decimal.
            decimal taxableIncome = Convert.ToDecimal(txtTaxableIncome.Text);

            //Create a variable (decimal type) called taxOwed (which will later store the tax Owed value) and set the initial value to 0.
            decimal taxOwed = 0;

            /************************************************************************************************************************************
            (Below) An if statement is used to determine which tax bracket the user input falls under by determining if the value is greater than 
            the lowest value in the tax bracket and also if it is equal to or less than the highest value in the tax bracket. It then calculates
            the tax owed by adding the taxes from lower brackets to the tax specified in the bracket the user input falls under. Ex: If the 
            user enters 100000, the third "else if" expression would run and the taxOwed would be calculated for that tax bracket.
            ************************************************************************************************************************************/

            if (taxableIncome > 0 & taxableIncome <= 9225)
                taxOwed = (taxableIncome - 0) * 0.1m;
            else if (taxableIncome > 9225 & taxableIncome <= 37450)
                taxOwed = ((taxableIncome - 9225) * 0.15m) + ((9225 - 0) * 0.10m);
            else if (taxableIncome > 37450 & taxableIncome <= 90750)
                taxOwed = ((taxableIncome - 37450) * 0.25m) + ((37450 - 9225) * 0.15m) + ((9225 - 0) * 0.10m);
            else if (taxableIncome > 90750 & taxableIncome <= 189300)
                taxOwed = ((taxableIncome - 90750) * 0.28m) + ((90750 - 37450) * 0.25m) + ((37450 - 9225) * 0.15m) + ((9225 - 0) * 0.10m);
            else if (taxableIncome > 189300 & taxableIncome <= 411500)
                taxOwed = ((taxableIncome - 189300) * 0.33m) + ((189300 - 90750) * 0.28m) + ((90750 - 37450) * 0.25m) + ((37450 - 9225) * 0.15m) + ((9225 - 0) * 0.10m);
            else if (taxableIncome > 411500 & taxableIncome <= 413200)
                taxOwed = ((taxableIncome - 411500) * 0.35m) + ((411500 - 189300) * 0.33m) + ((189300 - 90750) * 0.28m) + ((90750 - 37450) * 0.25m) + ((37450 - 9225) * 0.15m) + ((9225 - 0) * 0.10m);
            else if (taxableIncome > 413200)
                taxOwed = ((taxableIncome - 413200) * 0.396m) + ((413200 - 411500) * 0.35m) + ((411500 - 189300) * 0.33m) + ((189300 - 90750) * 0.28m) + ((90750 - 37450) * 0.25m) + ((37450 - 9225) * 0.15m) + ((9225 - 0) * 0.10m);

            //Converts the taxOwed variable to a string and puts the output in the txtTaxOwed read-only text box. The output is what the user would owe in taxes.
            txtTaxOwed.Text = Convert.ToString(taxOwed);

            //Brings focus back to the txtTaxableIncome textbox.
            txtTaxableIncome.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Closes the form.
            this.Close();
        }
    }
}
