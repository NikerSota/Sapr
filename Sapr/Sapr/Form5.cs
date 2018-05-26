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
	public partial class Form5 : Form
	{
		public Form5()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Form f6 = new Form6();
			f6.Show();
		}
	}
}
