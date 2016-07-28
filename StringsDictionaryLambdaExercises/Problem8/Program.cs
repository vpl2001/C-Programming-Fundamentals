using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//(<upcase>)(.+?)(<\/upcase>)

class Program
    {
        static void Main()
        {
        var input = Console.ReadLine().ToLower();
        if (IsPalindrome(input))
        {
            Console.WriteLine(-1);
        }
        else
        {
            for (int i = 0; i < input.Length; i++)
            {
                var result = input.Remove(i,1);
                if (IsPalindrome(result))
                {
                    Console.WriteLine(i);
                }

            }
        }
        }

    private static bool IsPalindrome(string input)
    {
        var reversed = input.Reverse();
        var bbb = new string(reversed.ToArray());
        if (bbb == input || input=="")
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
