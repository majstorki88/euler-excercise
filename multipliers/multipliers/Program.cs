using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multipliers
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> numbers = new List<int>();
            for (int i = 3; i < 1000; i += 3)
            {
                numbers.Add(i);
            }
            for (int j = 5; j < 1000; j += 5)
            {
                if(!numbers.Contains(j))
                {
                    numbers.Add(j);
                }
            }
            
            numbers.ForEach(Console.WriteLine);
            Console.WriteLine(numbers.Sum());
            */
            Console.WriteLine(Enumerable.Range(0, 1000).Where(n => n % 3 == 0 || n % 5 == 0).Sum());

            Console.ReadLine();
        }
    }
}