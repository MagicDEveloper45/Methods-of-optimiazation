using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class HalfDivisionMethod
    {
        public double center;
        public int counter;
        private double leftBorder;
        private double rightBorder;
        private double eps;

        public HalfDivisionMethod(double a, double b, double e)
        {
            leftBorder = a;
            rightBorder = b;
            eps = e;
        }

        double func(double x )
        {
            return (3 * Math.Cos(2 * x + 4));
        }

        public void method()
        {
            counter = 1;
            center = (leftBorder + rightBorder) / 2;

            while (Math.Abs(rightBorder - leftBorder) > eps && (func(center) != 0))
            {
                if (func(leftBorder) * func(center) < 0)
                    rightBorder = center;
                else
                    leftBorder = center;
                center = (leftBorder + rightBorder) / 2;
                counter++;
            }
           
        }
    }
}
