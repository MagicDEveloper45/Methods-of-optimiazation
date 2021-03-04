using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class ParabolaMethod
    {
        public double integral;
        public int counter;
        private double leftBorder;
        private double rightBorder;
        private double eps;

        public ParabolaMethod(double a, double b, double e)
        {
            leftBorder = a;
            rightBorder = b;
            eps = e;
        }

        double func(double x)
        {
            return (3 * Math.Cos(2 * x + 4));
        }


        private double simpsonMethod( int n)
        {
            double h = (rightBorder - leftBorder) / n;
            double k1 = 0, k2 = 0;
            for (int i = 1; i < n; i += 2)
            {
                k1 += func(leftBorder + i * h);
                k2 += func(leftBorder + (i + 1) * h);
            }
            return h / 3 * (func(leftBorder) + 4 * k1 + 2 * k2);
        }

        public void method()
        {
            counter = 1;
            double temp1, temp2;
            int n = 1;

            temp1 = simpsonMethod(n);
            do
            {
                counter++;
                temp2 = temp1;
                n *= 2;
                temp1 = simpsonMethod(n);
            } while (Math.Abs(temp1 - temp2) > eps);

            integral = temp1;
        }

    }
}
