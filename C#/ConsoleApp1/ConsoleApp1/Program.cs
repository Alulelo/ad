using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(num1 + num2 );
            Console.ReadLine();

            string colour, pluralnoun, celebrity;

            Console.Write("Enter a colour:");
            colour = Console.ReadLine();

            Console.Write("Enter a pluralnoun:");
            pluralnoun = Console.ReadLine();

            Console.Write("Enter a celebrity:");
            celebrity = Console.ReadLine();

            Console.WriteLine("Roses are " + colour );
            Console.WriteLine(pluralnoun + " are blue");
            Console.WriteLine("I love " + celebrity);

            Console.ReadLine();

            int[] num = { 1, 2, 3, 4, 5 };
            string[] friends = new string [2];
            friends[0] = "alu";
            friends[1] = "tamatar";

            Console.WriteLine( friends[0] + " le lo");
            Console.WriteLine(friends[1] + " le lo");

            Console.ReadLine();

            
        }
    }
}

