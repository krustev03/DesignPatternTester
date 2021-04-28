using Proxy.Interfaces;
using System;

namespace Proxy
{
    class RealSubject : ISubject
    {
        public void Request()
        {
            Console.WriteLine("RealSubject: Handling Request.");
        }
    }
}
