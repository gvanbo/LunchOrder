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

		double subtotal = 0;
		double hamburger = 6.95;
		double pizza = 5.95;
		double salad = 4.95;
		
		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void RdoBurger_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			resetTotals();
			resetCheck();
			subtotal = hamburger;

			           
        }

        private void RdoPizza_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = false;
			grpPizza.Visible = true;
			grpSalad.Visible = false;
			resetTotals();
			resetCheck();
			subtotal = pizza;

		}


        private void RdoSalad_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = false;
			grpPizza.Visible = false;
			grpSalad.Visible = true;
			resetTotals();
			resetCheck();
			subtotal = salad;
	
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			subtotal = hamburger;

			
		}

		private void display(double subtotal)
        {
			double tax = subtotal * 0.05;
			double total = subtotal + tax;
			TxtSubtotalOutput.Text = subtotal.ToString("c");
			txtTaxOutput.Text = tax.ToString("c");
			TxtTotalOutput.Text = total.ToString("c");

        }

		private void addOn(CheckBox item)
        {
			if (item.Checked == true)
                subtotal += 0.75;
        }


        private void BtnPlaceOrder_Click(object sender, EventArgs e)
        {
			// calculate addOns
			addOn(chkBacon);
			addOn(chkBread);
			addOn(chkCroutons);
			addOn(chkFries);
			addOn(chkKetchup);
			addOn(chkLettuce);
			addOn(chkOlives);
			addOn(chkPepperoni);
			addOn(chkSausage);
			//calculate total
			display(subtotal);
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
