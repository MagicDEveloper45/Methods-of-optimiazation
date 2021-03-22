using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class NewtonMethod
    {
        private double uk, ukPlus1;
        public double uRes,jRes;
        private double eps;
        public int k = 0;

        public NewtonMethod(double u0, double eps )
        {
            this.uk = u0;
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

            k = 0;                    
           
            while (Math.Abs(func1(uk)) > eps)            
            {
                ukPlus1 = uk - (func1(uk) / func2(uk));
                k++;
                uk = ukPlus1;
            }

            uRes = uk;
            jRes = func(uRes);         

        }



    }
}
