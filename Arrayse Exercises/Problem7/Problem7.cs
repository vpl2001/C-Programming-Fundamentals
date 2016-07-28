using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem7
    {
        static void Main(string[] args)
        {
        var firstArray = Console.ReadLine().Split(' ');
        var secondArray = Console.ReadLine().Split(' ');

        string sss = string.Join("", firstArray);
        string www = string.Join("", secondArray);

        string[] ddd = new string[2];
        ddd[0] = sss;
        ddd[1] = www;
        Array.Sort(ddd);
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(ddd[i]);
        }
    }
    }
