using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int i = 999; i > 99; i--)
            {
                for (int j = 999; j > 99; j--)
                {
                    if (isPalindromic(j*i))
                    {
                        numbers.Add(j * i);
                    }
                }
            }
            Console.WriteLine(numbers.Max());
            Console.ReadLine();
        }
        public static bool isPalindromic(int l)
        {
            IEnumerable<char> forwards = l.ToString().ToCharArray();
            return forwards.SequenceEqual(forwards.Reverse());
        }
    }
}
