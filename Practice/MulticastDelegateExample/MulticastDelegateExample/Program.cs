using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MulticastDelegateExample
{
    class Program
    {
        delegate void del(int x, int y);

        static void Main(string[] args)
        {
            Sheldon s = new Sheldon();

            del d;

            d = s.AddNumbers;
            Console.WriteLine("Invoking delegate d with one target: ");
            d(6, 5);
            Console.WriteLine();


            d += s.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d with two target: ");
            d(6, 5);
            Console.WriteLine();

            d += s.SubtractNumbers;
            Console.WriteLine("Invoking delegate d with three target: ");
            d(6, 5);
            Console.WriteLine();

            d -= s.MultiplyNumbers;
            Console.WriteLine("Invoking delegate d without MultiplyNumbers: ");
            d(6, 5);
            Console.WriteLine();

        }
    }

    public class Sheldon
    {

        public void AddNumbers(int a, int b)
        {
            Console.WriteLine("AddNumbers: a + b = " + (a + b));
        }

        public void MultiplyNumbers(int a, int b)
        {
            Console.WriteLine("MultiplyNumbers: a * b = " + (a * b));
        }

        public void SubtractNumbers(int a, int b)
        {
            Console.WriteLine("SubtractNumbers: a - b = " + (a - b));
        }




    }
}
