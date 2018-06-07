using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sapr
{
	public partial class Form4 : Form
	{
		public Form4()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button4_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			textBox1.Text += (sender as Button).Text;
		}

		double a=0, b=0, c=0;
		char single;
		//double formula;
		bool dat = false;
		private void button14_Click(object sender, EventArgs e)
		{
				a = Convert.ToDouble(textBox1.Text);
				single = '+';
		//	if (dat == true)
				textBox1.Clear();
		}
		private void button13_Click(object sender, EventArgs e)
		{
				a = Convert.ToDouble(textBox1.Text);
				single = '*';
			//if (dat == true)
				textBox1.Clear();
		}
		private void button12_Click(object sender, EventArgs e)
		{
				a = Convert.ToDouble(textBox1.Text);
				single = '-';
			//if (dat == true)
				textBox1.Clear();
		}
		private void button11_Click(object sender, EventArgs e)
		{
				a = Convert.ToDouble(textBox1.Text);
				single = '/';
			//if(dat==true)
				textBox1.Clear();
		}
		private void button15_Click(object sender, EventArgs e)
		{
			//dat = true;
			b = Convert.ToDouble(textBox1.Text);
			switch (single)
			{
				case '+':c = a + b;
					break;
				case '-':c = a - b;
					break;
				case '*':c = a*b;
					break;
				case '/':
						c = a / b;
						break;
			}
				textBox1.Text = c.ToString();	
		}
		private void button16_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}
		private void button18_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
		}
		private void button19_Click(object sender, EventArgs e)
		{
			if (textBox1.Text != "")
				if (textBox1.Text[0] == '-')
					textBox1.Text = textBox1.Text.Remove(0, 1);
				else textBox1.Text = '-' + textBox1.Text;
		}
	}
}