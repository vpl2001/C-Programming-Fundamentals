using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class SomeMore
    {
        static void Main(string[] args)
        {
        byte centuries = (byte)int.Parse(Console.ReadLine());
        int years = 100 * centuries;
        int days = (int)(years * 365.2422);
        int hours = 24 * days;
        int minutes = 60 * hours;
        decimal seconds = minutes * 60m;
        decimal miliseconds = seconds * 1000;
        decimal microseconds = miliseconds * 1000;
        decimal nanoseconds = miliseconds*1000000;
        Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes = {seconds} seconds = {miliseconds} milliseconds = {microseconds} microseconds = {nanoseconds} nanoseconds");
      
    }
    }
