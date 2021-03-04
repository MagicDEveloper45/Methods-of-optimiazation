using System;

namespace MO_LAB_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Сhoose the method: ");
            Console.WriteLine(" 1.The Half - division Method " +
                         "\n 2.The Golden ratio Method " +
                         "\n 3.The parabola Method " +
                         "\n 4.The Newton's method" +
                         "\n 5.Show result ");
            Console.Write(" \n input:  ");
            int choose = Convert.ToInt32(Console.ReadLine());

            double a, b, e;
          
            switch (choose)
            {
                case 1:
                    Console.WriteLine("         The Half - division Method  ");

                    Console.Write("         Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());
                    
                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());                   

                    HalfDivisionMethod problem_1 = new HalfDivisionMethod(a, b ,e);
                    problem_1.method();                  
                    
                    Console.WriteLine(" \n"  +
                        $"         Center = {problem_1.center}" + " \n " + 
                        $"        Counter of iterations = {problem_1.counter}"
                        );
                    break;

                case 2:
                    Console.WriteLine("         The Golden ratio Method  ");

                    Console.Write("         Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());

                    GoldenRatioMethod problem_2 = new GoldenRatioMethod(a, b, e);
                    problem_2.method();

                    Console.WriteLine(" \n" +
                        $"         xmin = {problem_2.xmin}" + " \n " +
                        $"        Func (xmin) = {problem_2.resultF}" + " \n " +
                        $"        Counter of iterations = {problem_2.counter}"
                        );
                    break;
                case 3:
                    Console.WriteLine("         The parabola Method  ");

                    Console.Write("         Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());

                    ParabolaMethod problem_3 = new ParabolaMethod(a, b, e);
                    problem_3.method();

                    Console.WriteLine(" \n" +
                        $"         Integral = {problem_3.integral}" + " \n " +                        
                        $"        Counter of iterations = {problem_3.counter}"
                        );
                    break;


                default:
                   
                    break;
            }

        }   
    }
}
