using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegatePractice
{
    class Program
    {

        delegate int del(int x, int y);
        delegate int led(int x, int y, int z);

        static void Main(string[] args)
        {
            Sheldon s = new Sheldon();
            del d = s.AddNumbers;
            Console.WriteLine(d(3, 4));

            d = s.MultiplyNumbers;
            Console.WriteLine(d(3, 4));

            Sheldon ss = new Sheldon();
            led dd = ss.DoAnotherThing;
            Console.WriteLine(dd(4, 9, -2));
            


            //Sheldon s = new Sheldon();
            //Console.WriteLine(s.AddNumbers(20, 40));
            //Console.WriteLine(s.MultiplyNumbers(20, 40));    
            ////Console.WriteLine(s);
        }
    }


    public class Sheldon
    {
        public int AddNumbers(int a, int b)
        {
            return a + b;
        }
        public int MultiplyNumbers(int a, int b)
        {
            return a * b;
        }

        public int DoAnotherThing(int x, int y, int z)
        {
            return x + (y * 3) * z;
        }

    }

   




}
