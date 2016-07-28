using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem4
    {
        static void Main(string[] args)
        {
        int health = int.Parse(Console.ReadLine());
        var input = Console.ReadLine().Split(' ');
        int rows = int.Parse(input[0]);
        int cols = int.Parse(input[1]);
        char[][] matrix = new char[rows][];
        var list = new List<int>();

       

        for (int row = 0; row < rows; row++)
        {
            matrix[row] = Console.ReadLine().ToArray();
        }
        int curr = health;
        int numberOfTurns = 0;
        if (matrix[0][0] == 'F')
        {

            curr = curr - (numberOfTurns / 2);

        }
        if (matrix[0][0] == 'H')
        {
            curr = curr + (numberOfTurns / 3);

        }

        for (int col = 0; col < cols; col++)
        {
            
            if (col%2!=0)
            {
                for (int row = 0; row < rows; row++)
                {
                    
                    if (matrix[row][col] == 'F')
                    {
                        
                        health = health - (numberOfTurns / 2);
                        numberOfTurns++;


                    }
                    else if (matrix[row][col] == 'H')
                    {

                        
                        health = health + (numberOfTurns / 3);
                        numberOfTurns++;


                    }
                    else if (matrix[row][col] == 'T')
                    {
                        numberOfTurns += 3;
                    }
                    else
                    {
                        numberOfTurns += 1;
                    }
                    if (health <= 0)
                    {
                        list.Add(row);
                        list.Add(col);
                    }
                }   
               
            }
            else
            {
                for (int row = rows-1; row  >=0; row --)
                {
                    
                    if (matrix[row][col] == 'F')
                    {
                        
                        health = health - (numberOfTurns / 2);
                        numberOfTurns++;

                    }
                    else if (matrix[row][col] == 'H')
                    {
                       
                        health = health + (numberOfTurns / 3);
                        numberOfTurns++;

                    }
                    else if (matrix[row][col] == 'T')
                    {
                        numberOfTurns += 3;
                    }
                    else
                    {
                        numberOfTurns += 1;
                    }
                    if (health <= 0)
                    {
                        list.Add(row);
                        list.Add(col);
                    }
                }
                
            }

        }
        if (health>0)
        {
            Console.WriteLine("Quest completed!");
            Console.WriteLine("Health: {0}", health);
            Console.WriteLine("Turns: {0}", numberOfTurns);
        }
        else
        {
            Console.WriteLine("Died at: [{0}, {1}]", list[0], list[1]);
        }
        
        
    }
    }
