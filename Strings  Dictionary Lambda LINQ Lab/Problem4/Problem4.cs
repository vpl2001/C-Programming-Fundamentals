using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Problem4
    {
        static void Main(string[] args)
        {
        var numbers = Console.ReadLine().Split(' ').Select(decimal.Parse).ToArray();
        Console.WriteLine("/"+ new string('-', 22) + "\\");
        foreach (var num in numbers)
        {
            Console.WriteLine("| {0,20:f2} |", num);
        }
        decimal sum = 0m;
        foreach (var num in numbers)
        {
            sum += num;
        }
        Console.WriteLine("|" + new string('-', 22) + "|");

        Console.WriteLine("| Total:"+" {0,13:f2} |", sum);

        Console.WriteLine("\\" + new string('-', 22) + "/");
    }
    }
