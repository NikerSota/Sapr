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
//<<<<<<< HEAD
//        //class Niker_class_raschet
//        //{
//        //    public int P1 = (Convert.ToInt16(TXBX_P1_F)), P2 = (Convert.ToInt16(TXBX_P2_F)), M1 = (Convert.ToInt16(TXBX_M1_F)),
//        //               M2 = (Convert.ToInt16(TXBX_M2_F)), Q1 = (Convert.ToInt16(TXBX_Q1_F)), Q2 = (Convert.ToInt16(TXBX_Q2_F)); // ВЕЛЕЧИНЫ. ВВОДЯТСЯ ВРУЧНУЮ В ФОРМЕ
//        //    public int UP1 = (Convert.ToInt16(TXBX_P1_U)), UP2 = (Convert.ToInt16(TXBX_P2_U)); //УГОЛ, ВВОДИТЬСЯ ВРУЧНУЮ
//        //    public int PP1 = (Convert.ToInt16(TXBX_P1_L)), PP2 = (Convert.ToInt16(TXBX_P2_L)), PM1 = (Convert.ToInt16(TXBX_M1_L)), 
//        //               PM2 = (Convert.ToInt16(TXBX_M2_L)), PQ1 = (Convert.ToInt16(TXBX_Q1_L)), PQ2 = (Convert.ToInt16(TXBX_Q2_L)); //ПОЛОЖЕНИЕ, ВВОДИТЬСЯ ВРУЧНУЮ
//        //    public int Q, PQ; // НАХОЖДЕНИЕ РАВНОДЕЙСТВУЮЩЕЙ НАГРУЗКИ
//        //    public double RA, RB;  // РЕАКЦИИ ОПОР, РАСЧИТЫВАЮТСЯ В ФОРМУЛАХ
//        //    public int PRA = 0, PRB = 0; //ПОЛОЖЕНИЕ ОПОР
//        //    public string otv, rat, rbt; //ОТВЕТ, ВЕКТОР А ВВЕРХ/ВНИЗБ ВЕКТОР В ВВЕРХ/ВНИЗ
//        //    public bool RAS = false, RBS = false; // СТАТУС РЕАКЦИЙ (ЕСЛИ ЛОЖЬ - ВЕКТОР РЕАКЦИИ ВВЕРХ)

//        //    public void Q_raschet()
//        //    {
//        //        if (Q1 == Q2)
//        //        {
//        //            Q = Q1 * (PQ2 - PQ1); //ДЛЯ ПРЯМОУГОЛЬНОЙ НАГРУЗКИ
//        //            PQ = PQ1 + (PQ2 - PQ1); //ТОЧКА ПРИЛОЖЕНИЯ СИЛЫ
//        //        }
//        //        else if (Q1 == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ ВОЗРАСТАЮЩЕЙ НАГРУЗКИ 
//        //        {
//        //            Q = (PQ2 - PQ1) * Q2 / 2;
//        //            PQ = PQ1 + 2 * (PQ2 - PQ1) / 3;
//        //        }
//        //        else if (Q2 == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ СПАДАЮЩЕЙ НАГРУЗКИ 
//        //        {
//        //            Q = (PQ2 - PQ1) * Q1 / 2;
//        //            PQ = PQ1 + 1 * (PQ2 - PQ1) / 3;
//        //        }
//        //        //else if (Q1 > Q2) //ПРОДОЛЖЕНИЕ ДЛЯ ТРАПЕЦЕВИДНОЙ НАГРУЗКИ
//        //        //{
//        //        //ClassName object = new ClassName();
//        //        //var object = new Classname();
//        //        //object.Q=COnvert.Toint16
//        //        //object.Method1();
//        //        //}
//        //    }
//        //    public double RB_raschet() // РАСЧЕТ ОПОРЫ В
//        //    {
//        //        RB = (M1 - P1 * PP1 + P2 * PP2 + Q * PQ * (PQ2 - PQ1) + M2) / PRB; // РАСЧЕТ РЕАКЦИИ А ПУТЕМ НАОЖДЕНИЯ СУММЫ МОМЕНТОВ
//        //        if (RB < 0)
//        //        {
//        //            RB = -RB; // ЗНАЧЕНИЕ В ПО МОДУЛЮ
//        //            RBS = !RBS; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
//        //        }
//        //        return RB; //ВЫВОД ПОСЧИТАННОЙ РЕАКЦИИ В
//        //    }
//        //    public double RA_raschet() // РАСЧЕТ ОПОРЫ А
//        //    {
//        //        RB = RB_raschet(); // ПРИСВАИВАНИЕ РЕАКЦИИ В ПОСЧИТАННОГО ЗНАЧЕНИЯ
//        //        RA = -P1 + P2 + Q * PQ - RB; // РАСЧЕТ РЕАКЦИИ В ПУТЕМ НАХОЖДЕНИЯ СУМЫ ВЕРТИКАЛЬНЫХ СИЛ
//        //        if (RA < 0)
//        //        {
//        //            RA = -RA; // ЗНАЧЕНИЕ А ПО МОДУЛЮ
//        //            RAS = !RAS; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
//        //        }
//        //        return RA; //ВЫВОД ПОСЧИТАНОЙ РЕАКЦИИ А
//        //    }
//        //    public void Vektory()
//        //    {
//        //        RA = RA_raschet();
//        //        RB = RB_raschet();
//        //        if (RBS == true) rbt = "Вектор RB направлен вниз";
//        //        else rbt = "Вектор RB направлен вверх";
//        //        if (RAS == true) rat = "Вектор RA направлен вниз";
//        //        else rat = "Вектор RA направлен вверх";
//        //        otv = "Вертикальная реакция опоры А = " + RA + ". " + rat + '\n' + "Вертикальная реакция опоры B = " + RB + ". " + rbt;
//        //        // Запись ответа
//        //        RAS = false;
//        //        RBS = false;
//        //    }
//        //}
//        void Niker_data()
//        {

