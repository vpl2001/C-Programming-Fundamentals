using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SomeDataTypes
    {
        static void Main(string[] args)
        {
        
        decimal firstNumber = decimal.Parse(Console.ReadLine());
        
        decimal secondNumber = decimal.Parse(Console.ReadLine());
        bool comparing = (Math.Abs(firstNumber - secondNumber) < 0.000001m);
        Console.WriteLine(comparing);
    }
    }
