using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Write a no1:");
            decimal num1 = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("Operators are as: +(Addition) -(Subtraction) *(Multiplication) /(Divide) ");

            Console.Write("Enter a operator:");
            string hh = Console.ReadLine();

            Console.Write("Write a no2:");
            decimal num2 = Convert.ToDecimal(Console.ReadLine());

            if (hh == "+") 
            {
                Console.Write(num1 + num2);
            }else if (hh == "-") 
            {
                Console.Write(num1 - num2);
            }else if (hh == "*")
            {
                Console.Write(num1 * num2 );
            }
            else if(hh== "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Enter a valid operator U dummy");
            }

            Console.ReadLine();


        }
   
        
      
    }
}

