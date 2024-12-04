using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class Lines
    {
        private Point[] arPoints; //массив точек линии
        private Color color; //цвет линии
        public Lines(Point p1, Point p2, Color col) //конструктор
        {
            arPoints = new Point[2];
            arPoints[0] = p1;
            arPoints[1] = p2;
            color = col;
        }
        public void drawLine(Graphics g) //прорисовка линии
        {
            Pen DrawPen = new Pen(color, 1);
            g.DrawLine(DrawPen, arPoints[0], arPoints[1]);
        }

    }
}
