using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem3
    {
        static void Main(string[] args)
        {


        if (matrix[0][0] == 'F')
        {

            health = health - numberOfTurns / 2;

        }
        else if (matrix[0][0] == 'H')
        {
            
            health = health + numberOfTurns / 3;

        }
      
    
        if (health <= 0)
        {
            Console.WriteLine("Died at: [{0}, {1}]", 0, 0);
        }
        }
