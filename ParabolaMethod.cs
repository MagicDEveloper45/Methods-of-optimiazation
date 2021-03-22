using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class ParabolaMethod
    {
        public double u1, u2, u3;


        public ParabolaMethod(double u1, double u2, double u3)
        {
            this.u1 = u1;
            this.u2 = u2;
            this.u3 = u3;
        }

        private bool convexityСheck()
        {
            double temp1 = func(u1) - func(u2);
            double temp2 = func(u3) - func(u2);

            return temp1 >= 0 && temp2 >= 0 && (temp1 + temp2) > 0;
        }

        private double func(double x)
        {
            return 3 * Math.Cos(2 * x + 4);
        }

        public void method()
        {
            if (convexityСheck() == false)
            {
                Console.WriteLine("Error2. The triple of points is not convex for the function");
                return;
            }




        }

    }
}
