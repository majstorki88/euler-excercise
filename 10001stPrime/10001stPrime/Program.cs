using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10001stPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> Primars = new List<int>();
            Primars.Add(2);

            int j = 3;
            while (Primars.Count < 10001)
            {
                bool isPrime = true;
                if (j % 2 == 0)
                {
                    isPrime = false;
                }
                for (int p = 3; p <= Math.Sqrt(j); p += 2)
                {
                    if (j % p == 0)
                    {
                        isPrime = false;
                    }
                }
                if(isPrime)
                {
                    Primars.Add(j);
                }
                j += 1;
            }
            Console.WriteLine(Primars[10000]);
            Console.ReadLine();
        }

    }
}
