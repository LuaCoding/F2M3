
using System;

namespace Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.zoogDier();
            Horse horse = new Horse();
            horse.zoogDier();
        }
    }

    class Animal
    {
        public void zoogDier()
        {
            Console.WriteLine("Dit een een zoogdier");
        }
    }

    class Horse : Animal
    {

    }
}