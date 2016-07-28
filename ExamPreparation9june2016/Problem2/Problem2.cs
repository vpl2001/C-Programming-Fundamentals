using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem2
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
        var command = Console.ReadLine();

        while (command !="end")
        {
            var result = command.Split(' ');

            if (result[0]=="swap")
            {
                var index1 = int.Parse(result[1]);
                var index2 = int.Parse(result[2]);

                long current = input[index1];
                input[index1] = input[index2];
                input[index2] = current;
            }
            else if (result[0]== "multiply")
            {

                var index1 = int.Parse(result[1]);
                var index2 = int.Parse(result[2]);
                var f = input[index1] * input[index2];
                input[index1] = f;

            }
            else
            {
                for (int i = 0; i < input.Length; i++)
                {
                    input[i] = input[i] - 1;
                }
            }
            command = Console.ReadLine();
        }
        Console.WriteLine(string.Join(", ", input));
    }
    }
