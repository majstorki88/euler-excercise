using System;
using System.IO;
using System.Numerics;
using System.Diagnostics;



namespace LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Environment.CurrentDirectory + "\\numbers.txt";
            BigInteger result = new BigInteger();
            string line;
            StreamReader r = new StreamReader(filename);

            while ((line = r.ReadLine()) != null)
            {
                result += BigInteger.Parse(line);
            }

            r.Close();
            Console.WriteLine(result.ToString().Substring(0, 10));
            Console.ReadLine();
        }
    }
}
