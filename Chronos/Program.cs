using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch crono1 =new Stopwatch();
            Stopwatch crono2 =new Stopwatch();

            crono1.Start();
            Thread.Sleep(600);

            crono2.Start();
            Thread.Sleep(200);

            crono1.Stop();
            crono2.Stop();

            long a = crono1.ElapsedMilliseconds;
            long b = crono2.ElapsedMilliseconds;

            double sg1 = a/1000.0;
            double sg2 = b/1000.0;

            Console.WriteLine(sg1);
            Console.WriteLine(sg2);

            
        }
    }
}
