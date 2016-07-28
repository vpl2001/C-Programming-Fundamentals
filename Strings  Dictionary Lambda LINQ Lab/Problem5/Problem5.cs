using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem5
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().ToLower().Split(' ');
        var counts = new Dictionary<string, int>();
        foreach (var item in input)
        {
            if (counts.ContainsKey(item))
            {
                counts[item]++;
            }
            else
            {
                counts[item] = 1;
            }
        }
        List<string> results = new List<string>();

        foreach (var count in counts.Keys)
        {
            if (counts[count]%2!=0)
            {
                results.Add(count);
            }
        }
        Console.WriteLine(string.Join(", ", results));
        }
    }
