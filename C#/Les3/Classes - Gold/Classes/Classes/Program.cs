using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Calculation.Add(9, 10));
            Console.WriteLine(Calculation.Division(50, 5));
            Console.WriteLine(Calculation.Multiplication(4, 2));
        }
    }

    static class Calculation
    {
        public static double Add(double getal1, double getal2)
        {
            return getal1 + getal2;
        }
        public static double Division(double getal1, double getal2)
        {
            return getal1 / getal2;
        }
        public static double Multiplication(double getal1, double getal2)
        {
            return getal1 * getal2;
        }
    }
}