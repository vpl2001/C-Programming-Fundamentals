using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class Exercises_20
    {
        static void Main(string[] args)
        {
        int number = int.Parse(Console.ReadLine());
        BigInteger factorial = 1;

        if (number ==0 || number==1)
        {
            Console.WriteLine(1);
        }
        else
        {
            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
            }
            Console.WriteLine(factorial);
        }       
    }
    }
