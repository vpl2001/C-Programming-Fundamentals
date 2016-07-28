using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem4
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];

        char[][] matrix = new char[rows][];
        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
        }

        int counter = 0;

        for (int row = 0; row < rows-1; row++)
        {
            for (int col = 0; col < cols-1; col++)
            {
                if (matrix[row][col]==matrix[row][col+1] && matrix[row][col] == matrix[row+1][col] && matrix[row][col+1] == matrix[row+1][col])
                {
                    counter++;
                }
            }
        }
        Console.WriteLine(counter);
    }
    }
