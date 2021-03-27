﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class ParabolaMethod
    {
        public double u1, u2, u3;
        private double w, temp1, temp2, delta = 0.01;


        public ParabolaMethod(double u1, double u2, double u3)
        {
            this.u1 = u1;
            this.u2 = u2;
            this.u3 = u3;
        }

        private bool convexityСheck()
        {
            temp1 = func(u1) - func(u2);
            temp2 = func(u3) - func(u2);

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

            w = u2 + (Math.Pow(u3 - u2, 2) * temp1 - Math.Pow(u2 - u1, 2) * temp2) / (2 * ((u3 - u2) * temp1 + (u2 - u1) * temp2));

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

            }




        }

    }
}
