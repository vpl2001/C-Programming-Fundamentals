using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercises11
  {
    static void Main(string[] args)
        {
        string input = Console.ReadLine();
        char digit = input.Last();
        Console.WriteLine(PrintDigitAsWord(digit));
    }
    static string PrintDigitAsWord(char symbol)
    {
        switch (symbol)
        {
            case '1': return "one";
            case '2': return "two";
            case '3': return "three";
            case '4': return "four";
            case '5': return "five";
            case '6': return "six";
            case '7': return "seven";
            case '8': return "eight";
            case '9': return "nine";
            default: return "zero";
                break;
        }
    }
   }
