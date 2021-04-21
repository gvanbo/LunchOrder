// Simple Windows Desktopp Application takes user selection and outputs totals
// Date Created is April 21, 2021
//Author Grant van Boeschoten

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LunchOrderProj
{
	public partial class LunchOrder : Form
	{
		public LunchOrder()
		{
			InitializeComponent();
		}
		// initialize subtotal varibale with 0
		double subtotal = 0;
		// each variable assings totals to menu itemes
		double hamburger = 6.95;
		double pizza = 5.95;
		double salad = 4.95;
		double hamburgerAdd = 0.75;
		double pizzaAdd = 0.50;
		double saladAdd = 0.25;
		double total;
		double tax;

        private void BtnExit_Click(object sender, EventArgs e)
		{
			// close Application
			this.Close();
		}

        private void RdoBurger_CheckedChanged(object sender, EventArgs e)
        {
			// Select Burger and linked Addons
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			resetTotals();
			resetCheck();
			subtotal = hamburger;

			           
        }

        private void RdoPizza_CheckedChanged(object sender, EventArgs e)
        {
			// Select Pizza and linked Addons
			grpHamburger.Visible = false;
			grpPizza.Visible = true;
			grpSalad.Visible = false;
			resetTotals();
			resetCheck();
			subtotal = pizza;

		}


        private void RdoSalad_CheckedChanged(object sender, EventArgs e)
        {
			// Select Salad and linked Addons
			grpHamburger.Visible = false;
			grpPizza.Visible = false;
			grpSalad.Visible = true;
			resetTotals();
			resetCheck();
			subtotal = salad;
	
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			// set initial settings to Hamburger
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			subtotal = hamburger;
			


		}

		private void CalculateTotals(double subtotal, ref double total, ref double tax)
        {
			// calculate totals
			 tax = subtotal * 0.05;
			 total = subtotal + tax;

        }

		private void displayTotals(double subtotal, double tax, double total)
        {
			TxtSubtotalOutput.Text = subtotal.ToString("c");
			txtTaxOutput.Text = tax.ToString("c");
			TxtTotalOutput.Text = total.ToString("c");

        }

		private void addOn(CheckBox item, double amount)
        {
			// checks addOns, if selected adds amount to subtotal
			if (item.Checked == true)
                subtotal += amount;
        }


		private void BtnPlaceOrder_Click(object sender, EventArgs e)
		{
			// add addons to subtotal
			addOn(chkBacon, saladAdd);
			addOn(chkBread, saladAdd);
			addOn(chkCroutons, saladAdd);
			addOn(chkFries, hamburgerAdd);
			addOn(chkKetchup, hamburgerAdd);
			addOn(chkLettuce, hamburgerAdd);
			addOn(chkOlives, pizzaAdd);
			addOn(chkPepperoni, pizzaAdd);
			addOn(chkSausage, pizzaAdd);
			//calculate total
			CalculateTotals(subtotal, ref total, ref tax);
			//display the total amounts of the order
			displayTotals(subtotal, tax, total);
		}



		private void resetCheck()
        {
			//unchecks all addons
			chkBacon.Checked = false;
			chkBread.Checked = false;
			chkCroutons.Checked = false;
			chkFries.Checked = false;
			chkKetchup.Checked = false;
			chkLettuce.Checked = false;
			chkOlives.Checked = false;
			chkPepperoni.Checked = false;
			chkSausage.Checked = false;

        }

		private void resetTotals()
        {
			// resets all currency values
			TxtSubtotalOutput.Text = "";
			txtTaxOutput.Text = "";
			TxtTotalOutput.Text = "";
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
			//reset totals & selections, autoselect burger
			resetCheck();
			resetTotals();
			subtotal = 0;
			RdoBurger.Checked = true;
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			subtotal = hamburger;


		}
    }
}
