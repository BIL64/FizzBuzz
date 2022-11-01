using System;
namespace FizzBuzz
{
    internal class Program
    {
        /* Detta är en kortversion som gör samma sak som den nedan fast bantad.
        static void Main(string[] args)
        {
            Console.WriteLine("FizzBuzz. Three numbers:");
            int zzX = int.Parse(Console.ReadLine());
            int zzY = Convert.ToInt32(Console.ReadLine());
            int zzN = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            for (int i = 1; i <= zzN; i++)
            {
                if (i % zzX == 0 && i % zzY == 0) Console.WriteLine("FizzBuzz");
                else if (i % zzX == 0 && i % zzY != 0) Console.WriteLine("Fizz");
                else if (i % zzY == 0 && i % zzX != 0) Console.WriteLine("Buzz");
                else Console.WriteLine(i);
            }

            Console.ReadLine();
        }
        */
        
        static void Main(string[] args) // Kattis gillar inte det här sättet att lösa detta problemet på.
        {
            bool display = true;

            while (display)
            {
                Console.Write("Type \"q\" to exit or continue with any key ");
                string zzQ = Console.ReadLine();
                if (zzQ == "q" || zzQ == "Q") display = false;
                else
                {
                    Console.Clear();
                    display = Menu();
                }
            }
        }

        private static bool Menu()
        {
            Console.WriteLine("FizzBuzz");
            Console.Write("Type a number x, higher or equal to 1 but less than 9: ");
            int zzX = int.Parse(Console.ReadLine()); // Provar olika sätt att omvandla en sträng till ett tal.
            Console.Write("Type a number y, higher than x but less than 10: ");
            int zzY = Convert.ToInt32(Console.ReadLine()); // Ett annat sätt.
            Console.Write("Type a number n, higher than y but less than 100: ");
            int zzN = Convert.ToInt32(Console.ReadLine());

            if (zzX < 1 || zzX > 9 || zzX >= zzY || zzY > 10 || zzY >= zzN || zzN > 100)
            {
                Console.WriteLine("Try again...");
                Console.ReadLine();
                return true;
            }
            else
            {
                Console.WriteLine("");
                for (int i = 1; i <= zzN; i++)
                {
                    if (i % zzX == 0 && i % zzY == 0) Console.WriteLine("FizzBuzz");
                    else if (i % zzX == 0 && i % zzY != 0) Console.WriteLine("Fizz");
                    else if (i % zzY == 0 && i % zzX != 0) Console.WriteLine("Buzz");
                    else Console.WriteLine(i);
                }

                Console.ReadLine();
                return true;
            }
        }
    }
}