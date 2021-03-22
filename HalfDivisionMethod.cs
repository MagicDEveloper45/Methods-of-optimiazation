﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class HalfDivisionMethod
    {
        private double u1, u2, j1, j2, uRes;
        public double jRes;
        public int n;
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

            while (this.beta > 1)
            {
                this.beta /= 2;
            }              
                 
        }

        double func(double x )
        {
            return (3 * Math.Cos(2 * x + 4));
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

            n = 0;
            do 
            {
                n++;
                u1 = (b + a - beta) / 2;
                u2 = (b + a + beta) / 2;

                j1 = func(u1);
                j2 = func(u2);

                if (j1 < j2) b = u2;
                if (j1 > j2) a = u1;
                if (j1 == j2) b = u2;

            } while (Math.Abs(b - a) >= eps);

            uRes = (b + a) / 2;
            jRes = func(uRes);

        }
    }
}
