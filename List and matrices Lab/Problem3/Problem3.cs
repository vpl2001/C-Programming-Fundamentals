﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class Problem3
    {
        static void Main(string[] args)
        {
        var nums = Console.ReadLine().Split(' ').Select(double.Parse).ToList();
        nums.Sort();
        Console.WriteLine(string.Join(" <= ", nums));
        }
    }
