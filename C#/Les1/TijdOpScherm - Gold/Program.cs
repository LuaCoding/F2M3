using System;
using System.Threading;

namespace les01
{
    class Program
    {
        static void Main(string[] args)
        {
            // GOLD
            
            int i = 0;
            while (true)
            {
                i += 1;
                if (i == 10)
                {
                    i = 0;
                    string[] colors = { "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "DarkBlue", "DarkGreen", "DarkCyan", "DarkRed", "DarkMagenta", "DarkYellow", "Gray", "DarkGray", "Blue", "Green", "Cyan", "Red", "Magenta", "Yellow", "White" };
                    Random rnd = new Random();
                    int index = rnd.Next(colors.Length);
                    Console.ForegroundColor = (ConsoleColor)Enum.Parse(typeof(ConsoleColor), colors[index]);
                }
                Console.WriteLine(DateTime.Now);
                Thread.Sleep(1000);
                Console.Clear();
            }
        }
    }
}
