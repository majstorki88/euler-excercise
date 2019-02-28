using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> fibonacci = new List<int>();
            int NewNumber = 1;
            while (NewNumber <= 4000000)
            {
                if (NewNumber != 1 && NewNumber != 2)
                {
                    NewNumber = fibonacci.Skip(fibonacci.Count - 2).Take(2).Sum();
                    if (NewNumber < 4000000) {
                        fibonacci.Add(NewNumber);
                    }
                }
                else
                {
                    fibonacci.Add(NewNumber);
                    NewNumber ++;
                }
            }
            fibonacci.ForEach(Console.WriteLine);
            Console.WriteLine(fibonacci.Where(i => i % 2 == 0).Sum());
            Console.ReadLine();
        }
    }
}
