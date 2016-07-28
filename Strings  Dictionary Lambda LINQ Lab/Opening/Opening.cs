using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Opening
    {
        static void Main(string[] args)
        {
        string text = Console.ReadLine();
        string[] words = Console.ReadLine().Split(' ').ToArray();
        foreach (var w in words)
        {
            string str = new string('*', w.Length);
            text = text.Replace(w, str);
        }
        Console.WriteLine(text);
        }
    }
