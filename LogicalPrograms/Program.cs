using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the program");
            Console.WriteLine("\n 1. Fibonacci Series \n 2. Perfect Number \n 3. Prime Number \n 4. Reverse Number \n 5. Coupon Numbers \n 6. Day of Week  \n 7. Simulate Stop Watch \n 8. Temperature Conversion ");
            int programNum = Convert.ToInt32(Console.ReadLine());
            switch (programNum)
            {
                case 1:
                    FibonacciSeries.GetFibonacciSeries();
                    break;
                case 2:
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    PrimeNumber.GetPrimeNumbers();
                    break;
                case 4:
                    ReverseNumber.GetReverseNumber();
                    break;
                case 5:
                    CouponNumbers.CheckCouponNumbers();
                    break;
                case 6:
                    DayOfWeek.FindDayOfWeek();
                    break;
                case 7:
                    SimulateStopWatch.GetElapsedTime();
                    break;
                case 8:
                    TemperatureConversion.ConvertTemp();
                    break;
                    Console.WriteLine("Please choose the correct ProgramNum");
                    break;
            }
        }
    }
}