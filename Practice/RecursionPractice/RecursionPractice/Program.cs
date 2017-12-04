using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int input = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= input; i++)
            {
                Console.WriteLine(Nth(input));
            }

            
        }

        public static int Nth(int n)
        {
            if (n == 0)
                return 1;
            return n * Nth(n - 1);
        }

    }
}
