using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem8
    {
        static void Main(string[] args)
        {
        string input = Console.ReadLine();
        char[] myArray = input.ToLower().ToCharArray();
        for (int i = 0; i < input.Length; i++)
        {
            int index = input[i] - 97;
            Console.WriteLine($"{input[i]} -> {index}");
        }
        }
    }
