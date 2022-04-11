using System;

namespace Switch_Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 1;
            parsed = int.Parsed(myInt);

            switch (parsed)
            {
                case 0:
                    Console.WriteLine("hallo, dit is case 0");
                    break;
                default:
                    Console.WriteLine("hallo, dit is de default case");
                    break;
            }
        }
    }
}
