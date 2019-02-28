using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace minDiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int divisorMax = 20;
            int[] p = generatePrimes(divisorMax);
            int result = 1;

            for (int i = 0; i < p.Length; i++)
            {
                int a = (int)Math.Floor(Math.Log(divisorMax) / Math.Log(p[i]));
                result = result * ((int)Math.Pow(p[i], a));
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static int[] generatePrimes(int upperLimit)
        {
            List<int> primes = new List<int>();
            bool isPrime;
            int j;

            primes.Add(2);

            for (int i = 3; i <= upperLimit; i += 2)
            {
                j = 0;
                isPrime = true;
                while (primes[j] * primes[j] <= i)
                {
                    if (i % primes[j] == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    j++;
                }
                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes.ToArray<int>();
        }
    }
}
