using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class GoldenRatioMethod
    {
        public int counter;
        public double leftBorder;
        public double rightBorder;
        public double eps;        
        public double xmin;
        public double resultF;

        private readonly double t = (Math.Sqrt(5) - 1) / 2; // 0,61803399    

        public GoldenRatioMethod(double a, double b, double e)
        {
            leftBorder = a;
            rightBorder = b;
            eps = e;           
        }

        double func(double x)
        {
            return (3 * Math.Cos(2 * x + 4));
            // return Math.Pow(x, 3) + 8 * Math.Pow(x, 2) - 3 * x + 3;
        }
      
        public void method()
        {
            double x1 = rightBorder - t * (rightBorder - leftBorder);
            double x2 = leftBorder + t * (rightBorder - leftBorder);

            counter = 1;
            while (eps <= Math.Abs(rightBorder - leftBorder))
            {                
                if (func(x2) < func(x1))
                    leftBorder = x1;
                else
                    rightBorder = x2;
                x1 = rightBorder - t * (rightBorder - leftBorder);
                x2 = leftBorder + t * (rightBorder - leftBorder);

                counter++;
            }
            xmin = (leftBorder + rightBorder) * 0.5;
            resultF = func(xmin);
        }

    }
}
