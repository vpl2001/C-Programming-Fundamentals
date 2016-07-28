using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem4
    {
        static void Main(string[] args)
        {
        char[] separators = new char[] { ',', ';', ':', '.', '!', ' ', '(', ')', '"', '\'', '/', '\\',
            '[', ']'  };
        string[] input = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

        var LowerCaseWords = new List<string>();
        var UpperCaseWords = new List<string>();
        var MixedCaseWords = new List<string>();

        foreach (var i in input)
        {
            int lowerCount = 0;
            int upperCount = 0;

            foreach (char item in i)
            {
                if (char.IsLower(item))
                {
                    lowerCount++;
                }
                else if (char.IsUpper(item))
                {
                    upperCount++;
                }
            }
            if (lowerCount==i.Length)
            {
                LowerCaseWords.Add(i);
            }
            else if (upperCount==i.Length)
            {
                UpperCaseWords.Add(i);
            }
            else
            {
                MixedCaseWords.Add(i);
            }
        }
        Console.WriteLine($"Lower-case: {string.Join(", ", LowerCaseWords)}");
        Console.WriteLine($"Mixed-case: { string.Join(", ", MixedCaseWords)}");
        Console.WriteLine($"Upper-case: { string.Join(", ", UpperCaseWords)}");
    }
    }
