using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem2
    {
        static void Main(string[] args)
        {
        List<string> input = Console.ReadLine().Split('|').ToList();
        List<string> result = new List<string>();

        input.Reverse();
        foreach (var item in input)
        {
            var list = item.Split(' ').ToList();
            foreach (var l in list)
            {
                if (l!="")
                {
                    result.Add(l);
                }
            }
        }
        Console.WriteLine(string.Join(" ", result));
        }
        }
