using System;
using System.Threading;

namespace _06___Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopWatch = new Stopwatch();
            stopWatch.EndWatch();
            stopWatch.StartWatch();
            stopWatch.StartWatch();
            Thread.Sleep(1000);
            stopWatch.EndWatch();
            var duration = stopWatch.GetDurations();

            Console.WriteLine("Stopwatch measured: {0}", duration);


        }
    }
}
