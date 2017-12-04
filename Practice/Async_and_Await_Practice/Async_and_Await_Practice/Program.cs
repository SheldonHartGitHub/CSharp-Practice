using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Async_and_Await_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            AsyncAwaitDemo demo = new AsyncAwaitDemo();
            demo.DoStuff();


            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the Main Thread......");
            }

        }
    }


    public class AsyncAwaitDemo
    {
        public async Task DoStuff()
        {
            //await Task.Run(() =>
            //    {
                    CountToFifty();
                //});
                
            // This will not execute until CountToFifty has completed
            Console.WriteLine("Counting to 50 is completed...");

        }
        
        public  async Task<string> CountToFifty()
        {
            int counter;

            for (counter = 0; counter < 51; counter++)
            {
                Console.WriteLine("BG Thread: " + counter);
            }

            return ("Counter = " + counter);
        }
        
    }
}
