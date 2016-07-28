using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem6
    {
        static void Main(string[] args)
        {
        string[] strings = Console.ReadLine().Split(' ');
        List<int> results = strings.Select(int.Parse).ToList();
        var sortednums = results.OrderBy(x=>-x);
        var largestThree = sortednums.Take(3);
        Console.WriteLine(string.Join(" ", largestThree));
        }
    }
