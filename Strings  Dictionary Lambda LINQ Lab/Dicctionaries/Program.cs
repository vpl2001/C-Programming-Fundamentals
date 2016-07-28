using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Program
    {

    static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        var counts = new SortedDictionary<double, int>();
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
        foreach (var count in counts.Keys)
        {
            Console.WriteLine($"{count} -> {counts[count]}");
        }
        }
    }
