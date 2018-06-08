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
    public partial class Form6 : Form
    {
       
        public Form6()
        {
            InitializeComponent();
        }

        public double P1_F = 0, P2_F = 0, M1_F = 0, M2_F = 0, Q1_F = 0, Q2_F = 0; // ВЕЛЕЧИНЫ. ВВОДЯТСЯ ВРУЧНУЮ В ФОРМЕ
        public double P1_U = 0, P2_U = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
        public double P1_X = 0, P1_Y = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
        public double P2_X = 0, P2_Y = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
        public double P1_L = 0, P2_L = 0, M1_L = 0, M2_L = 0, Q1_L = 0, Q2_L = 0, B_L = 0; //ПОЛОЖЕНИЕ, ВВОДИТСЯ ВРУЧНУЮ
        public double Q_F, Q_L; // НАХОЖДЕНИЕ РАВНОДЕЙСТВУЮЩЕЙ НАГРУЗКИ
        public double VA, VB;  // РЕАКЦИИ ОПОР, РАСЧИТЫВАЮТСЯ В ФОРМУЛАХ
        public string otv = "asf", VA_S_V, VB_S_V; //ОТВЕТ, ВЕКТОР А ВВЕРХ/ВНИЗБ ВЕКТОР В ВВЕРХ/ВНИЗ
        public bool VA_Z = false, VB_Z = false; // СТАТУС РЕАКЦИЙ (ЕСЛИ ЛОЖЬ - ВЕКТОР РЕАКЦИИ ВВЕРХ)
        znachF6.P1_F = this,Vivid.P1_F;

        public object Vivid { get; private set; }

   

        private void Form6_Load(object sender, EventArgs e)
        {

        }
    }
}