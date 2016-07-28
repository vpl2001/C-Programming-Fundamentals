using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem7
    {
        static void Main(string[] args)
        {
        int[][] matrix = new int[6][];
        long bestSum = long.MinValue;
        for (int row = 0; row < 6; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
        for (int row = 0; row < 4; row++)
        {
            for (int col = 0; col < 4; col++)
            {
                long sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                               matrix[row + 1][col + 1] +
                           matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];
                if (sum>bestSum)
                {
                    bestSum = sum;
                }
            }
            
        }
        Console.WriteLine(bestSum);
        }
    }
