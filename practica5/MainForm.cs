using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CoversionDolaresPesos
{
	public partial class MainForm : Form
	{
		double x, y, z;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{	
			try
			{
				x = Double.Parse(textBox1.Text);
				y = Double.Parse(textBox2.Text);
				z = x/y;
				textBox3.Text = "$" + z.ToString();
			}
		    catch(FormatException)
		    {	
			   if(textBox1.Text == "" || textBox2.Text == "")
				MessageBox.Show("hay campos vacios");
			   else
			   	MessageBox.Show(" ERROR solo numeros");	
			}		
	       			
		}
		void Button2Click(object sender, EventArgs e)
		{
			textBox1.Clear();
			textBox2.Clear();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
				void TextBox3TextChanged(object sender, EventArgs e)
		{
			
		}
	}	
}
		
	

