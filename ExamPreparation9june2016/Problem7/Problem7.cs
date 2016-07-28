using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem7
    {
        static void Main(string[] args)
        {
        while (true)
        {
            var command = Console.ReadLine();
            if (command=="stop")
            {
                break;
            }
            var bbb = command.Split("@#&$%0123456789".ToArray());
            Console.WriteLine(string.Join("", bbb));
        }
        }
    }
