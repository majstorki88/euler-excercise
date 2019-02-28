using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfPrimes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> Primes = new List<long>();
            Primes.Add(2);
            for (int b = 3; b<2000000; b++)
            {
                bool isPrime = true;
                if (b%2 == 0) { isPrime = false; };
                for (int a = 3; a <= Math.Sqrt(b); a+=2) {
                    if (b % a == 0) { isPrime = false; };
                }
                if (isPrime)
                { Primes.Add(b); };
            }
            Console.WriteLine(Primes.Sum());
            Console.ReadLine();
        }
    }
}
