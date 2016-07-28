using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Exerc19
    {
        static void Main(string[] args)
        {
        long number = long.Parse(Console.ReadLine());
        int divider = 2;
        bool isPrime = true;

        if (number == 0 || number == 1)
        {
            isPrime = false;
        }

        while (isPrime && divider<=Math.Sqrt(number))
        {
            if (number%divider==0)
            {
                isPrime = false;
            }
            divider++;
        }
        Console.WriteLine(isPrime);
        }
    }
