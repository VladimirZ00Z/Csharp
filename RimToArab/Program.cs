using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace RimToArab
{
    class Program
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] arr = text.ToCharArray();
            int sum = 0;
            Dictionary<char, int> rimDg = new Dictionary<char, int> {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
            };
            for (int i = 0; i < arr.Length; i++)
            {
                sum += rimDg[arr[i]];
            }
            Console.WriteLine(sum);
        }
    }
}