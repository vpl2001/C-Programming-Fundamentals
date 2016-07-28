using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem3
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);

        int[][] matrix = new int[rows][];

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().Split(' ').Select(int.Parse).ToArray(); 
        }

        var indexes = Console.ReadLine().Split(' ');
        int rowIndex = int.Parse(indexes[0]);
        int colIndex = int.Parse(indexes[1]);

        int target = matrix[rowIndex][colIndex];
        long sum = 0;

        for (int row = rowIndex-1; row <= rowIndex+1; row++)
        {
            for (int col = colIndex-1; col <= colIndex+1; col++)
            {
                sum += matrix[row][col];
            }
        }

        for (int row = rowIndex-1; row <= rowIndex + 1; row++)
        {
            for (int col = colIndex-1; col <= colIndex + 1; col++)
            {
                matrix[row][col]= matrix[row][col]* target;
            }
        }

        sum = sum -target;

        var modified = target * sum;
        matrix[rowIndex][colIndex] = (int)modified;

        for (int row = 0; row < rows; row++)
        {
            Console.WriteLine(string.Join(" ", matrix[row]));
        }

    }
}
