using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxPrimeFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            long n = 600851475143;
            long k = 2;
            while (k * k <= n)
            {
                if (n % k == 0)
                {
                    n /= k;
                }
                else
                {
                    ++k;
                }
            }
            Console.WriteLine(n);
            Console.ReadLine();
        }
    }
}
