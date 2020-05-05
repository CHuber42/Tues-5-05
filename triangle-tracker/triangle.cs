using System;

class Triangle{
    static void Main()
    {
        Console.WriteLine("I would like three numbers (lengths of a side) from you, and I\nwill tell you what kind of triangle they form, if any.\nFirst Number:");
        int firstSide = int.Parse(Console.ReadLine());
        Console.WriteLine("Second Number:");
        int secondSide = int.Parse(Console.ReadLine());
        Console.WriteLine("Third Number:");
        int thirdSide = int.Parse(Console.ReadLine());

        bool rightTriangle = false;

        if (firstSide + secondSide <= thirdSide || secondSide + thirdSide <= firstSide || firstSide + thirdSide <= secondSide)
        {
            Console.WriteLine("Not a Triangle");
        }
        else if (firstSide == secondSide && secondSide == thirdSide) {
            Console.WriteLine("Equilateral Triangle");
        }
        else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
        {
            Console.WriteLine("Isosceles Triangle.");  
        }
        else 
        {
            Console.WriteLine("Scalene Triange");
        }

        
    }
}