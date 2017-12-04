using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {


        static void Main(string[] args)
        {
            Thread t = new Thread(WriteX);
            t.Start();


            for (int i = 0; i < 1000; i++)
            {
                Console.Write("O");
            }    
            
        }

        static void WriteX()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }
    }
}
