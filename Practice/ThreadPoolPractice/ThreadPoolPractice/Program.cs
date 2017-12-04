using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadPoolPractice
{
    class Program
    {


        static void Main(string[] args)
        {
            Thread t = new Thread(Count);
            t.Start();


            Task task = Task.Run(() =>
            {
                for (int i = 0; i < 8; i++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine("BG ");
                }
            });
        }


        static void Count()
        {
            for (int i = 0; i < 2; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.WriteLine("FG ");
            }
        }
    }
}
