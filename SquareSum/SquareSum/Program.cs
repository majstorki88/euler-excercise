using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareSum
{
    class Program
    {
        static void Main(string[] args)
        {
            long SqareSum = 0;
            long SumSqare = 0;
            for(int i = 1; i<=100; i++)
            {
                SqareSum = SqareSum + i*i;
                SumSqare = SumSqare + i;
            }
            SumSqare = SumSqare * SumSqare;
            long diff = SumSqare - SqareSum;
            Console.WriteLine(diff);
            Console.ReadLine();
        }
    }
}
