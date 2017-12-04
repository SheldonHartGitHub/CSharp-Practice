using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventsPractice
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instantiate an event publisher object
            EvtPublisher ep = new EvtPublisher();

            // Instantiate an event subscriber object
            EvtSubscriber es = new EvtSubscriber();
            ep.evt += es.HandleTheEvent;

            // Call the CheckBalance method on the ep object
            // It will invoke the ep.evt delegate if the balance exceeds 250
            // ep.CheckBalance(240);
            // Nothing happens if we do less than 250
            ep.CheckBalance(251);
            // The event occurs because we met the parameter 
        }
    }


    public class EvtPublisher
    {
        //public delegate void del(string x);

        //public event del evt;

        public EventHandler evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
                evt(this, EventArgs.Empty);
        }
    }


    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EventArgs e)
        {
            Console.WriteLine("ATTENTION! " + sender + " is advising that the current balance exceeds 250 ");
        }
    }





}
