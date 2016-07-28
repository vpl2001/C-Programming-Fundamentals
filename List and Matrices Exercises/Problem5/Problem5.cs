using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem5
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        long rows = input[0];
        long cols = input[1];

        long[][] matrix = new long[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        }

        long bestSum = long.MinValue;
        int bestRow = 0;
        int bestCol = 0;

        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                long sum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                          matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                          matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                if (sum > bestSum)
                {
                    bestSum = sum;
                    bestRow = row;
                    bestCol = col;
                }
            }
        }

        Console.WriteLine(bestSum);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow][bestCol], matrix[bestRow][bestCol+1], matrix[bestRow][bestCol+2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow+1][bestCol], matrix[bestRow+1][bestCol + 1], matrix[bestRow+1][bestCol + 2]);
        Console.WriteLine("{0} {1} {2}", matrix[bestRow+2][bestCol], matrix[bestRow+2][bestCol + 1], matrix[bestRow+2][bestCol + 2]);
    }
    }