using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem7
    {
        static void Main(string[] args)
        {
        var separators = ".,:;()[]\"'\\/!? ".ToCharArray();
        var input = Console.ReadLine().ToLower().Split(separators);
        var result = input.Where(w => w != "" & w.Length < 5).OrderBy(x => x).Distinct();
        Console.WriteLine(string.Join(", ", result));
        }
    }
