using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace AntGame
{
    public partial class MainForm : Form
    {
        int[,] tor, defaultTor ={{0,1,1,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},  //ТОР 1-яблоко 0-пусто
                                 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {1,1,1,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,1,1,1,1,1,1},
                                 {0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                                 {0,0,0,1,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                                 {0,0,0,1,0,0,0,0,0,0,1,0,1,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                                 {0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                                 {0,0,0,1,1,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,1,1,1,1,1,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,1,0,0,1,1,1,1,0,1,1,1,1,1,1,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
                                 {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0}};

        public MainForm() //Конструтор главной формы
        {
            InitializeComponent();
            tor = (int[,])defaultTor.Clone(); //клонирем тор (нужно для сброса с будущем)
        }

        private void PaintTor(Graphics g) //Функция отрисовки тора
        {
            try
            {
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality; //Отрисовка со зглаживанием
                for (int i = 0; i < 32; i++) //пройтись по всем строкам
                {
                    for (int j = 0; j < 32; j++) //пройтись по всем столбцам
                    {
                        switch (tor[j, i]) 
                        {
                            case 0: //если 0 чистим клетку и рисуем квадрат
                                g.FillRectangle(Brushes.White, 1 + i * 20, 1 + j * 20, 20, 20);
                                g.DrawRectangle(Pens.Black, 1 + i * 20, 1 + j * 20, 20, 20);
                                break;
                            case 1: //если 1 рисуем запоненный квадрат
                                g.FillRectangle(Brushes.Black, 1 + i * 20, 1 + j * 20, 20, 20);
                                break;
                        }
                    }
                }
                Image img = Resource.ant; //изображение муравья
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                g.DrawImage(img, new Point(1 + x * 20, 1 + y * 20));
            }
            catch (Exception) { };
        }

        int x = 0, y = 0; //координаты
        int v = 0; //направление 0 - восток 1 - юг 2 запад 3 север
        int state = 0; //состояние (генетический алгоритм)
        int appleNum = 0; //количество собранных яблок
        Thread thread; //поток в котором вычисляется путь муравья
        bool work = false; //поток работает пока work true (нужно для кнопки сброс)

        private void goButton_Click(object sender, EventArgs e) //нажатие на кнопку вызывает эту функцию
        {
            if (goButton.Text == "Вперед муравей")
            {
                goButton.Enabled = false; //выключение кнопки (во избежание повторных запусков)
                PaintTor(pictureBox1.CreateGraphics()); //перерисовать тор
                thread = new Thread(ThreadFunc); //создаем "поток размышлений муравья"
                work = true; //работает
                thread.Start(); //запускаем поток
                goButton.Text = "Сброс"; //меняем текст кнопки
                goButton.Enabled = true; //включение кнопки
            }
            else
            {
                goButton.Enabled = false; //выключение кнопки (во избежание повторных сбросов)
                work = false; //для остановки потока
                thread.Abort(); //останавливаем поток
                thread.Join(); //ждем завершения работы потока
                tor = (int[,])defaultTor.Clone(); //сбрасываем тор
                appleNum = 1; //сбрасываем количество яблок
                x = 0; //сбрасываем координаты и направление
                y = 0;
                v = 0;
                PaintTor(pictureBox1.CreateGraphics()); //перерисовать тор
                this.Invoke((MethodInvoker)delegate() { labelNum.Text = "Ход: 0"; }); //сбрасываем надписи в окне
                this.Invoke((MethodInvoker)delegate() { labelEat.Text = "Собрано яблок: 0"; }); //сбрасываем надписи в окне
                goButton.Text = "Вперед муравей"; //меняем текст кнопки
                goButton.Enabled = true; //включение кнопки
            }
        }


        private void ThreadFunc() //Функция потока
        {
            try //во избежание ошибок
            {
                tor = (int[,])defaultTor.Clone();  //сбрасываем
                appleNum = 1;
                x = 0;
                y = 0;
                v = 0;
                state = 0;

                for (int i = 0; i < 200 && work; i++)
                {
                    if (tor[y, x] == 1)
                    { //если на клетке которой стоит муравей есть еда то
                        tor[y, x] = 0; //съесть ее
                        appleNum++; //считаем количество яблок
                    }
                    Graphics g = pictureBox1.CreateGraphics(); //нужно для отрисовки
                    g.FillRectangle(Brushes.White, 1 + x * 20, 1 + y * 20, 20, 20); //чистим клетку на которой стоит муравей
                    g.DrawRectangle(Pens.Black, 1 + x * 20, 1 + y * 20, 20, 20);
                    this.Invoke((MethodInvoker)delegate() { labelNum.Text = "Ход: " + (i + 1); }); //обновляем надписи в окне
                    this.Invoke((MethodInvoker)delegate() { labelEat.Text = "Собрано яблок: " + appleNum; });

                    //ГЕНЕТИЧЕСКИЙ АЛГОРИТМ
                    switch (state)
                    {
                        case 0:
                            if (checkEat())
                            {
                                state = 0;
                                go();
                            }
                            else
                            {
                                state = 1;
                                right();
                            }
                            break;
                        case 1:
                            if (checkEat())
                            {
                                state = 12;
                                go();
                            }
                            else
                            {
                                state = 2;
                                right();
                            }
                            break;
                        case 2:
                            if (!checkEat())
                            {
                                state = 3;
                                right();
                            }
                            break;
                        case 3:
                            if (checkEat())
                            {
                                state = 6;
                                go();
                            }
                            else
                            {
                                state = 4;
                                right();
                            }
                            break;
                        case 4:
                            if (checkEat())
                            {
                                state = 5;
                                go();
                            }
                            else
                            {
                                state = 0;
                                go();
                            }
                            break;
                        case 5:
                            if (checkEat())
                            {
                                state = 3;
                                go();
                            }
                            break;
                        case 6:
                            if (checkEat())
                                state = 7;
                            else
                            {
                                state = 4;
                                go();
                            }
                            break;
                        case 7:
                            if (checkEat())
                                state = 9;
                            else
                            {
                                state = 8;
                                go();
                            }
                            break;
                        case 8:
                            if (!checkEat())
                            {
                                state = 3;
                                left();
                            }
                            break;
                        case 9:
                            if (checkEat())
                            {
                                state = 9;
                                go();
                            }
                            else
                            {
                                state = 10;
                                go();
                            }
                            break;
                        case 10:
                            if (checkEat())
                                state = 11;
                            else
                            {
                                state = 11;
                                go();
                            }
                            break;
                        case 11:
                            if (checkEat())
                            {
                                state = 3;
                                go();
                            }
                            else
                                state = 2;
                            break;
                        case 12:
                            if (checkEat())
                            {
                                state = 0;
                                go();
                            }
                            else
                            {
                                state = 7;
                                go();
                            }
                            break;
                    }

                    int sleepTime = 0;
                    this.Invoke((MethodInvoker)delegate() { sleepTime = trackBarSpeed.Value; }); //считываем скорость со слайдера
                    g.FillRectangle(Brushes.White, 1 + x * 20, 1 + y * 20, 20, 20); //отрисовка муровья
                    g.DrawRectangle(Pens.Black, 1 + x * 20, 1 + y * 20, 20, 20);
                    Image img = Resource.ant;
                    switch (v) //направление картинки
                    {
                        case 0:
                            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
                            break;
                        case 1:
                            img.RotateFlip(RotateFlipType.Rotate180FlipNone);
                            break;
                        case 2:
                            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
                            break;
                        case 3:
                            img.RotateFlip(RotateFlipType.RotateNoneFlipNone);
                            break;
                    }
                    g.DrawImage(img, new Point(1 + x * 20, 1 + y * 20));
                    Thread.Sleep(sleepTime);
                }
            }
            catch (Exception) { };
        }

        private bool checkEat() //проверяем наличие яблока перед муравьем
        {
            int cpX = 0, cpY = 0; //координаты перед муравьем 
            switch (v) //в зависимости от направления
            {
                case 0:
                    cpX = x + 1;
                    if (cpX > 31)
                        cpX = 0;
                    cpY = y;
                    break;
                case 1:
                    cpY = y + 1;
                    if (cpY > 31)
                        cpY = 0;
                    cpX = x;
                    break;

                case 2:
                    cpX = x - 1;
                    if (cpX < 0)
                        cpX = 31;
                    cpY = y;
                    break;

                case 3:
                    cpY = y - 1;
                    if (cpY < 0)
                        cpY = 31;
                    cpX = x;
                    break;
            }
            if (tor[cpY, cpX] == 1)
                return true;
            return false;
        }

        private void left() //повернуть налево
        {
            v--;
            if (v < 0)
                v = 3;
        }

        private void right() //повернуть напрво
        {
            v++;
            if (v > 3)
                v = 0;
        }

        private void go() 
        { //идти вперед
            switch (v) //в зависимости от направления
            {
                case 0:
                    x++;
                    if (x > 31)
                        x = 0;
                    break;
                case 1:
                    y++;
                    if (y > 31)
                        y = 0;
                    break;
                case 2:
                    x--;
                    if (x < 0)
                        x = 31;
                    break;
                case 3:
                    y--;
                    if (y < 0)
                        y = 31;
                    break;
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            work = false; //если закрылось окно остановить поток
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            PaintTor(e.Graphics); //перерисовка тора
        }
    }
}
