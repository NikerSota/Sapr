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
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}
        void arrowdrow() // ФУНКЦИЯ РИСОВАНИЯ БАЛКИ И СТРЕЛКИ
        {
            int XAR = 8; XAR *= 80; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ СТРЕЛКИ СИЛЫ
            int MaxL = 650; //МАКСИМАЛЬНАЯ ДЛИНА БАЛКИ
            int MaxF = XAR; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА СТРЕЛКИ СИЛЫ 
            int showF = 15; showF *= 80; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ЗНАЧЕНИЯ СТРЕЛКИ СИЛЫ
            int F = showF; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА ЗНАЧЕНИЯ СТРЕЛКИ СИЛЫ 

            int XAR2 = 2; XAR2 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ВТОРОЙ СТРЕЛКИ СИЛЫ
            int MaxF2 = XAR2; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА ВТОРОЙ СТРЕЛКИ СИЛЫ 
            int showF2 = 12; showF2 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ЗНАЧЕНИЯ ВТОРОЙ СТРЕЛКИ СИЛЫ
            int F2 = showF2; // ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА ЗНАЧЕНИЯ ВТОРОЙ СТРЕЛКИ СИЛЫ


            int XAR3 = 0; XAR3 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ СИЛЫ МОМЕНТА
            int MaxM = XAR3; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА СИЛЫ МОМЕНТА
            int showM = 11; showM *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ЗНАЧЕНИЯ СИЛЫ МОМЕНТА
            int M = showM; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ  РАЗМЕРА ЗНАЧЕНИЯ СИЛЫ МОМЕНТА

            int XAR4 = 6; XAR4 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ  СИЛЫ МОМЕНТА (2)
            int MaxM2 = XAR4; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА СИЛЫ МОМЕНТА (2)
            int showM2 = 17; showM2 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ЗНАЧЕНИЯ  СИЛЫ МОМЕНТА (2)
            int M2 = showM2; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА ЗНАЧЕНИЯ СИЛЫ МОМЕНТА (2)

            int XAR5 = 6; XAR5 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ НАГРУЗКИ 
            int MaxQ = XAR5; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА НАГРУЗКИ
            int showQ = 13; showQ *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ ЗНАЧЕНИЯ НАГРУЗКИ 
            int Q = showQ; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ  РАЗМЕРА ЗНАЧЕНИЯ НАГРУЗКИ


            int XAR6 = 0; XAR6 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ  ОПОРЫ 
            int MaxO = XAR6; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА ОПОРЫ

            int XAR7 = 8; XAR7 *= 80; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ  2 ОПОРЫ 
            int MaxO2 = XAR7; //ПЕРЕМЕННАЯ, ОТВЕЧАЮЩАЯ ЗА ПОЛОЖЕНИЕ РАЗМЕРА 2 ОПОРЫ

            int[] arrow = new int[11]; // МАССИВ ДАННЫХ, ИСПОЛЬЗУЮЩИЙСЯ ДЛЯ ВВОБДА ИНФОРМАЦИИ
            Pen p = new Pen(Color.Red, 1); // СОЗДАЕМ КИСТЬ, СТАВИМ ЦВЕТ
            PointF[] arrowpoints = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СТРЕЛКИ" 
        {
            new PointF(5F+XAR, 60F),
            new PointF(10F+XAR, 65F),
            new PointF(10F+XAR, 5F),
            new PointF(10+XAR, 65F),
            new PointF(15F+XAR, 60F)
        };
            PointF[] arrowpoints2 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "ВТОРОЙ СТРЕЛКИ" 
{
            new PointF(5F+XAR2, 70F),
            new PointF(10F+XAR2, 65F),
            new PointF(10F+XAR2, 110F),
            new PointF(10+XAR2, 65F),
            new PointF(15F+XAR2, 70F)
        };
            PointF[] arrowpoints3 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СИЛЫ МОМЕНТА" 
{
            new PointF(15F+XAR3, 15F),
            new PointF(20F+XAR3, 20F),
            new PointF(15F+XAR3, 25F),
            new PointF(20F+XAR3, 20F),
            new PointF(10F+XAR3, 20F),
            new PointF(10F+XAR3, 95F),
            new PointF(0F+XAR3, 95F),
            new PointF(5F+XAR3, 90F),
            new PointF(0F+XAR3, 95F),
            new PointF(5F+XAR3, 100F)


        };
            PointF[] arrowpoints4 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "СИЛЫ МОМЕНТА(2)" 
{
            new PointF(15F+XAR4, 30F),
            new PointF(20F+XAR4, 35F),
            new PointF(15F+XAR4, 40F),
            new PointF(20F+XAR4, 35F),
            new PointF(10F+XAR4, 35F),
            new PointF(10F+XAR4, 95F),
            new PointF(0F+XAR4, 95F),
            new PointF(5F+XAR4, 90F),
            new PointF(0F+XAR4, 95F),
            new PointF(5F+XAR4, 100F)



        };
            PointF[] arrowpoints5 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "НАГРУЗКИ" 
{
            new PointF(-230F+XAR5, 65F),
            new PointF(-230F+XAR5, 50F),
            new PointF(-210F+XAR5, 50F),
            new PointF(-210F+XAR5, 65F),
            new PointF(-210F+XAR5, 50F),
            new PointF(-190F+XAR5, 50F),
            new PointF(-190F+XAR5, 65F),
            new PointF(-190F+XAR5, 50F),
            new PointF(-170F+XAR5, 50F),
            new PointF(-170F+XAR5, 65F),
            new PointF(-170F+XAR5, 50F),
            new PointF(-150F+XAR5, 50F),
            new PointF(-150F+XAR5, 65F),
            new PointF(-150F+XAR5, 50F),
            new PointF(-130F+XAR5, 50F),
            new PointF(-130F+XAR5, 65F),
            new PointF(-130F+XAR5, 50F),
            new PointF(-110F+XAR5, 50F),
            new PointF(-110F+XAR5, 65F),
            new PointF(-110F+XAR5, 50F),
            new PointF(-90F+XAR5, 50F),
            new PointF(-90F+XAR5, 65F),
            new PointF(-90F+XAR5, 50F),
            new PointF(-70F+XAR5, 50F),
            new PointF(-70F+XAR5, 65F),
            new PointF(-70F+XAR5, 50F),
            new PointF(-50F+XAR5, 50F),
            new PointF(-50F+XAR5, 65F),
            new PointF(-50F+XAR5, 50F),
            new PointF(-30F+XAR5, 50F),
            new PointF(-30F+XAR5, 65F),
            new PointF(-30F+XAR5, 50F),
            new PointF(-10F+XAR5, 50F),
            new PointF(-10F+XAR5, 65F),
            new PointF(-10F+XAR5, 50F),
            new PointF(10F+XAR5, 50F),
            new PointF(10F+XAR5, 65F)


        };

            PointF[] arrowpoints6 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "ОПОРЫ)" 
{
            new PointF(3F+XAR6, 75F),
            new PointF(17F+XAR6, 75F),
            new PointF(20F+XAR6, 75F),
            new PointF(17F+XAR6, 75F),
            new PointF(10F+XAR6, 65F),
            new PointF(3F+XAR6, 75F),
            new PointF(0F+XAR6, 75F),
            new PointF(3F+XAR6, 75F),
            new PointF(4F+XAR6, 80F),
            new PointF(5F+XAR6, 75F),
            new PointF(7F+XAR6, 75F),
            new PointF(6F+XAR6, 80F),
            new PointF(7F+XAR6, 75F),
            new PointF(9F+XAR6, 75F),
            new PointF(8F+XAR6, 80F),
            new PointF(9F+XAR6, 75F),
            new PointF(11F+XAR6, 75F),
            new PointF(10F+XAR6, 80F),
            new PointF(11F+XAR6, 75F),
            new PointF(13F+XAR6, 75F),
            new PointF(12F+XAR6, 80F),
            new PointF(13F+XAR6, 75F),
            new PointF(15F+XAR6, 75F),
            new PointF(14F+XAR6, 80F)


        };

            PointF[] arrowpoints71 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "2 ОПОРЫ" 
{
            new PointF(3F+XAR7, 75F),
            new PointF(17F+XAR7, 75F),
            new PointF(20F+XAR7, 75F),
            new PointF(17F+XAR7, 75F),
            new PointF(10F+XAR7, 65F),
            new PointF(3F+XAR7, 75F),
            new PointF(0F+XAR7, 75F),
            new PointF(3F+XAR7, 75F),



        };

            PointF[] arrowpoints72 = //МАССИВ ДЛЯ ПОСТРОЕНИЯ "2 ОПОРЫ(2)" 
{
            new PointF(20F+XAR7, 77F),
            new PointF(0F+XAR7, 77F),
            new PointF(3F+XAR7, 77F),
            new PointF(4F+XAR7, 82F),
            new PointF(5F+XAR7, 77F),
            new PointF(7F+XAR7, 77F),
            new PointF(6F+XAR7, 82F),
            new PointF(7F+XAR7, 77F),
            new PointF(9F+XAR7, 77F),
            new PointF(8F+XAR7, 82F),
            new PointF(9F+XAR7, 77F),
            new PointF(11F+XAR7, 82F),
            new PointF(10F+XAR7, 82F),
            new PointF(11F+XAR7, 77F),
            new PointF(13F+XAR7, 77F),
            new PointF(12F+XAR7, 82F),
            new PointF(13F+XAR7, 77F),
            new PointF(15F+XAR7, 77F),
            new PointF(14F+XAR7, 82F)



        };

            Graphics gPanel = panel1.CreateGraphics(); //СОЗДАНИЕ ГРАФИЧЕСКОГО ИНТЕРФЕЙСЯ В ЭЛЕМЕНТЕ ПАНЕЛЬ
            gPanel.DrawLine(p = new Pen(Color.Gray, 3), new Point(10, 65), new Point(MaxL, 65)); //БАЛКА ДЛИННОЙ В 650 ЕДuНИЦ, ЛИБО В 8 МЕТРОВ В МАСШТАБЕ
            gPanel.DrawLine(p = new Pen(Color.Gray, 1), new Point(10, 140), new Point(MaxL, 140)); //РАЗМЕРЫ БАЛКИ
            gPanel.DrawLine(p = new Pen(Color.Red, 1), new Point(10, 0), new Point(10 + MaxF, 0)); //РАЗМЕРЫ СТРЕЛКИ СИЛЫ
            gPanel.DrawLine(p = new Pen(Color.Green, 1), new Point(10, 115), new Point(10 + MaxF2, 115)); //РАЗМЕРЫ ВТОРОЙ СТРЕЛКИ СИЛЫ
            gPanel.DrawLine(p = new Pen(Color.Blue, 1), new Point(10, 15), new Point(10 + MaxM, 15)); //РАЗМЕРЫ СИЛЫ МОМЕНТА
            gPanel.DrawLine(p = new Pen(Color.Purple, 1), new Point(10, 30), new Point(10 + MaxM2, 30)); //РАЗМЕРЫ СИЛЫ МОЕНТА (2)
            gPanel.DrawLine(p = new Pen(Color.SaddleBrown, 1), new Point(10, 45), new Point(10 + MaxQ, 45)); //РАЗМЕРЫ НАГРУЗКИ
            //gPanel.DrawLine(p = new Pen(Color.Red,1), new Point(655, 0), new Point(655, 130)); //ПРОВЕРКА ГРАНИЦ РАМКИ
            gPanel.DrawLine(p, new Point(arrow[4], arrow[5]), new Point(arrow[6], arrow[7])); //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
            //gPanel.DrawLine(p, new Point(arrow[8], arrow[9]), new Point(arrow[10], arrow[11]));// //ПОСТРОЕНИЕ ЛИНИИ ПО ДАННЫМ ИЗ МАССИВА
            gPanel.DrawLines(p = new Pen(Color.Red, 3), arrowpoints); //ПОСТРОЕНИЕ СТРЕЛКИ ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Green, 3), arrowpoints2); //ПОСТРОЕНИЕ ВТОРОЙ СТРЕЛКИ ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Blue, 3), arrowpoints3); //ПОСТРОЕНИЕ СИЛЫ МОМЕНТА ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Purple, 3), arrowpoints4); //ПОСТРОЕНИЕ (2)СИЛЫ МОМЕНТА ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.SaddleBrown, 3), arrowpoints5); //ПОСТРОЕНИЕ Q ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Gray, 1), arrowpoints6); //ПОСТРОЕНИЕ ОПОРЫ ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Gray, 1), arrowpoints71); //ПОСТРОЕНИЕ 2 ОПОРЫ ОДНОЙ КРИВОЙ
            gPanel.DrawLines(p = new Pen(Color.Gray, 1), arrowpoints72); //ПОСТРОЕНИЕ 2 ОПОРЫ(2) ОДНОЙ КРИВОЙ
            Graphics gButton = button1.CreateGraphics(); //МАКРОС ДЛЯ КНОПКИ


            int[] arrow2 = { 10, 0, 10, 20, 10, 20, 5, 15, 10, 20, 15, 15 }; //ИНИЦИАЛИЗАЦИЯ МАССИВА ДАННЫХ ДЛЯ ЛИНИЙ
            label1.Text = Convert.ToString(MaxL / 80); //СТОРКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА БАЛКИ
            label1.Location = new System.Drawing.Point(6 + MaxL / 2, 145); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР БАЛКИ
            label1.ForeColor = Color.Gray; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР БАЛКИ

            label2.Text = Convert.ToString(MaxF / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА СТРЕЛКИ СИЛЫ
            label2.Location = new System.Drawing.Point(10 + MaxF / 2, 5); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР СТРЕЛКИ СИЛЫ
            label2.ForeColor = Color.Red; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР СТРЕЛКИ СИЛЫ

            label3.Text = Convert.ToString(MaxF2 / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ВТОРОЙ СТРЕЛКИ СИЛЫ
            label3.Location = new System.Drawing.Point(10 + MaxF2 / 2, 115); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ВТОРОЙ СТРЕЛКИ СИЛЫ
            label3.ForeColor = Color.Green; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ВТОРОЙ СТРЕЛКИ СИЛЫ

            label4.Text = Convert.ToString(MaxM / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА МОМЕНТА СИЛЫ
            label4.Location = new System.Drawing.Point(9 + MaxM / 2, 20); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР МОМЕНТА СИЛЫ
            label4.ForeColor = Color.Blue; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР МОМЕНТА СИЛЫ

            label5.Text = Convert.ToString(MaxM2 / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА МОМЕНТА СИЛЫ (2)
            label5.Location = new System.Drawing.Point(9 + MaxM2 / 2, 35); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР МОМЕНТА СИЛЫ (2)
            label5.ForeColor = Color.Purple; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР МОМЕНТА СИЛЫ (2)

            label6.Text = Convert.ToString(MaxQ / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА НАГРУЗКИ
            label6.Location = new System.Drawing.Point(9 + MaxQ / 2, 42); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР НАГРУЗКИ
            label6.ForeColor = Color.SaddleBrown; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР НАГРУЗКИ

            label7.Text = Convert.ToString(F / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ЗНАЧЕНИЯ СТРЕЛКИ СИЛЫ
            label7.Location = new System.Drawing.Point(33 + MaxF, 5); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ СТРЕЛКИ СИЛЫ
            label7.ForeColor = Color.Red; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ СТРЕЛКИ СИЛЫ

            label8.Text = Convert.ToString(F2 / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ЗНАЧЕНИЯ ВТОРОЙ СТРЕЛКИ СИЛЫ
            label8.Location = new System.Drawing.Point(33 + MaxF2, 115); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ ВТОРОЙ СТРЕЛКИ СИЛЫ
            label8.ForeColor = Color.Green; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ ВТОРОЙ СТРЕЛКИ СИЛЫ

            label9.Text = Convert.ToString(M / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ЗНАЧЕНИЯ МОМЕНТА СИЛЫ
            label9.Location = new System.Drawing.Point(43 + MaxM, 20); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ МОМЕНТА СИЛЫ
            label9.ForeColor = Color.Blue; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ МОМЕНТА СИЛЫ

            label10.Text = Convert.ToString(M2 / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ЗНАЧЕНИЯ МОМЕНТА СИЛЫ (2)
            label10.Location = new System.Drawing.Point(43 + MaxM2, 35); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ МОМЕНТА СИЛЫ (2)
            label10.ForeColor = Color.Purple; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ МОМЕНТА СИЛЫ (2)

            label11.Text = Convert.ToString(Q / 80); //СТРОКА ДЛЯ НАХОЖДЕНИЯ РАЗМЕРА ЗНАЧЕНИЯ НАГРУЗКИ
            label11.Location = new System.Drawing.Point(33 + MaxQ, 55); //КООРДИНАТЫ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ НАГРУЗКИ
            label11.ForeColor = Color.SaddleBrown; //ЦВЕТ ЧИСЛА, КОТОРОЕ ОБОЗНАЧАЕТ РАЗМЕР ЗНАЧЕНИЯ НАГРУЗКИ


            if (label2.Text == label6.Text) label6.Hide(); //КОМАНДА, КОТОРАЯ УДАЛЯЕТ ОДИНАКОВЫЕ РАЗМЕРЫ
            if (label3.Text == label6.Text) label6.Hide(); //КОМАНДА, КОТОРАЯ УДАЛЯЕТ ОДИНАКОВЫЕ РАЗМЕРЫ
            if (label4.Text == label6.Text) label6.Hide(); //КОМАНДА, КОТОРАЯ УДАЛЯЕТ ОДИНАКОВЫЕ РАЗМЕРЫ
            if (label5.Text == label6.Text) label6.Hide(); //КОМАНДА, КОТОРАЯ УДАЛЯЕТ ОДИНАКОВЫЕ РАЗМЕРЫ


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            arrowdrow();
        }
    }
}
