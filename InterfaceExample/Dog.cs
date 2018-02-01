using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    class Dog : Animal, IConnectionStatusListener
    {

        public override void Talk()
        {
            Console.WriteLine("Wuh!");
        }

        public void OnConnectionStarted()
        {
            Console.WriteLine("Dog: OnconnectionStarted");
        }
        public void OnConnectionSuccess()
        {
            Console.WriteLine("Dog: OnConnectionSucces - WUF");
        }
        public void OnConnectionFailed()
        {
            Console.WriteLine("Dog: OnConnectionFailed - whine...");
        }



    }
}
