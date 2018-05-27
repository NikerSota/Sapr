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

        public string otvet="aersg";
        Niker_class_raschet Vivid = new Niker_class_raschet();
        class Niker_class_raschet
        {

            public double P1_F = 0, P2_F = 0, M1_F = 0, M2_F = 0, Q1_F = 0, Q2_F = 0; // ВЕЛЕЧИНЫ. ВВОДЯТСЯ ВРУЧНУЮ В ФОРМЕ
            public double P1_U = 0, P2_U = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
            public double P1_X = 0, P1_Y = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
            public double P2_X = 0, P2_Y = 0; //УГОЛ, ВВОДИТСЯ ВРУЧНУЮ
            public double P1_L = 0, P2_L = 0, M1_L = 0, M2_L = 0, Q1_L = 0, Q2_L = 0, B_L = 0; //ПОЛОЖЕНИЕ, ВВОДИТСЯ ВРУЧНУЮ
            public double Q_F, Q_L; // НАХОЖДЕНИЕ РАВНОДЕЙСТВУЮЩЕЙ НАГРУЗКИ
            public double VA, VB;  // РЕАКЦИИ ОПОР, РАСЧИТЫВАЮТСЯ В ФОРМУЛАХ
            public string otv="asf", VA_S_V, VB_S_V; //ОТВЕТ, ВЕКТОР А ВВЕРХ/ВНИЗБ ВЕКТОР В ВВЕРХ/ВНИЗ
            public bool VA_Z = false, VB_Z = false; // СТАТУС РЕАКЦИЙ (ЕСЛИ ЛОЖЬ - ВЕКТОР РЕАКЦИИ ВВЕРХ)
            
            public void P_raschet()
            {
                if (P1_U >= 0 && P1_U <= 90)
                {
                    P1_X = Math.Sin(P1_U * Math.PI / 180)*P1_F; //ЕСЛИ В ПРЕДЕЛАХ 90 ГРАДУСОВ, 
                    P1_Y = Math.Cos(P1_U * Math.PI / 180) * P1_F;
                }
                else if (P1_U >= 180 && P1_U <= 270)
                {
                    P1_X = Math.Sin(P1_U * Math.PI / 180) * P1_F;
                    P1_Y = Math.Cos(P1_U * Math.PI / 180) * P1_F;
                }
                else if (P1_U >= 90 && P1_U <= 180)
                {
                    P1_X = Math.Cos(P1_U * Math.PI / 180) * P1_F;
                    P1_Y = Math.Sin(P1_U * Math.PI / 180) * P1_F;
                }
                else if (P1_U >= 270 && P1_U <= 360)
                {
                    P1_X = Math.Cos(P1_U * Math.PI / 180) * P1_F;
                    P1_Y = Math.Sin(P1_U * Math.PI / 180) * P1_F;
                }



                if (P2_U >= 0 && P2_U <= 90)
                {
                    P2_X = Math.Sin(P2_U * Math.PI / 180) * P2_F;
                    P2_Y = Math.Cos(P2_U * Math.PI / 180) * P2_F;
                }
                else if (P2_U >= 180 && P2_U <= 270)
                {
                    P2_X = Math.Cos(P2_U * Math.PI / 180) * P2_F;
                    P2_Y = Math.Sin(P2_U * Math.PI / 180) * P2_F;
                }
                else if (P2_U >= 90 && P2_U <= 180)
                {
                    P2_X = Math.Sin(P2_U * Math.PI / 180) * P2_F;
                    P2_Y = Math.Cos(P2_U * Math.PI / 180) * P2_F;
                }
                else if (P2_U >= 270 && P2_U <= 360)
                {
                    P2_X = Math.Cos(P2_U * Math.PI / 180) * P2_F;
                    P2_Y = Math.Sin(P2_U * Math.PI / 180) * P2_F;
                }
            }
            public void Q_raschet()
            {
                if (Q1_F == Q2_F)
                {
                    Q_F = Q1_F * (Q2_L - Q1_L); //ДЛЯ ПРЯМОУГОЛЬНОЙ НАГРУЗКИ
                    Q_L = Q1_L + (Q2_L - Q1_L) / 2; //ТОЧКА ПРИЛОЖЕНИЯ СИЛЫ
                }
                else if (Q1_F == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ ВОЗРАСТАЮЩЕЙ НАГРУЗКИ 
                {
                    Q_F = (Q2_L - Q1_L) * Q2_F / 2;
                    Q_L = Q1_L + 2 * (Q2_L - Q1_L) / 3;
                }
                else if (Q2_F == 0) // ДЛЯ ПРЯМО-ТРЕУГОЛЬНОЙ СПАДАЮЩЕЙ НАГРУЗКИ 
                {
                    Q_F = (Q2_L - Q1_L) * Q1_F / 2;
                    Q_L = Q1_L + 1 * (Q2_L - Q1_L) / 3;
                }
                //else if (Q1 > Q2) //ПРОДОЛЖЕНИЕ ДЛЯ ТРАПЕЦЕВИДНОЙ НАГРУЗКИ
                //{
                //ClassName object = new ClassName();
                //var object = new Classname();
                //object.Q=COnvert.Toint16
                //object.Method1();
                //}
            }
            public void VB_raschet() // РАСЧЕТ ОПОРЫ В
            {
                Q_raschet();
                P_raschet();
                M1_F = -M1_F;
                VB = (M1_F + P1_Y * P1_L + P2_Y * P2_L + Q_F * Q_L + M2_F) / B_L; // РАСЧЕТ РЕАКЦИИ А ПУТЕМ НАОЖДЕНИЯ СУММЫ МОМЕНТОВ
                                                                                  //VB = (10 - 15 * 2 + 15....) / 8
                if (VB < 0)
                {
                    VB = -VB; // ЗНАЧЕНИЕ В ПО МОДУЛЮ
                    VB_Z = !VB_Z; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
                }
                //return VB; //ВЫВОД ПОСЧИТАННОЙ РЕАКЦИИ В
            }
            public void VA_raschet() // РАСЧЕТ ОПОРЫ А
            {
                VB_raschet();
                M1_F = -M1_F;
                VA = P1_Y + P2_Y + Q_F - VB; // РАСЧЕТ РЕАКЦИИ В ПУТЕМ НАХОЖДЕНИЯ СУМЫ ВЕРТИКАЛЬНЫХ СИЛ
                if (VA < 0)
                {
                    VA = -VA; // ЗНАЧЕНИЕ А ПО МОДУЛЮ
                    VA_Z = !VA_Z; // ПОМЕНЯТЬ НАПРАВЛЕНИЕ ВЕКТОРА
                }
                //return VA; //ВЫВОД ПОСЧИТАНОЙ РЕАКЦИИ А
            }
            public string Vektory()
            {
                VA_raschet();

                if (VB_Z == true) VB_S_V = "Вектор VB направлен вниз";
                else VB_S_V = "Вектор VB направлен вверх";
                if (VA_Z == true) VA_S_V = "Вектор VA направлен вниз";
                else VA_S_V = "Вектор VA направлен вверх";
                otv = "Вертикальная реакция опоры А = " + Math.Round(VA, 2) + ". " + VA_S_V + '\n' + "Вертикальная реакция опоры B = " + Math.Round(VB, 2) + ". " + VB_S_V;
                // Запись ответа
                //RAS = false;
                //RBS = false;
                return otv;
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

        private void button2_Click(object sender, EventArgs e)
        {
            
            Vivid.P1_F = (Convert.ToInt16(TXBX_P1_F.Text));
            Vivid.P2_F = (Convert.ToInt16(TXBX_P2_F.Text));
            Vivid.M1_F = (Convert.ToInt16(TXBX_M1_F.Text));
            Vivid.M2_F = (Convert.ToInt16(TXBX_M2_F.Text));
            Vivid.Q1_F = (Convert.ToInt16(TXBX_Q1_F.Text));
            Vivid.Q2_F = (Convert.ToInt16(TXBX_Q2_F.Text));

            Vivid.P1_L = (Convert.ToInt16(TXBX_P1_L.Text));
            Vivid.P2_L = (Convert.ToInt16(TXBX_P2_L.Text));
            Vivid.M1_L = (Convert.ToInt16(TXBX_M1_L.Text));
            Vivid.M2_L = (Convert.ToInt16(TXBX_M2_L.Text));
            Vivid.Q1_L = (Convert.ToInt16(TXBX_Q1_L.Text));
            Vivid.Q2_L = (Convert.ToInt16(TXBX_Q2_L.Text));
            Vivid.B_L = (Convert.ToInt16(TXBX_B_L.Text));

            Vivid.P1_U = (Convert.ToInt16(TXBX_P1_U.Text));
            Vivid.P2_U = (Convert.ToInt16(TXBX_P2_U.Text));
            Form5 f5 = new Form5();


            f5.otvet = this.Vivid.Vektory();
            f5.Show();
        }
    }
}
