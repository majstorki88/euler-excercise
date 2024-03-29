﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LargeSum
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = Environment.CurrentDirectory + "\\numbers.txt";
            List<string> numbers = readInput(filename);
            int digits = 0;
            for (int i = 11; i == 0; i--)
            {
                int sum = 0;
                foreach ( string number in numbers)
                {
                    sum = sum + System.Convert.ToInt32(number[i]);
                }
                digits = sum;
            }


            Console.WriteLine(digits);
            Console.ReadLine();
        }


        private static List<string> readInput(string filename)
        {
            string line;
            string[] linePieces;

            StreamReader r = new StreamReader(filename);

            List<string> inputNumbers = new List<string>();
            r.BaseStream.Seek(0, SeekOrigin.Begin);

            int j = 0;
            while ((line = r.ReadLine()) != null)
            {
                linePieces = line.Split(' ');
                for (int i = 0; i < linePieces.Length; i++)
                {
                    inputNumbers.Add(linePieces[i]);
                }
                j++;
            }

            r.Close();

            return inputNumbers;
        }
    }
}
