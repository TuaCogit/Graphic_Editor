using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class HermitSpline
    {
        private Point[] ArPoints; //массив точек
        private Color color; //цвет кривой
        public HermitSpline(Point[] pm, Color col)
        {
            ArPoints = new Point[4]; 
            Array.Copy(pm, ArPoints, 4);
            color = col;
        }
        public void drawHermitSpline(Graphics g)
        {
            Pen DrawPen = new Pen(color, 1);
            float Tx1, Tx2, Px1, Px2, Ty1, Ty2, Py1, Py2;
            float x, y, ax, bx, cx, dx, ay, by, cy, dy;
            double t = 0;
            Tx1 = ArPoints[0].X; //х коорд-та нач.т.
            Tx2 = ArPoints[2].X; //х коорд-та кон.т.
            Ty1 = ArPoints[0].Y; //y коорд-та нач.т.
            Ty2 = ArPoints[2].Y; //y коорд-та нач.т.
            Px1 = ArPoints[1].X - ArPoints[0].X; //x коорд-ты касательного вектора в нач.т.
            Px2 = ArPoints[3].X - ArPoints[2].X; //x коорд-ты касательного вектора в кон.т.
            Py1 = ArPoints[1].Y - ArPoints[0].Y; //y коорд-ты касательного вектора в нач.т.
            Py2 = ArPoints[3].Y - ArPoints[2].Y; //y коорд-ты касательного вектора в кон.т.
            //расчет неизвестных коэффициентов полиномов:
            ax = 2 * Tx1 - 2 * Tx2 + Px1 + Px2; 
            ay = 2 * Ty1 - 2 * Ty2 + Py1 + Py2;
            bx = -3 * Tx1 + 3 * Tx2 - 2 * Px1 - Px2;
            by = -3 * Ty1 + 3 * Ty2 - 2 * Py1 - Py2;
            cx = Px1;
            cy = Py1;
            dx = Tx1;
            dy = Ty1;
            //вывод точек кривой с шагом 0.001:
            while (t <= 1)
            {
                x = (float)(ax * (float)Math.Pow(t, 3) + bx * (float)Math.Pow(t, 2) + cx * t + dx);
                y = (float)(ay * (float)Math.Pow(t, 3) + by * (float)Math.Pow(t, 2) + cy * t + dy);
                g.FillRectangle(DrawPen.Brush, x, y, 1, 1);
                t += 0.001;
            }
        }
    }
}
