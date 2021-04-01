using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class NewtonMethod
    {
        private double a, b, uk, ukPlus1, j1, j2;
        public double uRes,jRes;
        private double eps;
        public int counter = 0;

        private readonly double alpha = (Math.Sqrt(5) - 1) / 2; // 0.6180339887498949
        private readonly double alpha1 = (3 - Math.Sqrt(5)) / 2; // 0.3819660112501051


        public NewtonMethod(double a, double b, double eps )
        {
            this.a = a;
            this.b = b;
            this.eps = eps;
        }

        private double func(double x)
        {
            return 3 * Math.Cos(2 * x + 4);
        }

        private double func1(double x)
        {
            return -6 * Math.Sin(2 * x + 4);
        }

        private double func2(double x)
        {
            return -12 * Math.Cos(2 * x + 4);
        }

        public void method()
        {
            if (eps <= 0)
            {
                Console.WriteLine("\n Error1. Input eps is incorrect");
                return;
            }

            counter = 0;


            counter = 0;
            double u1 = a + alpha1 * (b - a);
            double u2 = a = alpha1 * (b - a);
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

            while (Math.Abs(func1(uk)) > eps)            
            {
                ukPlus1 = uk - (func1(uRes) / func2(uRes));
                counter++;
                uk = ukPlus1;
            }

            uRes = uk;
            jRes = Math.Abs(func(uRes));         

        }



    }
}
