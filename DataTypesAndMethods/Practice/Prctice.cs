﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Practice
    {
     static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = 0;
        Console.WriteLine("Before:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After:");
        Console.WriteLine("a = {0}", a);
        Console.WriteLine("b = {0}", b);


    }
}
