﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class MiddlePractice
    {
     static void Main(string[] args)
        {
        string firstName = Console.ReadLine();
        string secondName = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        char gender = char.Parse(Console.ReadLine());
        ulong personalId = ulong.Parse(Console.ReadLine());
        ulong employee = ulong.Parse(Console.ReadLine());

        Console.WriteLine("First name: {0}", firstName);
        Console.WriteLine("Last name: {0}", secondName);
        Console.WriteLine("Age: {0}", age);
        Console.WriteLine("Gender: {0}", gender);
        Console.WriteLine("Personal ID: {0}", personalId);
        Console.WriteLine("Unique Employee number: {0}", employee);
        
    }
}
