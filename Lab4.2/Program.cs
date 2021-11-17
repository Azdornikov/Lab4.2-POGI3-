using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите A:");
            double a = Convert.ToDouble(Console.ReadLine());
          
            Console.WriteLine("Введите B:");
            double b = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("\n" + add(a, b));
            Console.WriteLine(sub(a, b));
            Console.WriteLine(multiply(a, b));
            Console.WriteLine(div(a, b));
        }

        static double multiply(double A, double B)
        {
            return A * B;
        }

        static double sub(double A, double B)
        {
            return A - B;
        }

        static double add(double A, double B)
        {
            return A + B;
        }

        static double div(double A, double B)
        {
            return A / B;
        }
    }
}
