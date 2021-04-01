using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class GoldenRatioMethod
    {        
        private double u1, u2, j1, j2, uRes;
        public double jRes;
        public int counter;
        private double a;
        private double b;
        private double eps;      
       
        private readonly double alpha = (Math.Sqrt(5) - 1) / 2; // 0.6180339887498949
        private readonly double alpha1 = (3 - Math.Sqrt(5)) / 2; // 0.3819660112501051

        public GoldenRatioMethod(double a, double b, double eps)
        {
            this.a = a;
            this.b = b;
            this.eps = eps;        
        }

        double func(double x)
        {
            return (3 * Math.Cos(2 * x + 4));
            // return Math.Pow(x, 3) + 8 * Math.Pow(x, 2) - 3 * x + 3;
        }

        public void method()
        {
            if (a > b || a == b)
            {
                Console.WriteLine("\n Error1. Input borders are incorrect");
                return;
            }

            if (eps < 0)
            {
                Console.WriteLine("\n Error1. Input eps is incorrect");
                return;
            }



            counter = 0;
            u1 = a + alpha1 * (b - a);
            u2 = a = alpha1 * (b - a);
            do
            {
                counter++;
                j1 = func(u1);
                j2 = func(u2);

                if (j1 < j2)
                {
                    b = u2;
                    u2 = u1;
                    j2 = j1;
                    u1 = a + alpha1 * (b - a);
                    j1 = func(u1);
                }
                else
                if (j1 > j2)
                {
                    a = u1;
                    u1 = u2;
                    j1 = j2;
                    u2 = a + alpha * (b - a);
                    j2 = func(u2);
                }
                else
                if (j1 == j2)
                {
                    b = u2;
                    a = u1;
                    u1 = a + alpha1 * (b - a);
                    u2 = a + alpha * (b - a);
                    j1 = func(u1);
                    j2 = func(u2);
                }

            } while (Math.Abs(b - a) >= eps);

            uRes = (b + a) / 2;
            jRes = Math.Abs(func(uRes));
        }

    }
}
