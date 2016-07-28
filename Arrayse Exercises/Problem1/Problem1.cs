using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem1
    {
        static void Main(string[] args)
        {
        string[] firstArray = Console.ReadLine().Trim().Split(' ').ToArray();
        string[] secondArray = Console.ReadLine().Trim().Split(' ').ToArray();

        int bestStartPosition = 0;
        int bestEndPosition = 0;
        int longestEqualStart = 0;
        int longestEqualEnd = 0;

        for (int i = 0; i < Math.Min(firstArray.Length, secondArray.Length); i++)
        {
            if (firstArray[i]==secondArray[i])
            {
                longestEqualStart++;
                bestStartPosition = i;
            }
        }

        string[] reversedFirst = firstArray.Reverse().ToArray();
        string[] reversedSecond = secondArray.Reverse().ToArray();

        for (int i = 0; i < Math.Min(reversedFirst.Length, reversedSecond.Length); i++)
        {
            if (reversedFirst[i] == reversedSecond[i])
            {
                longestEqualEnd++;
                bestEndPosition++;
            }
        }
      
        if (longestEqualStart>= longestEqualEnd)
        {
            Console.WriteLine(longestEqualStart);
        }
        else
        {
            Console.WriteLine(longestEqualEnd);
        }
    }
    }
