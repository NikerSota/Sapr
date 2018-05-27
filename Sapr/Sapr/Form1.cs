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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void балка2ОпорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ff = new Form2();
            ff.Show();
        }

<<<<<<< HEAD
        
    }
=======
        private void цельПрограммыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Суть программы ");
        }

        private void инструкцияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Инструкция ");
        }

        private void обАвторахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Об авторах ");
        }

		private void калькуляторToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Form Calculator = new Form4();
			Calculator.ShowDialog();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
>>>>>>> d795f940700c109423556aa04f1ed255223a86a2
}
