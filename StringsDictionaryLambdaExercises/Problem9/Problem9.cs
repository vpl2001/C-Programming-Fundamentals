using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem9
    {
        static void Main(string[] args)
        {
        var n = int.Parse(Console.ReadLine());
        string[][] matrix = new string[n][];

        for (int row = 0; row < n; row++)
        {
            matrix[row]  = Console.ReadLine().Split(' ').ToArray();
        }

        for (int row = 0; row < matrix.Length; row++)
        {

            Console.WriteLine(string.Join(" ", matrix[row]));
        }

        }
    }
