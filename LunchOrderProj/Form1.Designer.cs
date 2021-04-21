
namespace LunchOrderProj
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.main = new System.Windows.Forms.GroupBox();
            this.RdoSalad = new System.Windows.Forms.RadioButton();
            this.RdoPizza = new System.Windows.Forms.RadioButton();
            this.RdoBurger = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblTotal = new System.Windows.Forms.Label();
            this.TxtTotalOutput = new System.Windows.Forms.TextBox();
            this.LblTax = new System.Windows.Forms.Label();
            this.txtTaxOutput = new System.Windows.Forms.TextBox();
            this.LblSubtotal = new System.Windows.Forms.Label();
            this.TxtSubtotalOutput = new System.Windows.Forms.TextBox();
            this.BtnPlaceOrder = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.grpHamburger = new System.Windows.Forms.GroupBox();
            this.chkFries = new System.Windows.Forms.CheckBox();
            this.chkKetchup = new System.Windows.Forms.CheckBox();
            this.chkLettuce = new System.Windows.Forms.CheckBox();
            this.grpSalad = new System.Windows.Forms.GroupBox();
            this.chkBread = new System.Windows.Forms.CheckBox();
            this.chkBacon = new System.Windows.Forms.CheckBox();
            this.chkCroutons = new System.Windows.Forms.CheckBox();
            this.grpPizza = new System.Windows.Forms.GroupBox();
            this.chkOlives = new System.Windows.Forms.CheckBox();
            this.chkSausage = new System.Windows.Forms.CheckBox();
            this.chkPepperoni = new System.Windows.Forms.CheckBox();
            this.main.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpHamburger.SuspendLayout();
            this.grpSalad.SuspendLayout();
            this.grpPizza.SuspendLayout();
            this.SuspendLayout();
            // 
            // main
            // 
            this.main.Controls.Add(this.RdoSalad);
            this.main.Controls.Add(this.RdoPizza);
            this.main.Controls.Add(this.RdoBurger);
            this.main.Location = new System.Drawing.Point(35, 40);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(237, 140);
            this.main.TabIndex = 0;
            this.main.TabStop = false;
            this.main.Text = "Main Course";
            // 
            // RdoSalad
            // 
            this.RdoSalad.AutoSize = true;
            this.RdoSalad.Location = new System.Drawing.Point(15, 83);
            this.RdoSalad.Name = "RdoSalad";
            this.RdoSalad.Size = new System.Drawing.Size(91, 19);
            this.RdoSalad.TabIndex = 2;
            this.RdoSalad.TabStop = true;
            this.RdoSalad.Text = "Salad - $4.95";
            this.RdoSalad.UseVisualStyleBackColor = true;
            this.RdoSalad.CheckedChanged += new System.EventHandler(this.RdoSalad_CheckedChanged);
            // 
            // RdoPizza
            // 
            this.RdoPizza.AutoSize = true;
            this.RdoPizza.Location = new System.Drawing.Point(15, 58);
            this.RdoPizza.Name = "RdoPizza";
            this.RdoPizza.Size = new System.Drawing.Size(89, 19);
            this.RdoPizza.TabIndex = 1;
            this.RdoPizza.TabStop = true;
            this.RdoPizza.Text = "Pizza - $5.95";
            this.RdoPizza.UseVisualStyleBackColor = true;
            this.RdoPizza.CheckedChanged += new System.EventHandler(this.RdoPizza_CheckedChanged);
            // 
            // RdoBurger
            // 
            this.RdoBurger.AutoSize = true;
            this.RdoBurger.Location = new System.Drawing.Point(15, 33);
            this.RdoBurger.Name = "RdoBurger";
            this.RdoBurger.Size = new System.Drawing.Size(124, 19);
            this.RdoBurger.TabIndex = 0;
            this.RdoBurger.TabStop = true;
            this.RdoBurger.Text = "Hamburger - $6.95";
            this.RdoBurger.UseVisualStyleBackColor = true;
            this.RdoBurger.CheckedChanged += new System.EventHandler(this.RdoBurger_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.LblTotal);
            this.groupBox1.Controls.Add(this.TxtTotalOutput);
            this.groupBox1.Controls.Add(this.LblTax);
            this.groupBox1.Controls.Add(this.txtTaxOutput);
            this.groupBox1.Controls.Add(this.LblSubtotal);
            this.groupBox1.Controls.Add(this.TxtSubtotalOutput);
            this.groupBox1.Location = new System.Drawing.Point(35, 209);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 195);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order Total";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(69, 131);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(35, 15);
            this.LblTotal.TabIndex = 5;
            this.LblTotal.Text = "Total:";
            // 
            // TxtTotalOutput
            // 
            this.TxtTotalOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtTotalOutput.Location = new System.Drawing.Point(110, 128);
            this.TxtTotalOutput.Name = "TxtTotalOutput";
            this.TxtTotalOutput.ReadOnly = true;
            this.TxtTotalOutput.Size = new System.Drawing.Size(100, 23);
            this.TxtTotalOutput.TabIndex = 4;
            // 
            // LblTax
            // 
            this.LblTax.AutoSize = true;
            this.LblTax.Location = new System.Drawing.Point(53, 89);
            this.LblTax.Name = "LblTax";
            this.LblTax.Size = new System.Drawing.Size(54, 15);
            this.LblTax.TabIndex = 3;
            this.LblTax.Text = "Tax (5%):";
            // 
            // txtTaxOutput
            // 
            this.txtTaxOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.txtTaxOutput.Location = new System.Drawing.Point(110, 86);
            this.txtTaxOutput.Name = "txtTaxOutput";
            this.txtTaxOutput.ReadOnly = true;
            this.txtTaxOutput.Size = new System.Drawing.Size(100, 23);
            this.txtTaxOutput.TabIndex = 2;
            // 
            // LblSubtotal
            // 
            this.LblSubtotal.AutoSize = true;
            this.LblSubtotal.Location = new System.Drawing.Point(53, 42);
            this.LblSubtotal.Name = "LblSubtotal";
            this.LblSubtotal.Size = new System.Drawing.Size(54, 15);
            this.LblSubtotal.TabIndex = 1;
            this.LblSubtotal.Text = "Subtotal:";
            // 
            // TxtSubtotalOutput
            // 
            this.TxtSubtotalOutput.BackColor = System.Drawing.SystemColors.Menu;
            this.TxtSubtotalOutput.Location = new System.Drawing.Point(110, 39);
            this.TxtSubtotalOutput.Name = "TxtSubtotalOutput";
            this.TxtSubtotalOutput.ReadOnly = true;
            this.TxtSubtotalOutput.Size = new System.Drawing.Size(100, 23);
            this.TxtSubtotalOutput.TabIndex = 0;
            // 
            // BtnPlaceOrder
            // 
            this.BtnPlaceOrder.BackColor = System.Drawing.Color.Honeydew;
            this.BtnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnPlaceOrder.Location = new System.Drawing.Point(348, 228);
            this.BtnPlaceOrder.Name = "BtnPlaceOrder";
            this.BtnPlaceOrder.Size = new System.Drawing.Size(172, 43);
            this.BtnPlaceOrder.TabIndex = 2;
            this.BtnPlaceOrder.Text = "&Place Order";
            this.BtnPlaceOrder.UseVisualStyleBackColor = false;
            this.BtnPlaceOrder.Click += new System.EventHandler(this.BtnPlaceOrder_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.BackColor = System.Drawing.Color.Azure;
            this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnReset.Location = new System.Drawing.Point(348, 284);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(172, 43);
            this.BtnReset.TabIndex = 3;
            this.BtnReset.Text = "&Reset";
            this.BtnReset.UseVisualStyleBackColor = false;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Snow;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Location = new System.Drawing.Point(348, 340);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(172, 43);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Text = "E&xit";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // grpHamburger
            // 
            this.grpHamburger.Controls.Add(this.chkFries);
            this.grpHamburger.Controls.Add(this.chkKetchup);
            this.grpHamburger.Controls.Add(this.chkLettuce);
            this.grpHamburger.Location = new System.Drawing.Point(326, 42);
            this.grpHamburger.Name = "grpHamburger";
            this.grpHamburger.Size = new System.Drawing.Size(172, 100);
            this.grpHamburger.TabIndex = 5;
            this.grpHamburger.TabStop = false;
            this.grpHamburger.Text = "AddOns - $0.75 Each";
            // 
            // chkFries
            // 
            this.chkFries.AutoSize = true;
            this.chkFries.Location = new System.Drawing.Point(6, 75);
            this.chkFries.Name = "chkFries";
            this.chkFries.Size = new System.Drawing.Size(85, 19);
            this.chkFries.TabIndex = 2;
            this.chkFries.Text = "French Fies";
            this.chkFries.UseVisualStyleBackColor = true;
            // 
            // chkKetchup
            // 
            this.chkKetchup.AutoSize = true;
            this.chkKetchup.Location = new System.Drawing.Point(7, 47);
            this.chkKetchup.Name = "chkKetchup";
            this.chkKetchup.Size = new System.Drawing.Size(156, 19);
            this.chkKetchup.TabIndex = 1;
            this.chkKetchup.Text = "Ketchup, Mustard & Mayo";
            this.chkKetchup.UseVisualStyleBackColor = true;
            // 
            // chkLettuce
            // 
            this.chkLettuce.AutoSize = true;
            this.chkLettuce.Location = new System.Drawing.Point(7, 22);
            this.chkLettuce.Name = "chkLettuce";
            this.chkLettuce.Size = new System.Drawing.Size(155, 19);
            this.chkLettuce.TabIndex = 0;
            this.chkLettuce.Text = "Lettuce, Tomato, Onions";
            this.chkLettuce.UseVisualStyleBackColor = true;
            // 
            // grpSalad
            // 
            this.grpSalad.Controls.Add(this.chkBread);
            this.grpSalad.Controls.Add(this.chkBacon);
            this.grpSalad.Controls.Add(this.chkCroutons);
            this.grpSalad.Location = new System.Drawing.Point(520, 42);
            this.grpSalad.Name = "grpSalad";
            this.grpSalad.Size = new System.Drawing.Size(172, 100);
            this.grpSalad.TabIndex = 7;
            this.grpSalad.TabStop = false;
            this.grpSalad.Text = "AddOns - $0.75 Each";
            // 
            // chkBread
            // 
            this.chkBread.AutoSize = true;
            this.chkBread.Location = new System.Drawing.Point(6, 75);
            this.chkBread.Name = "chkBread";
            this.chkBread.Size = new System.Drawing.Size(89, 19);
            this.chkBread.TabIndex = 2;
            this.chkBread.Text = "Bread Sticks";
            this.chkBread.UseVisualStyleBackColor = true;
            // 
            // chkBacon
            // 
            this.chkBacon.AutoSize = true;
            this.chkBacon.Location = new System.Drawing.Point(7, 47);
            this.chkBacon.Name = "chkBacon";
            this.chkBacon.Size = new System.Drawing.Size(81, 19);
            this.chkBacon.TabIndex = 1;
            this.chkBacon.Text = "Bacon Bits";
            this.chkBacon.UseVisualStyleBackColor = true;
            // 
            // chkCroutons
            // 
            this.chkCroutons.AutoSize = true;
            this.chkCroutons.Location = new System.Drawing.Point(7, 22);
            this.chkCroutons.Name = "chkCroutons";
            this.chkCroutons.Size = new System.Drawing.Size(75, 19);
            this.chkCroutons.TabIndex = 0;
            this.chkCroutons.Text = "Croutons";
            this.chkCroutons.UseVisualStyleBackColor = true;
            // 
            // grpPizza
            // 
            this.grpPizza.Controls.Add(this.chkOlives);
            this.grpPizza.Controls.Add(this.chkSausage);
            this.grpPizza.Controls.Add(this.chkPepperoni);
            this.grpPizza.Location = new System.Drawing.Point(714, 40);
            this.grpPizza.Name = "grpPizza";
            this.grpPizza.Size = new System.Drawing.Size(200, 100);
            this.grpPizza.TabIndex = 6;
            this.grpPizza.TabStop = false;
            this.grpPizza.Text = "AddOns - $0.75 Each";
            // 
            // chkOlives
            // 
            this.chkOlives.AutoSize = true;
            this.chkOlives.Location = new System.Drawing.Point(6, 75);
            this.chkOlives.Name = "chkOlives";
            this.chkOlives.Size = new System.Drawing.Size(58, 19);
            this.chkOlives.TabIndex = 2;
            this.chkOlives.Text = "Olives";
            this.chkOlives.UseVisualStyleBackColor = true;
            // 
            // chkSausage
            // 
            this.chkSausage.AutoSize = true;
            this.chkSausage.Location = new System.Drawing.Point(7, 47);
            this.chkSausage.Name = "chkSausage";
            this.chkSausage.Size = new System.Drawing.Size(69, 19);
            this.chkSausage.TabIndex = 1;
            this.chkSausage.Text = "Sausage";
            this.chkSausage.UseVisualStyleBackColor = true;
            // 
            // chkPepperoni
            // 
            this.chkPepperoni.AutoSize = true;
            this.chkPepperoni.Location = new System.Drawing.Point(7, 22);
            this.chkPepperoni.Name = "chkPepperoni";
            this.chkPepperoni.Size = new System.Drawing.Size(80, 19);
            this.chkPepperoni.TabIndex = 0;
            this.chkPepperoni.Text = "Pepperoni";
            this.chkPepperoni.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 450);
            this.Controls.Add(this.grpSalad);
            this.Controls.Add(this.grpPizza);
            this.Controls.Add(this.grpHamburger);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnPlaceOrder);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.main);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.main.ResumeLayout(false);
            this.main.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpHamburger.ResumeLayout(false);
            this.grpHamburger.PerformLayout();
            this.grpSalad.ResumeLayout(false);
            this.grpSalad.PerformLayout();
            this.grpPizza.ResumeLayout(false);
            this.grpPizza.PerformLayout();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox main;
		private System.Windows.Forms.RadioButton RdoSalad;
		private System.Windows.Forms.RadioButton RdoPizza;
		private System.Windows.Forms.RadioButton RdoBurger;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label LblSubtotal;
		private System.Windows.Forms.TextBox TxtSubtotalOutput;
		private System.Windows.Forms.Label LblTax;
		private System.Windows.Forms.TextBox txtTaxOutput;
		private System.Windows.Forms.TextBox TxtTotalOutput;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.Button BtnPlaceOrder;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.GroupBox grpHamburger;
        private System.Windows.Forms.CheckBox chkFries;
        private System.Windows.Forms.CheckBox chkKetchup;
        private System.Windows.Forms.CheckBox chkLettuce;
        private System.Windows.Forms.GroupBox grpPizza;
        private System.Windows.Forms.CheckBox chkOlives;
        private System.Windows.Forms.CheckBox chkSausage;
        private System.Windows.Forms.CheckBox chkPepperoni;
        private System.Windows.Forms.GroupBox grpSalad;
        private System.Windows.Forms.CheckBox chkBread;
        private System.Windows.Forms.CheckBox chkBacon;
        private System.Windows.Forms.CheckBox chkCroutons;
    }
}

