using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1
{
    public partial class Form1 : Form
    {
        Bitmap btm;
        Graphics g;
        Pen DrawPen = new Pen(Color.Black, 1);
        List<PointF> VertexList1 = new List<PointF>(); //список точек фигуры
        List<Shape> allShape = new List<Shape>(); //список фигур
        List<HermitSpline> allHermit = new List<HermitSpline>(); //список кривых Эрмита
        List<Lines> allLines = new List<Lines>(); //список линий
        Tmo tmo = new Tmo(); //тмо
        private int operation = 1, figure = 1, numBut; 
        private bool checkShape = false; //выбрана ли фигура
        private Point pictureBox1MousePos = new Point(); //положение курсора
        private int countHermit, countShape, countLines, selectShape, countPoints = 0;
        private Point center;
        private Point[] arrPoints = new Point[4]; //массив точек для построения линий
        public Form1()
        {
            InitializeComponent();
            btm = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            g = Graphics.FromImage(btm);
        }

        //обработчик нажатия кнопок
        private void button_Click(object sender, EventArgs e)
        { 
            numBut = Convert.ToInt32((sender as Button).Tag);
            if (numBut <= 4)
            {
                figure = numBut;
                operation = 0;
            }
            else
            {
                figure = 0;
                operation = numBut;
            }
        }
        //обработчик кнопки "Удалить фигуру"
        private void clearFigure_Click(object sender, EventArgs e)
        {
            if (allShape.Count != 0)
            {
                allShape.Remove(allShape[selectShape]);
                selectShape = 0;
                countShape--;
                clearFigure.Enabled = false;
                checkShape = false;
                redraw();
            }
        }
        //обработчик кнопки очистить всё
        private void clear_Click(object sender, EventArgs e)
        {
            allShape.Clear();
            allHermit.Clear();
            allLines.Clear();
            countShape = 0;
            countLines = 0;
            countHermit = 0;
            redraw();
        }
        //обработчик нажатия на pictureBox
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            pictureBox1MousePos = e.Location;
            if (figure != 0)
            {//выбрано построение одного из примитивов
                switch (figure) 
                {
                    case 1: //построение линии
                        arrPoints[countPoints].X = e.X; arrPoints[countPoints].Y = e.Y;
                        g.DrawEllipse(DrawPen, e.X - 2, e.Y - 2, 5, 5);

                        switch (countPoints)
                        {
                            case 0: //первая точка
                                countPoints++; break;
                            case 1: //вторая точка 
                                drawLine(arrPoints[0], arrPoints[1]);
                                countPoints = 0; break;
                            default:
                                drawLine(arrPoints[3], arrPoints[4]);
                                countPoints = 0; // иначе
                                Array.Clear(arrPoints, 0, arrPoints.Length);
                                break;
                        }
                        break;
                    case 2: ermitLine(e); break; //построение кривой Эрмита
                    case 3: drawParall(e); break; //построение параллелограмма
                    case 4: drawArrow(e); break; //построение стрелки 
                }
            }
            // выбрано геометрическое преобразование или тмо
            else if (allShape.Count != 0)
            {//при условии, что есть хотя бы одна фигура 
                switch (operation) 
                {
                    case 5: //тмо - разность двух фигур
                        {
                            redraw();
                            choisShape(e.X, e.Y);
                            if (countPoints == 0 & checkShape) //выбрана первая фигура
                            {
                                indA = selectShape; 
                                countPoints++;
                            }
                            //выбрана вторая фигура != первой
                            if (countPoints == 1 & checkShape & selectShape != indA) 
                            {
                                indB = selectShape;
                                countPoints = 0;
                                tmo.tmOperations(1, allShape[indA].getList(), allShape[indB].getList(), g, DrawPen, pictureBox1.Width, pictureBox1.Height);
                            }
                        }
                        break;
                    case 6: //тмо - симметрическая разность двух фигур
                        {
                            redraw();
                            choisShape(e.X, e.Y);
                            if (countPoints == 0 & checkShape) //выбрана 1 фигура
                            {
                                indA = selectShape;
                                countPoints++;
                            }
                            if (countPoints == 1 & checkShape & selectShape != indA)//выбрана 2 фигура
                            {
                                indB = selectShape;
                                countPoints = 0;
                                tmo.tmOperations(2, allShape[indA].getList(), allShape[indB].getList(), g, DrawPen, pictureBox1.Width, pictureBox1.Height);
                                indtm++;
                            }
                        }
                        break;
                    case 7: //зеркальное отражение относительно центра фигуры
                        {
                            Point centrShape = new Point(); //центр фигуры
                            if (checkShape) //фируга выбрана
                            {
                                switch (allShape[selectShape].getFigure())//определяется вид фигуры
                                {
                                    case 3: //параллелограмм
                                        {
                                            centrShape.X = Convert.ToInt32((allShape[selectShape].getList()[0].X + allShape[selectShape].getList()[2].X) / 2);
                                            centrShape.Y = Convert.ToInt32((allShape[selectShape].getList()[0].Y + allShape[selectShape].getList()[2].Y) / 2);
                                        }
                                        break;
                                    case 4: //стрелка
                                        {
                                            centrShape.X = Convert.ToInt32((allShape[selectShape].getList()[4].X + allShape[selectShape].getList()[9].X) / 2);
                                            centrShape.Y = Convert.ToInt32((allShape[selectShape].getList()[4].Y + allShape[selectShape].getList()[9].Y) / 2);
                                        }
                                        break;
                                    default:
                                        break;
                                }
                                center = centrShape;
                                redraw();
                                countPoints++;
                            }
                            if (countPoints == 1) 
                            {
                                allShape[selectShape].reflectionShape1(centrShape);
                                redraw();
                                countPoints = 0;
                           }
                        }
                        break;
                    case 8: //масштабирование по OX относительно заданного центра
                        {
                            center = new Point(e.X, e.Y);
                            redraw();
                        }
                        break;
                    case 9: //отражение относительно прямой общего положения
                        {
                            arrPoints[countPoints].X = e.X; arrPoints[countPoints].Y = e.Y;
                            g.DrawEllipse(DrawPen, e.X - 2, e.Y - 2, 5, 5);
                            countPoints++;
                            if (countPoints == 2)
                            {
                                float fi = (float)(Math.Atan2(arrPoints[1].Y - arrPoints[0].Y, arrPoints[1].X - arrPoints[0].X));
                                allShape[selectShape].reflectionShape2(arrPoints[0], fi);
                                redraw();
                                g.DrawLine(DrawPen, arrPoints[0], arrPoints[1]);
                                countPoints = 0;
                            }
                        }
                        break;
                    case 10: //выбор фигуры
                        {
                            choisShape(e.X, e.Y);
                            if (checkShape) clearFigure.Enabled = true;
                            redraw();
                        }
                        break;
                    default:
                        break;
                }
            }
            pictureBox1.Image = btm;
        }
        int indA, indB, indtm = 0;
        private void drawLine(Point p1, Point p2) //построение линии
        {
            allLines.Add(new Lines(p1, p2, DrawPen.Color));
            allLines[countLines].drawLine(g);
            countLines++;
        }
        private void ermitLine(MouseEventArgs e) //построение кривой Эрмита
        {
            arrPoints[countPoints].X = e.X; arrPoints[countPoints].Y = e.Y;
            g.DrawEllipse(DrawPen, e.X - 2, e.Y - 2, 5, 5);

            switch (countPoints)
            {
                case 1: //вторая точка
                    {
                        drawLine(arrPoints[0], arrPoints[1]); //касательный вектор в нач. т.
                        countPoints++;
                    }
                    break;
                case 3: // четвертая точка
                    {
                        drawLine(arrPoints[2], arrPoints[3]); //касательный вектор в конеч. т.
                        allHermit.Add(new HermitSpline(arrPoints, DrawPen.Color));
                        Array.Clear(arrPoints, 0, arrPoints.Length);
                        allHermit[countHermit].drawHermitSpline(g);
                        countHermit++;
                        countPoints = 0;
                    }
                    break;
                default:
                    countPoints++;
                    break;
            }
        }
        private void drawParall(MouseEventArgs e) //построение параллелограмма
        {
            int x2, y2;
            double gradus = 45;
            checkHegWid();
            float heg = hegwid[0];
            float wid = hegwid[1];
            //расчет координат 4 вершин
            VertexList1.Add(new Point() { X = e.X, Y = e.Y }); //1
            x2 = (int)(e.X + Math.Tan(gradus * Math.PI / 180) * heg);
            y2 = (int)(e.Y - heg);
            VertexList1.Add(new Point() { X = x2, Y = y2 }); //2
            VertexList1.Add(new Point() { X = (int)(x2 + wid), Y = y2 }); //3
            VertexList1.Add(new Point() { X = (int)(e.X + wid), Y = e.Y }); //4
            // добавление в список фигур
            allShape.Add(new Shape(VertexList1, 3, DrawPen.Color));
            VertexList1.Clear();
            //прорисовка
            allShape[countShape].Fill(g);
            countShape++;
        }
        private void drawArrow(MouseEventArgs e) //построение стрелки
        {
            checkHegWid();
            float heg = hegwid[0];
            float wid = hegwid[1];
            float xx = wid / 4;
            float h = wid - xx * 2;
            float x2, y2, y3, x4;
            //расчет координат 10 точек и помещение их в список точек фигуры
            VertexList1.Add(new PointF(e.X - wid / 2, e.Y)); //1
            x2 = e.X - h / 2; y2 = e.Y - heg;
            VertexList1.Add(new PointF(x2, y2)); //2
            y3 = (e.Y - heg / 2);
            VertexList1.Add(new PointF(x2, y3)); //3
            x4 = (e.X + h / 2);
            VertexList1.Add(new PointF(x4, y3)); //4
            VertexList1.Add(new PointF(x4, y2)); //5
            VertexList1.Add(new PointF((e.X + wid / 2), e.Y));//6
            VertexList1.Add(new PointF(x4, (e.Y + heg)));//7
            VertexList1.Add(new PointF(x4, (e.Y + heg / 2)));//8
            VertexList1.Add(new PointF(x2, (e.Y + heg / 2))); //9
            VertexList1.Add(new PointF(x2, (e.Y + heg))); //10
            //добавление в список фигур
            allShape.Add(new Shape(VertexList1, 4, DrawPen.Color));
            VertexList1.Clear();
            //прорисовка
            allShape[countShape].Fill(g);
            countShape++;
        }
        private float[] hegwid = new float[2];
        private void checkHegWid()
        { 
            try
            {
                //проверка значений высоты
                if (float.Parse(textBox1.Text) < 5 || float.Parse(textBox1.Text) > pictureBox1.Height)
                {
                    MessageBox.Show("Недопустимые размеры", "Внимание");
                    textBox1.Text = "50";
                    hegwid[0] = 50;
                }
                else hegwid[0] = float.Parse(textBox1.Text);
                if(float.Parse(textBox2.Text) < 0 || float.Parse(textBox2.Text) > pictureBox1.Width)
                {
                    MessageBox.Show("Недопустимые размеры", "Внимание");
                    textBox2.Text = "100";
                    hegwid[1] = 100;

                }
                else hegwid[1] = float.Parse(textBox2.Text);
               
            }
            catch (FormatException)
            {
                MessageBox.Show("Введите число", "Внимание");
                textBox1.Text = "50"; textBox2.Text = "100";
            }
            
        }
        private int  Xx, prevX = 0;
        private float coef;
        //обработчик движения мыши
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (operation == 10 & checkShape) //перемещение фигуры
                {
                    allShape[selectShape].moveShape(e.X - pictureBox1MousePos.X, e.Y - pictureBox1MousePos.Y);
                    pictureBox1MousePos = e.Location;
                    redraw();
                }
                if (operation == 8 & selectShape!=0) //масштабирование по OX
                {
                    Xx = e.X;
                    if (prevX < Xx) //движение мыши вправо - увеличение
                    {
                        coef = 1.1f; prevX = Xx;
                    }
                    else if (prevX > Xx) //влево - уменьшение
                    {
                        coef = 0.9f; prevX = Xx;
                    }
                    allShape[selectShape].zoomShapeX(center, coef);
                    redraw();
                }
            }
        }
        private void redraw() // перерисовка
        {
            g.Clear(pictureBox1.BackColor);
            drawRest(selectShape);
            if (allShape.Count != 0)
            {
                allShape[selectShape].Fill(g);
                if (operation > 6 & operation < 9)
                {// прорисовка красного крестика для обозначения центра
                    g.DrawLine(new Pen(Color.Red), center.X, center.Y - 10, center.X, center.Y + 10);
                    g.DrawLine(new Pen(Color.Red), center.X - 10, center.Y, center.X + 10, center.Y);
                }
            }
            pictureBox1.Image = btm;
        }
        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = DrawPen.Color;
            if (colorDialog.ShowDialog() == DialogResult.OK) DrawPen.Color = colorDialog.Color;
        }

        //прорисовка всех примитивов, кроме выбранной фигуры
        private void drawRest(int select)
        {
            int f;
            for (f = 0; f < allHermit.Count; f++) allHermit[f].drawHermitSpline(g);
            for (f = 0; f < allLines.Count; f++) allLines[f].drawLine(g);
            for (f = 0; f < allShape.Count; f++)
            {
                if (f != select)
                {
                    allShape[f].Fill(g);
                }
            }
        }
        private void choisShape(int x, int y) //выбрана ли фигура
        {
            int ind = 0;
            while (ind < allShape.Count)
            {
                if (allShape[ind].ThisPgn(x, y))
                {
                    center = new Point() { X = x, Y = x };
                    selectShape = ind;
                    checkShape = true;
                    return;
                }
                else checkShape = false;
                ind++;
            }
        }
    }
}
