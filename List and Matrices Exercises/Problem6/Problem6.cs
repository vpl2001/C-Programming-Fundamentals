using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

    class Problem6
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').ToArray();
        decimal sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]=="0")
            {
                sum+=0;
            }
            else
            {
                List<char> current = input[i].ToList();
                current.Reverse();

                for (int k = 0; k < current.Count; k++)
                {

                    if (current[k] != '0')
                    {
                        break;
                    }
                    else
                    {
                        current.Remove(current[k]);
                    }
                }
                string number = new string(current.ToArray());
                sum += decimal.Parse(number);
            }
        }
        Console.WriteLine(sum);
    }
    }
