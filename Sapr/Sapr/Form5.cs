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
        //public string otvet;
        //public string Otvet
        //{
        //    get { return otvet; }
        //    set { otvet = value; }
        //}
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            //textBox1.Text = f2.otvet;
        }
    }
}
