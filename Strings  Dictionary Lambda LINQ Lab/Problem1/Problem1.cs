using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem1
    {
        static void Main(string[] args)
        {
        var text = Console.ReadLine().ToLower();
        var w = Console.ReadLine().ToLower();
        var startPos = 0;
        var counter = 0;

        while (true)
        {
            var pos = text.IndexOf(w, startPos);
            
            if (pos==-1)
            {
                break;
            }
            else
            {
                startPos = pos+1;
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
    }