//        }
//        void arrowdrow() // ФУНКЦИЯ РИСОВАНИЯ БАЛКИ И СТРЕЛКИ
//        {
//            int XAR = 0; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ СТРЕЛКИ СИЛЫ 
//            int[] arrow = new int[11]; // МАССИВ ДАННЫХ, ИСПОЛЬЗУЮЩИЙСЯ ДЛЯ ВВОБДА ИНФОРМАЦИИ
//            Pen p = new Pen(Color.Red, 5); // СОЗДАЕМ КИСТЬ, СТАВИМ ЦВЕТ
//            PointF[] arrowpoints = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СТРЕЛКИ" 
//        {
//            new PointF(10F +XAR, 10F),
//            new PointF(50F+XAR, 50F),
//            new PointF(90F+XAR, 10F),
//            new PointF(110F+XAR, 10F),
//            new PointF(110F+XAR, 60F)
//        };
//            //Graphics gPanel = panel1.CreateGraphics(); //СОЗДАНИЕ ГРАФИЧЕСКОГО ИНТЕРФЕЙСЯ В ЭЛЕМЕНТЕ ПАНЕЛЬ
//            //gPanel.DrawLine(p, new Point(10, 65), new Point(490, 65)); //БАЛКА ДЛИННОЙ В 480 ЕДuНИЦ, ЛИБО В 8 МЕТРОВ В МАСШТАБЕ
//            //gPanel.DrawLine(p, new Point(499, 0), new Point(499, 130)); //ПРОВЕРКА ГРАНИЦ РАМКИ
//            //gPanel.DrawLine(p, new Point(arrow[4], arrow[5]), new Point(arrow[6], arrow[7])); //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
//            //gPanel.DrawLine(p, new Point(arrow[8], arrow[9]), new Point(arrow[10], arrow[11])); //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
//            //gPanel.DrawLines(p, arrowpoints); //ПОСТРОЕНИЕ СТРЕЛКИ ОДНОЙ КРИВОЙ
//            //Graphics gButton = button2.CreateGraphics(); //МАКРОС ДЛЯ КНОПКИ


//            int[] arrow2 = { 10, 0, 10, 20, 10, 20, 5, 15, 10, 20, 15, 15 }; //ИНИЦИАЛИЗАЦИЯ МАССИВА ДАННЫХ ДЛЯ ЛИНИЙ
//        }

//        void Baka_graphic()
//        {

//            for (int i = 0; i < 50; i++)//ЦИКЛ ПОСТРОЕНИЯ ГРАФИКА НОМЕР 1(Q)
//            {

//                //   Graphic_Q.Series[0].Points.AddXY(i, Math.Sin(1));//ФУНКИЯ ПОСТРОЙКИ ГРАФИКА

//            }

//            for (int i = 0; i < 50; i++)//ЦИКЛ ПОСТРОЕНИЯ ГРАФИКА НОМЕР 2(М)
//            {

//                //   Graphic_M.Series[0].Points.AddXY(i, Math.Sin(1));//ФУНКИЯ ПОСТРОЙКИ ГРАФИКА

//            }

//        }

//=======
        
//>>>>>>> 49f478466f78d113636205e90395a67e6c7be5bb
        private void балка2ОпорыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form ff = new Form2();
            ff.Show();
        }

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
			Calculator.Show();
		}
	}
}
