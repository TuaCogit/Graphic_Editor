using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace K1
{
    class Tmo
    {
        private List<float> XaL, XaR, XbL, XbR;
        //массивы левых и правых границ сегментов сечения
        // результирующей области строкой Y:
        private List<float> XrL = new List<float>(); 
        private List<float> XrR = new List<float>();
        //левые и правые границы сег-от сеч. фигуры
        private List<float> Xl, Xr;
        private float Ymin, Ymax;
        public void tmOperations(int TMO, List<PointF> A, List<PointF> B, Graphics G, Pen DrawPen, int w, int heg)
        {
            int h = 0, g = 0, n;
            switch (TMO) //определение весов суммы Q(x) соотв-х кодам TMO
            {
                case 1: // А\B
                    h = 2; g = 2;
                    break;
                case 2: //сим.разность
                    h = 1; g = 2;
                    break;
             }
            List<PointF> M = new List<PointF>();
            int i, nM;
            float[] mmiA = minMax(A, heg); //min, max и индекс вершины 1 фигуры
            float[] mmiB = minMax(B, heg); //min, max и индекс вершины 2 фигуры
            Ymin = Math.Min(mmiA[0], mmiB[0]); //(минимумы фигур)
            Ymax = Math.Max(mmiA[1], mmiB[1]); //(максимумы фигур)
            int Xemin = 0; //левая граница области вывода
            int Xemax = w; //правая грница обл. вывода
            for (float Y = Ymin; Y < Ymax; Y++)
            {
                XrR.Clear();
                XrL.Clear();
                M.Clear();
                XaL = border(A, Y, mmiA[2], G)[0]; //левые границы сегментов сечения 1 фигуры 
                XaR = border(A, Y, mmiA[2], G)[1]; //правые границы сег-ов сеч. 1 фигуры
                XbL = border(B, Y, mmiB[2], G)[0]; //левые границы сег-ов сеч. 2 фигуры
                XbR = border(B, Y, mmiB[2], G)[1]; //правые границы сег-ов сеч. 2 фигуры
                n = XaL.Count();
                for (i = 0; i < n; i++) M.Add(new PointF(XaL[i], 2));
                nM = n; n = XaR.Count();
                for (i = 0; i < n; i++) M.Add(new PointF(XaR[i], -2));
                nM = nM + n; n = XbL.Count();
                for (i = 0; i < n; i++) M.Add(new PointF(XbL[i], 1));
                nM = nM + n; n = XbR.Count();
                for (i = 0; i < n; i++) M.Add(new PointF(XbR[i], -1));
                nM = nM + n; //общ. число эл-тов в массиве М
                M.Sort((x1, x2) => x1.X.CompareTo(x2.X)); //сортировка по возрастанию M[i].x
                int k = 0, m = 0; float Q = 0;
                if (M.Count() != 0)
                {
                    if (M[0].X >= Xemin && M[0].Y < 0)
                    {
                        XrL.Add(Xemin); Q = 0 - (M[0].Y);
                        k = 1;
                    }
                    for (i = 0; i < nM; i++)
                    {
                        float x = M[i].X; float Qnew = Q + M[i].Y;
                        if (!(Q >= h && Q <= g) && (Qnew >= h && Qnew <= g)) { XrL.Add(x); k++; }
                        else if ((Q >= h && Q <= g) && !(Qnew >= h && Qnew <= g)) XrR.Add(x); m++;
                        Q = Qnew;
                    }
                    if (Q >= h && Q <= g) XrR.Add(Xemax);
                    for ( i = 0; i < XrL.Count; i++)
                    {
                        if (XrL[i] < XrR[i]) G.DrawLine(new Pen(Color.DarkTurquoise), XrL[i], Y, XrR[i], Y);
                        if (XrL[i] > XrR[i])G.DrawLine(new Pen(Color.Turquoise), XrR[i], Y, XrL[i], Y);
                        
                    }
                }
            }
        }
       
        
        private float[] minMax(List<PointF> AB, int heg) //min, max и индекс наивысш. вершины фигуры
        {
            float[] mmi = new float[3];
            int Yemax = heg;
            int i = 0, n = AB.Count;
            float Ymin = AB[0].Y, Ymax = AB[0].Y;
            for (i = 1; i < n; i++)
            {
                if (AB[i].Y < Ymin)Ymin = AB[i].Y;
                if (AB[i].Y > Ymax)
                {
                    Ymax = AB[i].Y;
                    mmi[2] = i; //индекс наивысшей вершины
                }
            }
            mmi[0] = Math.Max(Ymin, 0); //min
            mmi[1] = Math.Min(Ymax, Yemax); //max
            return mmi;
        }

        public List<float>[] border(List<PointF> point, float Y, float m, Graphics G)//границы сег-ов сеч. фигуры
        {
            List<float>[] mas = new List<float>[2];
            Xl = new List<float>(); //левые
            Xr = new List<float>(); //правые
            float X;
            int j = Convert.ToInt32(m);
            int k, a1 = 0, a2 = 1; ;
            int n = point.Count();
            bool cw = false;
            if (j == 0) a1 = n - 1;
            else a1 = j - 1;
            if (j >= n - 1) a2 = 0;
            else a2 = j + 1;
            if (point[a2].X < point[a1].X) cw = true; //ориентация - по часовой
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1) k = i + 1;
                else k = 0;
                if (((point[i].Y < Y) && (point[k].Y >= Y)) || ((point[i].Y >= Y) && (point[k].Y < Y)))
                {
                    //к-та х точки пересечения строки со стороной:
                    X = point[i].X + ((Y - point[i].Y) * (point[k].X - point[i].X) / (point[k].Y - point[i].Y));
                    if (cw) //по часовой
                    {
                        if (point[k].Y - point[i].Y > 0) Xr.Add(X);
                        else Xl.Add(X);
                    }
                    else //против часовой
                    {
                        if (point[k].Y - point[i].Y < 0) Xr.Add(X);
                        else Xl.Add(X);
                    }
                }  
            }
            mas[0] = Xl;
            mas[1] = Xr;
            return mas;
        }
    }
}
