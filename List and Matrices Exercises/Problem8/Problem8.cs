using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem8
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').ToList();
        string[] special = Console.ReadLine().Split(' ');
        string specialNumber = special[0];
        long power = long.Parse(special[1]);
        long sum = 0;

        if (power > 0)
        {
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] == specialNumber)
                {
                    if (input.Count - i > power)
                    {
                        input.RemoveRange(i, (int)power + 1);
                    }
                    else
                    {
                        input.RemoveRange(i, input.Count - i);
                    }
                    if (i - power >= 0)
                    {
                        input.RemoveRange(i - (int)power, (int)power);
                    }
                    else
                    {
                        input.RemoveRange(0, i);
                    }

                }
            }
            foreach (var item in input)
            {
                sum += long.Parse(item);
            }
            Console.WriteLine(sum);
        }
        else
        {
            foreach (var item in input)
            {
                sum += long.Parse(item);
            }
            Console.WriteLine(sum);
        }     
    }
    }