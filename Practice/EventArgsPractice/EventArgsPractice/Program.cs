﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventArgsPractice
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
            ep.CheckBalance(251);
        }
    }


    public class EvtPublisher
    {
        public EventHandler<EvtArgsClass> evt;

        public void CheckBalance(int x)
        {
            if (x > 250)
            {
                EvtArgsClass eac = new EvtArgsClass("Balance exceeds 250 ");
                evt(this, eac);
            }


        }

    }


    public class EvtSubscriber
    {
        public void HandleTheEvent(object sender, EvtArgsClass e)
        {
            Console.WriteLine("ATTENTION! from " + sender + ": " + e.Message);
        }
    }

    public class EvtArgsClass : EventArgs
    {
        public EvtArgsClass (string str)
        {
             msg = str;
        }

        private string msg;
        public string Message
        {
            get { return msg; }
        }

    }

}
