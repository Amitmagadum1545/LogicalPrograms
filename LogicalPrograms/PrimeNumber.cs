using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logical_Programs
{
    internal class PrimeNumber
    {
        public static void GetPrimeNumbers()
        {
            Console.WriteLine("Enter the value of starting number (a): ");
            int a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <=a; i++)
            {
                int prime = 1;
                for (int j = 2; j <= i/2; j++)
                {
                    if (i%j == 0)
                    {
                        prime = 0;
                        break;
                    }
                }
                if (prime == 1)
                {
                    Console.Write(i + " ");
                }
            }
            Console.ReadLine();
        }
    }
}