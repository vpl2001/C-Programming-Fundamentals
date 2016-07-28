using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem1
    {
        static void Main(string[] args)
        {
        var mail = Console.ReadLine().Split('@').ToArray();
        var text = Console.ReadLine();

        var d = new string('*', mail[0].Length);
        string mailString = mail[0] + "@" + mail[1];
        string duplicate = d + "@" + mail[1];
        var replaced = text.Replace(mailString, duplicate);
       
        Console.WriteLine(replaced);

        }
    }
