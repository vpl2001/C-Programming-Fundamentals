using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem3
    {
        static void Main(string[] args)
        {
        char[] separators = { '.', '!', '?', ',', ';', ' ' };
        var input = Console.ReadLine().Split(separators).ToArray();

        for (int i = 0; i < input.Length; i++)
        {
            var symbols = input[i].ToCharArray();
            Console.Write(char.ToUpper(symbols[0]));
            var ddd = new char[symbols.Length-1];
            for (int k = 0; k < ddd.Length; k++)
            {
                ddd[k] = symbols[k + 1];
            }

            Console.Write(string.Join("", ddd));
            Console.Write(" ");
        }
        Console.WriteLine();
        }
    }
