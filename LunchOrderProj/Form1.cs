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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		double subtotal = 0;
		
		private void BtnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void RdoBurger_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			subtotal = 6.95;


			if (chkLettuce.Checked == true)
				subtotal += 0.75;
			if (chkKetchup.Checked == true)
				subtotal += 0.75;
			if (chkFries.Checked == true)
				subtotal += 0.75;

			           
        }

        private void RdoPizza_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = false;
			grpPizza.Visible = true;
			grpSalad.Visible = false;
			subtotal = 5.95;


			if (chkPepperoni.Checked == true)
				subtotal += 0.75;
			if (chkSausage.Checked == true)
				subtotal += 0.75;
			if (chkOlives.Checked == true)
				subtotal += 0.75;

			//display(subtotal);
		}

        private void RdoSalad_CheckedChanged(object sender, EventArgs e)
        {
			grpHamburger.Visible = false;
			grpPizza.Visible = false;
			grpSalad.Visible = true;
			subtotal = 4.95;


			if (chkCroutons.Checked == true)
				subtotal += 0.75;
			if (chkBacon.Checked == true)
				subtotal += 0.75;
			if (chkBread.Checked == true)
				subtotal += 0.75;

			
		}

        private void Form1_Load(object sender, EventArgs e)
        {
			grpHamburger.Visible = true;
			grpPizza.Visible = false;
			grpSalad.Visible = false;
			subtotal = 6.95;

			
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
			addOn(chkBacon);
			addOn(chkBread);
			addOn(chkCroutons);
			addOn(chkFries);
			addOn(chkKetchup);
			addOn(chkLettuce);
			addOn(chkOlives);
			addOn(chkPepperoni);
			addOn(chkSausage);
			display(subtotal);
		}
    }
}
