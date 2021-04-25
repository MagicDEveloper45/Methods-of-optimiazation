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

            double a, b, e, beta;
          
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

                    Console.Write("         Enter beta: ");
                    beta = double.Parse(Console.ReadLine());

                    HalfDivisionMethod problem_1 = new HalfDivisionMethod(a, b, beta, e);
                    problem_1.method();                  
                    
                    Console.WriteLine(" \n"  +
                        $"         J* = {problem_1.jRes}" + " \n " + 
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
                        $"         J* = {problem_2.jRes}" + " \n " +
                        $"        Counter of iterations = {problem_2.counter}"
                        );
                    break;

                case 3:
                    Console.WriteLine("         The parabola Method  ");

                    Console.Write("         Enter u1: ");
                    double u1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter u2: ");
                    double u2 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter u3: ");
                    double u3 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());

                    ParabolaMethod problem_3 = new ParabolaMethod(u1, u2, u3, e);
                    problem_3.method();

                    Console.WriteLine(" \n" +
                        $"         J* = {problem_3.jRes}" + " \n " +
                        $"        Counter of iterations = {problem_3.counter}"
                        );
                    break;

                case 4:
                    Console.WriteLine("         The Newton's method  ");

                    Console.Write("         Enter u0: ");
                    double u0 = Convert.ToDouble(Console.ReadLine());                   

                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());

                    NewtonMethod problem_4 = new NewtonMethod(u0, e);
                    problem_4.method();

                    Console.WriteLine(" \n" +
                        $"         J* = {problem_4.jRes}" + " \n " +
                        $"        Counter of iterations = {problem_4.counter}"
                        );
                    break;


                case 5:
                    Console.WriteLine("         All results  ");

                    Console.Write("         Enter a: ");
                    a = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter b: ");
                    b = Convert.ToDouble(Console.ReadLine());

                    Console.Write("         Enter e: ");
                    e = double.Parse(Console.ReadLine());

                    Console.Write("         Enter beta (for half-division method): ");
                    beta = double.Parse(Console.ReadLine());

                    Console.Write("         Enter u0: ");
                    u0 = double.Parse(Console.ReadLine());

                    Console.Write("         Enter u1: ");
                    u1 = double.Parse(Console.ReadLine());

                    Console.Write("         Enter u2: ");
                    u2 = double.Parse(Console.ReadLine());

                    Console.Write("         Enter u3: ");
                    u3 = double.Parse(Console.ReadLine());

                    HalfDivisionMethod halfDivisionMethod = new HalfDivisionMethod(a, b, beta, e);
                    halfDivisionMethod.method();

                    GoldenRatioMethod goldenRatioMethod = new GoldenRatioMethod(a, b, e);
                    goldenRatioMethod.method();

                    ParabolaMethod parabolaMethod = new ParabolaMethod(u1, u2, u3, e);
                    parabolaMethod.method();

                    NewtonMethod newtonMethod = new NewtonMethod(u0, e);
                    newtonMethod.method();                    

                    Console.WriteLine(" \n" + "  HalfDivisionMethod" +
                       $"         J* = {halfDivisionMethod.jRes}" + " \n " +
                       $"        Counter of iterations = {halfDivisionMethod.counter}"
                       );

                    Console.WriteLine(" \n" + "  ParabolaMethod" + 
                      $"         J* = {parabolaMethod.jRes}" + " \n " +
                      $"        Counter of iterations = {parabolaMethod.counter}"
                      );

                    Console.WriteLine(" \n" + "  GoldenRatioMethod" +
                      $"         J* = {goldenRatioMethod.jRes}" + " \n " +
                      $"        Counter of iterations = {goldenRatioMethod.counter}"
                      );

                    Console.WriteLine(" \n" + "  NewtonMethod" +
                     $"         J* = {newtonMethod.jRes}" + " \n " +
                     $"        Counter of iterations = {newtonMethod.counter}"
                     );
                    break;                 

                default:                
                    break;
            }

        }   
    }
}
