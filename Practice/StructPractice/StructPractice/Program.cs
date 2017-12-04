using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StructPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Sheldon s2;
            s2.x = 6;
            s2.y = 7;
            s2.DoThis();
        }
    }


    public struct Sheldon
    {
        public int x;
        public int y;

        

        public void DoThis()
        {
            Console.WriteLine(x+y);
        }
    }



}
