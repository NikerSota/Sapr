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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //public static Form2 form2 = new Form2();


        class Niker_class_raschet
        {

            public float P1 = 0, P2 = 0, M1 = 0, M2 = 0, Q1 = 0, Q2 = 0; // ВЕЛЕЧИНЫ. ВВОДЯТСЯ ВРУЧНУЮ В ФОРМЕ
            public float UP1 = 0, UP2 = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
            public float PP1 = 0, PP2 = 0, PM1 = 0, PM2 = 0, PQ1 = 0, PQ2 = 0, PB = 0; //ПОЛОЖЕНИЕ, ВВОДИТСЯ ВРУЧНУЮ
            public float Q, PQ; // НАХОЖДЕНИЕ РАВНОДЕЙСТВУЮЩЕЙ НАГРУЗКИ
            public float RA, RB;  // РЕАКЦИИ ОПОР, РАСЧИТЫВАЮТСЯ В ФОРМУЛАХ
            public string otv, rat, rbt; //ОТВЕТ, ВЕКТОР А ВВЕРХ/ВНИЗБ ВЕКТОР В ВВЕРХ/ВНИЗ
            public bool RAS = false, RBS = false; // СТАТУС РЕАКЦИЙ (ЕСЛИ ЛОЖЬ - ВЕКТОР РЕАКЦИИ ВВЕРХ)

            public void Q_raschet()
            {
                if (Q1 == Q2)
                {
                    Q = Q1 * (PQ2 - PQ1); //ДЛЯ ПРЯМОУГОЛЬНОЙ НАГРУЗКИ
                    PQ = PQ1 + (PQ2 - PQ1) / 2; //ТОЧКА ПРИЛОЖЕНИЯ СИЛЫ
                }
                else if (Q1 == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ ВОЗРАСТАЮЩЕЙ НАГРУЗКИ 
                {
                    Q = (PQ2 - PQ1) * Q2 / 2;
                    PQ = PQ1 + 2 * (PQ2 - PQ1) / 3;
                }
                else if (Q2 == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ СПАДАЮЩЕЙ НАГРУЗКИ 
                {
                    Q = (PQ2 - PQ1) * Q1 / 2;
                    PQ = PQ1 + 1 * (PQ2 - PQ1) / 3;
                }
                //else if (Q1 > Q2) //ПРОДОЛЖЕНИЕ ДЛЯ ТРАПЕЦЕВИДНОЙ НАГРУЗКИ
                //{
                //ClassName object = new ClassName();
                //var object = new Classname();
                //object.Q=COnvert.Toint16
                //object.Method1();
                //}
            }
            public void RB_raschet() // РАСЧЕТ ОПОРЫ В
            {
                Q_raschet();
                M1 = -M1;
                RB = (M1 - P1 * PP1 + P2 * PP2 + Q * PQ + M2) / PB; // РАСЧЕТ РЕАКЦИИ А ПУТЕМ НАОЖДЕНИЯ СУММЫ МОМЕНТОВ
              //RB = (10 - 15 * 2 + 15....) / 8
                if (RB < 0)
                {
                    RB = -RB; // ЗНАЧЕНИЕ В ПО МОДУЛЮ
                    RBS = !RBS; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
                }
                //return RB; //ВЫВОД ПОСЧИТАННОЙ РЕАКЦИИ В
            }
            public void RA_raschet() // РАСЧЕТ ОПОРЫ А
            {
                Q_raschet();
                RB_raschet();
                M1 = -M1;
                RA = -P1 + P2 + Q - RB; // РАСЧЕТ РЕАКЦИИ В ПУТЕМ НАХОЖДЕНИЯ СУМЫ ВЕРТИКАЛЬНЫХ СИЛ
                if (RA < 0)
                {
                    RA = -RA; // ЗНАЧЕНИЕ А ПО МОДУЛЮ
                    RAS = !RAS; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
                }
                //return RA; //ВЫВОД ПОСЧИТАНОЙ РЕАКЦИИ А
            }
            public void Vektory()
            {
                RA_raschet();

                if (RBS == true) rbt = "Вектор RB направлен вниз";
                else rbt = "Вектор RB направлен вверх";
                if (RAS == true) rat = "Вектор RA направлен вниз";
                else rat = "Вектор RA направлен вверх";
                otv = "Вертикальная реакция опоры А = " + Math.Round(RA, 2) + ". " + rat + '\n' + "Вертикальная реакция опоры B = " + Math.Round(RB, 2) + ". " + rbt;
                // Запись ответа
                //RAS = false;
                //RBS = false;
            }
        }

        void Niker_data()
        {

        }
        void arrowdrow() // ФУНКЦИЯ РИСОВАНИЯ БАЛКИ И СТРЕЛКИ
        {
            int XAR = 0; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ СТРЕЛКИ СИЛЫ 
            int[] arrow = new int[11]; // МАССИВ ДАННЫХ, ИСПОЛЬЗУЮЩИЙСЯ ДЛЯ ВВОБДА ИНФОРМАЦИИ
            Pen p = new Pen(Color.Red, 5); // СОЗДАЕМ КИСТЬ, СТАВИМ ЦВЕТ
            PointF[] arrowpoints = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СТРЕЛКИ" 
        {
            new PointF(10F +XAR, 10F),
            new PointF(50F+XAR, 50F),
            new PointF(90F+XAR, 10F),
            new PointF(110F+XAR, 10F),
            new PointF(110F+XAR, 60F)
        };
            //Graphics gPanel = panel1.CreateGraphics(); //СОЗДАНИЕ ГРАФИЧЕСКОГО ИНТЕРФЕЙСЯ В ЭЛЕМЕНТЕ ПАНЕЛЬ
            //gPanel.DrawLine(p, new Point(10, 65), new Point(490, 65)); //БАЛКА ДЛИННОЙ В 480 ЕДuНИЦ, ЛИБО В 8 МЕТРОВ В МАСШТАБЕ
            //gPanel.DrawLine(p, new Point(499, 0), new Point(499, 130)); //ПРОВЕРКА ГРАНИЦ РАМКИ
            //gPanel.DrawLine(p, new Point(arrow[4], arrow[5]), new Point(arrow[6], arrow[7])); //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
            //gPanel.DrawLine(p, new Point(arrow[8], arrow[9]), new Point(arrow[10], arrow[11])); //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
            //gPanel.DrawLines(p, arrowpoints); //ПОСТРОЕНИЕ СТРЕЛКИ ОДНОЙ КРИВОЙ
            //Graphics gButton = button2.CreateGraphics(); //МАКРОС ДЛЯ КНОПКИ


            int[] arrow2 = { 10, 0, 10, 20, 10, 20, 5, 15, 10, 20, 15, 15 }; //ИНИЦИАЛИЗАЦИЯ МАССИВА ДАННЫХ ДЛЯ ЛИНИЙ
        }

        void Baka_graphic()
        {

        //float P1X = 2, P2X = 3, Q2X = 6, RBX = 8; // ПАРАМЕТРЫ РАССТОЯНИЙ
        //float RAY = -0.9F, P1Y = 15F, P2Y = -10F, Q1Y = 5F, Q2Y = 5F, RBY = -10.9F;// ПАРАМЕТРЫ СИЛ
        //int[] arrow = new int[11]; // МАССИВ ДАННЫХ, ИСПОЛЬЗУЮЩИЙСЯ ДЛЯ ВВОБДА ИНФОРМАЦИИ
        //Pen beamPen = new Pen(Color.Black, 2); // СОЗДАЕМ КИСТЬ, СТАВИМ ЦВЕТ
        //Pen grafPen = new Pen(Color.Red, 1);  // СОЗДАЕМ КИСТЬ, СТАВИМ ЦВЕТ
        //RAY *= 10; P1Y *= 10; P2Y *= 10; Q1Y *= 10; Q2Y *= 10; RBY *= 10;
        //P1X *= 80; P2X *= 80; Q2X *= 80; RBX *= 80;
        PointF[] grafQDraw = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СТРЕЛКИ" 
    {
            //new PointF(15F, 150F), // отправная 
            //new PointF(15F, 150F + RAY),
            //new PointF(15F + P1X, 150F + RAY),
            //new PointF(15F + P1X, 150F + RAY + P1Y),
            //new PointF(15F + P2X, 150F + RAY + P1Y),
            //new PointF(15F + P2X, 150F + RAY + P1Y + P2Y),
            ////new PointF(15F + Q2X, 150F),
            //new PointF(15F + Q2X, 150F + RBY),
            //new PointF(15F + RBX, 150F + RBY),
            //new PointF(15F + RBX, 150F) // КОНЕЧНАЯ 
        };

        //Graphics gPanel = panel1.CreateGraphics(); //СОЗДАНИЕ ГРАФИЧЕСКОГО ИНТЕРФЕЙСЯ В ЭЛЕМЕНТЕ ПАНЕЛЬ
        //gPanel.DrawRectangle(beamPen, 0, 0, 700, 300); // РАМКА ГРАФИКА
        //gPanel.DrawLine(beamPen, 10, 10, 10, 290); // ВЕРТИКАЛЬ
        //gPanel.DrawLine(beamPen, 10, 150, 690, 150); // ГОРИЗОНТАЛЬ
        //gPanel.DrawLines(grafPen, grafQDraw); // ГРАФИК КЬЮ
        //gPanel.DrawBezier(grafPen, 20F, 20F, 40F, 60F, 60F, 40F, 100F, 100F); // ПРИМЕР КРИВОЙ
        //Graphics gButton = button1.CreateGraphics(); //МАКРОС ДЛЯ КНОПКИ
        ////label1.Text = "lox"; // ПРИСВОЕНИЕ ТЕКСТУ
        ////label1.Location = { }; // ПРИСВОЕНИЕ ЛОКАЦИИ

    }

    private void button1_Click(object sender, EventArgs e)
        {
            Form fff = new Form3();
            fff.Show();
        }

        private void _TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Niker_class_raschet Vivid = new Niker_class_raschet();
            Vivid.P1 = (Convert.ToInt16(TXBX_P1_F.Text));
            Vivid.P2 = (Convert.ToInt16(TXBX_P2_F.Text));
            Vivid.M1 = (Convert.ToInt16(TXBX_M1_F.Text));
            Vivid.M2 = (Convert.ToInt16(TXBX_M2_F.Text));
            Vivid.Q1 = (Convert.ToInt16(TXBX_Q1_F.Text));
            Vivid.Q2 = (Convert.ToInt16(TXBX_Q2_F.Text));

            Vivid.PP1 = (Convert.ToInt16(TXBX_P1_L.Text));
            Vivid.PP2 = (Convert.ToInt16(TXBX_P2_L.Text));
            Vivid.PM1 = (Convert.ToInt16(TXBX_M1_L.Text));
            Vivid.PM2 = (Convert.ToInt16(TXBX_M2_L.Text));
            Vivid.PQ1 = (Convert.ToInt16(TXBX_Q1_L.Text));
            Vivid.PQ2 = (Convert.ToInt16(TXBX_Q2_L.Text));
            Vivid.PB = (Convert.ToInt16(TXBX_B_L.Text));

            Vivid.UP1 = (Convert.ToInt16(TXBX_P1_U.Text));
            Vivid.UP2 = (Convert.ToInt16(TXBX_P2_U.Text));

            Vivid.Vektory();

            MessageBox.Show(Vivid.otv);

        }

    }
}
