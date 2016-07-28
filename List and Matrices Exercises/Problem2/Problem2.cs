using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem2
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = input[0];
        int cols = input[1];

        string[][] matrix = new string[rows][];
        char begin = 'a';
        char middle = 'a';

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = new string[cols];

            for (int col = 0; col < cols; col++)
            {
                
                char[] current = new char[3];
                current[0] = begin;
                current[1] = middle;
                current[2] = begin;
                string s = new string(current);
                matrix[row][col] = s; 

                middle++;
            }
            begin++;
            middle = Convert.ToChar(middle-cols+1);

        }
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                Console.Write(matrix[row][col]+" ");
            }
            Console.WriteLine();
        }
    }
    }
