using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem8
{
    static void Main(string[] args)
    {
        var vlado = Dictionary<string>();

        var data = new SortedDictionary<string, Dictionary<string, decimal>>();
        while (true)
        {
            var input = Console.ReadLine();
            if (input=="stop")
            {
                break;
            }
            var result = input.Split().ToArray();
            string country = result[0];
            string town = result[1];
            decimal population = decimal.Parse(result[2]);

            if (data.ContainsKey(country))
            {
                if (data[country].ContainsKey(town))
                {
                    data[country][town] += population;
                }
                else
                {
                    data[country].Add(town, population);
                }
            }
            else
            {
                data.Add(country, new Dictionary<string, decimal>());
                data[country].Add(town, population);
            }
        }


        foreach (var item in data.Keys)
        {
            Console.WriteLine(item);

            var result = new Dictionary<string, decimal>();
            result = data[item];
            result = result.OrderBy(x => -x.Value).ToDictionary(x => x.Key, x => x.Value);

            foreach (var www in result.Keys)
            {
                Console.Write(www);
                Console.Write("->");
                Console.Write(result[www]);
                Console.WriteLine();
            }
               
        }
    }
}
