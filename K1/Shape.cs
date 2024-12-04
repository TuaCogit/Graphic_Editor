using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace K1
{
    class Shape
    {
        private List<PointF> VertexList;  //список вершин фигуры
        private int figure; //тип фигуры
        private Color color; //цвет фигуры

        public Shape()
        { VertexList = new List<PointF>(); }
        public Shape(List<PointF> t, int f, Color col)
        {
            VertexList = new List<PointF>(t);
            figure = f;
            color = col;
        }
        //метод добавления вершин
        public void Add(Point NewVertex, Color col)
        {
            VertexList.Add(NewVertex);
            color = col;
        }
        public List<PointF> getList() //возвращает список вершин фигуры
        {
            return VertexList;
        }
        public int getFigure() //возвращает тип фигуры
        {
            return figure;
        }
        // метод Вывод закрашенного многоугольника
        public void Fill(Graphics g)
        {
            Pen DrawPen = new Pen(color, 1);
            Brush DrawBrush = new SolidBrush(DrawPen.Color);
            int n = VertexList.Count() - 1;
           
            Point[] PgVertex = new Point[VertexList.Count()]; // массив вершин
            for (int i = 0; i <= n; i++)
            {
                PgVertex[i].X = (int)Math.Round(VertexList[i].X);
                PgVertex[i].Y = (int)Math.Round(VertexList[i].Y);
            }
            g.FillPolygon(DrawBrush, PgVertex);
        }

        // выделение многоугольника
        public bool ThisPgn(int mX, int mY)
        {
            List<Point> PointL = new List<Point>();
            Point P1;
            P1 = new Point();
            int n = VertexList.Count() - 1, k = 0;
            int Y = mY, X;
            double x;
            List<int> Xb = new List<int>(); // буфер сегментов
            bool check = false;
            for (int i = 0; i <= n; i++)
            {
                P1.X = (int)Math.Round(VertexList[i].X);
                P1.Y = (int)Math.Round(VertexList[i].Y);
                PointL.Add(P1);
            }
            Xb.Clear();
            for (int i = 0; i <= n; i++)
            {
                if (i < n) k = i + 1; else k = 0;
                if ((PointL[i].Y < Y) & (PointL[k].Y >= Y) | (PointL[i].Y >= Y) & (PointL[k].Y < Y))
                {
                    x = (Y - PointL[i].Y) * (PointL[k].X - PointL[i].X) / (PointL[k].Y - PointL[i].Y) + PointL[i].X;
                    X = (int)Math.Round(x);
                    Xb.Add(X);
                }
            }
            if (Xb.Count() > 0)
            {
                Xb.Sort();  // по умолчанию по возрастанию
                for (int i = 0; i < Xb.Count; i = i + 2)
                {
                    if (mX >= Xb[i] & mX <= Xb[i + 1]) { check = true; break; }
                }
            }
            PointL.Clear();
            return check;
        }
        // плоско-параллельное перемещение
        public void moveShape(int dx, int dy)
        {
            PointF fP = new PointF();
            for (int i = 0; i < VertexList.Count(); i++)
            {
                fP.X = VertexList[i].X + dx;
                fP.Y = VertexList[i].Y + dy;
                VertexList[i] = fP;
            }
        }
        //отражение относительно центра фигуры
        public void reflectionShape1(Point centr)
        {
            PointF fP = new Point();
            for (int i = 0; i < VertexList.Count(); i++)
            {
                fP.X = (VertexList[i].X - centr.X) * (-1) + centr.X;
                fP.Y = (VertexList[i].Y - centr.Y) * (-1) + centr.Y;
                VertexList[i] = fP;
            }
        }
        //отражение относительно прямой общего положения
        public void reflectionShape2(Point centr, double fi)
        {
            PointF fP = new PointF();
            for (int i = 0; i < VertexList.Count(); i++)
            {
                fP.X = (float)((VertexList[i].X - centr.X) * Math.Cos(2 * fi) + (VertexList[i].Y - centr.Y) * Math.Sin(2 * fi) + centr.X);
                fP.Y = (float)((VertexList[i].X - centr.X) * Math.Sin(2 * fi) - (VertexList[i].Y - centr.Y) * Math.Cos(2 * fi) + centr.Y);
                VertexList[i] = fP;
            }
        }

        //масштабирование по оси Х относительно заданного центра
        public void zoomShapeX(Point center, float coef)
        {
            PointF fP = new PointF();
            for (int i = 0; i < VertexList.Count(); i++)
            {
                fP.X = (VertexList[i].X - center.X) * coef + center.X;
                fP.Y = VertexList[i].Y;
                VertexList[i] = fP;
            }
        }
        public void Clear()
        { VertexList.Clear(); }
        
    }
}