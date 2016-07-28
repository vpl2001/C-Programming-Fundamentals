using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem1
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        double sum = 0;
        for (int i = 0; i < input.Length; i++)
        {
            sum += input[i];
        }
        double average = sum / input.Length;

        var result = new List<int>();

        for (int i = 0; i < input.Length; i++)
        {
            if (input[i]>average)
            {
                result.Add(input[i]);
            }
        }

        var output = result.OrderBy(x => -x).Take(5);

        if (result.Count<1)
        {
            Console.WriteLine("No");
        }
        else if (result.Count>5)
        {
            Console.WriteLine(string.Join(" ", output)); 
        }
        else
        {
            Console.WriteLine(string.Join(" ", output));
        }
    }
}
   
