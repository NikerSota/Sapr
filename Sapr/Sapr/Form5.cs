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
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form f6 = new Form6();
            f6.Show();

        }
        public void Write()
        {
            Graphics g = pictureBox1.CreateGraphics();
            // Create string to draw.
            String drawString = "fdsf";

            // Create font and brush.
            Font drawFont = new Font("Arial", 70);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(320.0F, 130.0F);

            // Set format of string.
            StringFormat drawFormat = new StringFormat();
            drawFormat.FormatFlags = StringFormatFlags.DirectionVertical;

            // Draw string to screen.
            g.DrawString(drawString, drawFont, drawBrush, drawPoint, drawFormat);
        }
        private void Form5_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            otvet = f2.otvet;
            Write();
        }
    }
}
