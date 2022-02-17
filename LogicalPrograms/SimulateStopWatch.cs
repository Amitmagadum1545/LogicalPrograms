using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class SimulateStopWatch
    {
        public static void GetElapsedTime()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            Console.WriteLine("Enter any key to stop stopwatch");
            Console.ReadLine();     
            stopwatch.Stop();
            Console.WriteLine("\n Elapsed time : " + stopwatch.Elapsed);
        }
    }
}