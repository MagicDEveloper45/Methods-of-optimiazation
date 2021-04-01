using System;
using System.Collections.Generic;
using System.Text;

namespace MO_LAB_1
{
    class ParabolaMethod
    {
        public double u1, u2, u3, uRes, jRes;
        public int counter;
        private double w, temp1, temp2, delta = 0.01, a, b ,e;


        public ParabolaMethod( double a, double b, double e)
        {          
            this.a = a;
            this.b = b;
            this.e = e;
        }

        private void convexityСheck()
        {
            do 
            {
                Random rand = new Random();
                int a = Convert.ToInt32(this.a);
                int b = Convert.ToInt32(this.b);

                u1 = rand.Next(a, b+1);

                u2 = rand.Next(a, b+1);

                u3 = rand.Next(a, b+1);


                temp1 = func(u1) - func(u2);
                temp2 = func(u3) - func(u2);

            } while(temp1 >= 0 && temp2 >= 0 && (temp1 + temp2) <= 0);           
        }

        private double func(double x)
        {
            return Math.Pow((3 * Math.Cos(2 * x + 4)), 5);
            //return 3 * Math.Cos(2 * x + 4);
        }

        public void method()
        {
            convexityСheck();                  

            w = u2 + (Math.Pow(u3 - u2, 2) * temp1 - Math.Pow(u2 - u1, 2) * temp2) / (2 * ((u3 - u2) * temp1 + (u2 - u1) * temp2));

            counter = 0;
            
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
                if (func(u2 - delta) < func(u2) && func(u2-delta) < func(u1))
                {
                    u2 -= delta;
                }
            }

            counter++;

            uRes = u2;
            jRes = Math.Abs(func(uRes));
        }

    }
}
