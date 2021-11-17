using System;

namespace Lab4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите A:");
            double a = Convert.ToDouble(Console.ReadLine());
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
