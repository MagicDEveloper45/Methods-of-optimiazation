using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class HalfDivisionMethod
    {
        private double u1, u2, j1, j2, uRes;
        public double jRes;
        public int counter;
        private double a;
        private double b;
        private double eps;
        private double beta;

        public HalfDivisionMethod(double a, double b, double beta, double eps)
        {
            this.a = a;
            this.b = b;
            this.beta = beta;
            this.eps = eps;           

            while (this.beta >= 0.01)
            {
                this.beta /= 2;
            }             
                 
        }

        double func(double x)
        {
           return Math.Pow(x, 5) - 3 * Math.Pow(x, 3) - 2 * Math.Pow(x, 2) + 4 * x;           
        }
           

        public void method()
        {
            if (a > b || a == b)
            {
                Console.WriteLine("\nError1. Input borders are incorrect");
                return;
            }

            if (beta <= 0)
            {
                Console.WriteLine("\nError1. Input beta is incorrect");
                return;
            }

            if (eps < 0)
            {
                Console.WriteLine("\nError1. Input eps is incorrect");
                return;
            }

            counter = 0;
            do 
            {                
                counter++;
                u1 = (b + a - beta) / 2;
                u2 = (b + a + beta) / 2;

                j1 = func(u1);
                j2 = func(u2);

                if (j1 < j2) b = u2;
                else if (j1 > j2) a = u1;
                else if (j1 == j2)
                {
                    b = u2;
                    a = u1;
                }

            } while (Math.Abs(b - a) >= eps);

            uRes = (b + a) / 2;
            jRes = Math.Abs(func(uRes));
        }
    }
}
