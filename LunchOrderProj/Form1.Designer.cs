
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
			this.RdoBurger = new System.Windows.Forms.RadioButton();
			this.RdoPizza = new System.Windows.Forms.RadioButton();
			this.RdoSalad = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.TxtSubtotalOutput = new System.Windows.Forms.TextBox();
			this.LblSubtotal = new System.Windows.Forms.Label();
			this.LblTax = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.TxtTotalOutput = new System.Windows.Forms.TextBox();
			this.LblTotal = new System.Windows.Forms.Label();
			this.BtnPlaceOrder = new System.Windows.Forms.Button();
			this.BtnReset = new System.Windows.Forms.Button();
			this.BtnExit = new System.Windows.Forms.Button();
			this.main.SuspendLayout();
			this.groupBox1.SuspendLayout();
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
			this.main.Enter += new System.EventHandler(this.groupBox1_Enter);
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
			this.RdoSalad.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.LblTotal);
			this.groupBox1.Controls.Add(this.TxtTotalOutput);
			this.groupBox1.Controls.Add(this.LblTax);
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.LblSubtotal);
			this.groupBox1.Controls.Add(this.TxtSubtotalOutput);
			this.groupBox1.Location = new System.Drawing.Point(35, 209);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(237, 195);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Order Total";
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
			// LblSubtotal
			// 
			this.LblSubtotal.AutoSize = true;
			this.LblSubtotal.Location = new System.Drawing.Point(53, 42);
			this.LblSubtotal.Name = "LblSubtotal";
			this.LblSubtotal.Size = new System.Drawing.Size(54, 15);
			this.LblSubtotal.TabIndex = 1;
			this.LblSubtotal.Text = "Subtotal:";
			this.LblSubtotal.Click += new System.EventHandler(this.label1_Click);
			// 
			// LblTax
			// 
			this.LblTax.AutoSize = true;
			this.LblTax.Location = new System.Drawing.Point(53, 89);
			this.LblTax.Name = "LblTax";
			this.LblTax.Size = new System.Drawing.Size(54, 15);
			this.LblTax.TabIndex = 3;
			this.LblTax.Text = "Tax (5%):";
			this.LblTax.Click += new System.EventHandler(this.label2_Click);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
			this.textBox1.Location = new System.Drawing.Point(110, 86);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 2;
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// TxtTotalOutput
			// 
			this.TxtTotalOutput.BackColor = System.Drawing.SystemColors.Menu;
			this.TxtTotalOutput.Location = new System.Drawing.Point(110, 128);
			this.TxtTotalOutput.Name = "TxtTotalOutput";
			this.TxtTotalOutput.ReadOnly = true;
			this.TxtTotalOutput.Size = new System.Drawing.Size(100, 23);
			this.TxtTotalOutput.TabIndex = 4;
			this.TxtTotalOutput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Location = new System.Drawing.Point(69, 131);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(35, 15);
			this.LblTotal.TabIndex = 5;
			this.LblTotal.Text = "Total:";
			this.LblTotal.Click += new System.EventHandler(this.label1_Click_1);
			// 
			// BtnPlaceOrder
			// 
			this.BtnPlaceOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnPlaceOrder.Location = new System.Drawing.Point(348, 228);
			this.BtnPlaceOrder.Name = "BtnPlaceOrder";
			this.BtnPlaceOrder.Size = new System.Drawing.Size(172, 43);
			this.BtnPlaceOrder.TabIndex = 2;
			this.BtnPlaceOrder.Text = "&Place Order";
			this.BtnPlaceOrder.UseVisualStyleBackColor = true;
			this.BtnPlaceOrder.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnReset
			// 
			this.BtnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnReset.Location = new System.Drawing.Point(348, 284);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(172, 43);
			this.BtnReset.TabIndex = 3;
			this.BtnReset.Text = "&Reset";
			this.BtnReset.UseVisualStyleBackColor = true;
			this.BtnReset.Click += new System.EventHandler(this.button2_Click);
			// 
			// BtnExit
			// 
			this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.BtnExit.Location = new System.Drawing.Point(348, 340);
			this.BtnExit.Name = "BtnExit";
			this.BtnExit.Size = new System.Drawing.Size(172, 43);
			this.BtnExit.TabIndex = 4;
			this.BtnExit.Text = "E&xit";
			this.BtnExit.UseVisualStyleBackColor = true;
			this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.BtnExit);
			this.Controls.Add(this.BtnReset);
			this.Controls.Add(this.BtnPlaceOrder);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.main);
			this.Name = "Form1";
			this.Text = "Lunch Order";
			this.main.ResumeLayout(false);
			this.main.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
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
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox TxtTotalOutput;
		private System.Windows.Forms.Label LblTotal;
		private System.Windows.Forms.Button BtnPlaceOrder;
		private System.Windows.Forms.Button BtnReset;
		private System.Windows.Forms.Button BtnExit;
	}
}

