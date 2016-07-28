using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercises12
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        char symbol = char.Parse(input);
        Console.WriteLine(VowelOrDigit(symbol));
    }
    static string VowelOrDigit(char checker)
    {
        if (checker>=48 && checker<=57)
        {
            return "digit";
        }
        else if (checker == 'a' || checker =='e' || checker == 'i' || checker == 'o'|| checker=='u' )
        {
            return "vowel";
        }
        else
        {
            return "other";
        }
    }
}
