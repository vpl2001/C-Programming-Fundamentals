using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Exercises13
{
    static void Main(string[] args)
    {
        double widghRectangle = double.Parse(Console.ReadLine());
        double heightRectangle = double.Parse(Console.ReadLine());
        double perimeter = 2 * widghRectangle + 2 * heightRectangle;
        double area = widghRectangle * heightRectangle;
        double diagonal = Math.Sqrt((widghRectangle * widghRectangle) + (heightRectangle * heightRectangle));
        Console.WriteLine(perimeter);
        Console.WriteLine(area);
        Console.WriteLine(diagonal);
    }
}