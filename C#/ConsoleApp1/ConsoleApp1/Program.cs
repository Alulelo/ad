using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isboy = true;
            bool isshort = true;

            if (isboy&&isshort)
            {
                Console.WriteLine("you are a short boi");
            }
            else if (isboy && !isshort)
            {
                Console.WriteLine("U are a not a short boi");
            }else if (!isboy&&isshort)
            {
                Console.WriteLine("U are short but not a boi");
            }
            else
            {
                Console.WriteLine("U are not a boi and u are not short");
            }

            Console.ReadLine();
        }
  

      
      

      
    }
}

