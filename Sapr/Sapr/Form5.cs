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
        public string otvet;
        Form2 f2 = new Form2();
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();

        }
        //public void Write()
        //{
        //    Graphics g = panel1.CreateGraphics();
        //    // Create string to draw.
        //    String drawString = "fdsf";

        //    // Create font and brush.
        //    Font drawFont = new Font("Arial", 16);
        //    SolidBrush drawBrush = new SolidBrush(Color.Red);

        //    // Create point for upper-left corner of drawing.
        //    PointF drawPoint = new PointF(10.0F, 10.0F);

        //    // Set format of string.
        //    StringFormat drawFormat = new StringFormat();
        //    drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

        //    // Draw string to screen.
        //    g.DrawString(drawString, drawFont, drawBrush, drawPoint, drawFormat);
        //    Graphics ff1 = this.CreateGraphics();
        //}
        private void Form5_Load(object sender, EventArgs e)
        {

            label1.Text = otvet;
            label1.ForeColor = Color.WhiteSmoke;
            //Write();
        }

    }
}
