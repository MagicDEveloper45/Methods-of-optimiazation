using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class ParabolaMethod
    {
        public double u1, u2, u3, uRes, jRes;
        public int counter;
        private double w, temp1, temp2, delta = 0.01, eps;


        public ParabolaMethod( double u1, double u2, double u3, double eps)
        {          
            this.u1 = u1;
            this.u2 = u2;
            this.u3 = u3;
            this.eps = eps;
        }        

        private double func(double x)
        {
            return Math.Pow(x, 5) - 3 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 4 * x;
        }

        public void method()
        {                           

            w = u2 + (Math.Pow(u3 - u2, 2) * temp1 - Math.Pow(u2 - u1, 2) * temp2) / (2 * ((u3 - u2) * temp1 + (u2 - u1) * temp2));
            double Iu1 = func(u1), Iu2 = func(u2), Iu3 = func(u3);


            while (delta > eps)
            {
                counter++;
                double Iw = func(w);
                if (w < u2)
                {
                    if (Iw < Iu2) 
                    { 
                        u3 = u2;
                        u2 = w;
                        Iu3 = Iu2;
                        Iu2 = Iw;
                    }
                    else if (Iw > Iu2) 
                    { 
                        u1 = w;
                        Iu1 = Iw;
                    }
                    else if (Iu1 > Iu2)
                    {
                        u3 = u2;
                        u2 = w;
                        Iu3 = Iu2;
                        Iu2 = Iw;                        
                    }
                    else if (Iu2 > Iu3) { u1 = w; Iu1 = Iw; }
                }
                else if (w > u2)
                {
                    if (Iw < Iu2)
                    { 
                        u1 = u2;
                        u2 = w;
                        Iu1 = Iu2;
                        Iu2 = Iw;
                    }
                    else if (Iw > Iu2)
                    {
                        u3 = w;
                        Iu3 = Iw;
                    }
                    else if (Iu3 > Iu2)
                    {
                        u1 = u2;
                        u2 = w;
                        Iu1 = Iu2;
                        Iu2 = Iw;                        
                    }
                    else if (Iu1 > Iu2) 
                    { 
                        u3 = w;
                        Iu3 = Iw;
                    }
                    else if (Math.Abs(w - u2) < 0.01)
                    {
                        if ((Iu2 < func(u2 + delta)) && (Iu2 < func(u2 -delta)))
                        { 
                            delta -= eps;
                        }
                        else if (func(u2 - delta) < Iu2) 
                        {
                            u2 -= delta;
                        }
                        else if (func(u2 + delta) < Iu2)
                        {
                            u2 += delta;
                        }
                    }
                }
                if (Math.Abs(u2 - u3) < eps)
                {                    
                    uRes = u2;
                    jRes = Math.Abs(func(uRes));
                    return;
                }
            }
            uRes = u2;
            jRes = Math.Abs(func(uRes));
        }

        /*counter = 0;             

        if (w < u2)
        {
            if (func(w) < func(u2))
            {
                u2 = w;
                u3 = u2;
            }
            else if (func(w) > func(u2))
            {
                u1 = w;
            }
            else if (func(w) == func(u2))
            {
                if (func(u1) > func(u2))
                {
                    u2 = w;
                    u3 = u2;
                }
                else if (func(u2) > func(u3))
                {
                    u1 = w;
                }
            }
        }

        if (w > u2)
        {
            if (func(w) < func(u2))
            {
                u1 = u2;
                u2 = w;
            }
            else if (func(w) > func(u2))
            {
                u3 = w;
            }
            else if (func(w) == func(u2))
            {
                if (func(u3) > func(u2))
                {
                    u1 = u2;
                    u2 = w;
                }
                else if (func(u1) > func(u2))
                {
                    u3 = w;
                }
            }
        }

        if (w == u2)
        {
            if (func(u2 - delta) < func(u2) && func(u2-delta) < func(u1))
            {
                u2 -= delta;
            }
        }

        counter++;*/

        

    }
}
