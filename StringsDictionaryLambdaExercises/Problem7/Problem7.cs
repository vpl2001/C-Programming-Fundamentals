using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Problem7
    {
        static void Main(string[] args)
        {
        char[] separators = { '.', '!', '?', ',', ';', ' ' };
        var input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries).ToArray();

        var palindromes = new List<string>();

        for (int i = 0; i < input.Length; i++)
        {
            var reversed = input[i].Reverse();
            var bbb = new string(reversed.ToArray());
            if (bbb == input[i])
            {
                palindromes.Add(input[i]);
            }
        }
        var results = palindromes.OrderBy(x => x).Distinct();
        Console.WriteLine(string.Join(", ", results));
        }
    }
