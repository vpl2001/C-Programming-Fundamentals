using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem2
    {
        static void Main(string[] args)
        {
        char[] separators = { '.', '!', '?' };
        char[] separatorsSecond = { ' ' };
        var word = Console.ReadLine();
        var input = Console.ReadLine().Split(separators).ToArray();
        foreach (var sentence in input)
        {
            
            var x = sentence.Split(separatorsSecond, StringSplitOptions.RemoveEmptyEntries);


            foreach (var xx in x)
            {
                if (xx==word)
                {
                    Console.WriteLine(string.Join(" ", x));
                    break;
                }
            }
        }
        }
    }
