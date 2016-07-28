using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem1
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        List<int> output = new List<int>();
        foreach (var num in input)
        {
            if (num>=0)
            {
                output.Add(num);
            }
        }
        output.Reverse();
        if (output.Count==0)
        {
            Console.WriteLine("empty");
        }
        else
        {
            Console.WriteLine(string.Join(" ", output));
        }
        }
    }
