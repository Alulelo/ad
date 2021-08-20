using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your name:");
            string name = Console.ReadLine();
            Console.Write("Enter Your age:");
            string age = Console.ReadLine();
            Console.WriteLine("Hello " + name + " Your age is  " + age);
            Console.ReadLine();
        }
    }
}

