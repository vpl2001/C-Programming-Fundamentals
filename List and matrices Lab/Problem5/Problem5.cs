using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem5
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        var results = new List<int>();

        foreach (var num in input)
        {
            if (Math.Sqrt(num)== (int)Math.Sqrt(num))
            {
                results.Add(num);
            }
        }
        results.Sort((a,b)=>b.CompareTo(a));
        Console.WriteLine(string.Join(" ", results));
        }
    }
