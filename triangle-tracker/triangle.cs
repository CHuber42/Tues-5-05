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
        bool isATriangle;
        bool rightTriangle;

        if (firstSide + secondSide <= thirdSide || secondSide + thirdSide <= firstSide || firstSide + thirdSide <= secondSide)
        {
            Console.WriteLine("Not a Triangle");
            isATriangle = false;
            rightTriangle = false;
        }
        else if (firstSide == secondSide && secondSide == thirdSide) {
            Console.WriteLine("Equilateral Triangle");
            isATriangle = true;
        }
        else if (firstSide == secondSide || firstSide == thirdSide || secondSide == thirdSide)
        {
            Console.WriteLine("Isosceles Triangle.");
            isATriangle = true;  
        }
        else 
        {
            Console.WriteLine("Scalene Triange");
            isATriangle = true;
        }

        if (isATriangle)
        {
            firstSide *= firstSide;
            secondSide *= secondSide;
            thirdSide *= thirdSide;

            if (firstSide > secondSide && firstSide > thirdSide && firstSide == (secondSide + thirdSide))
            {
                rightTriangle = true;
            }
            else if (secondSide > firstSide && secondSide > thirdSide && secondSide == (firstSide + thirdSide))
            {
                rightTriangle = true;
            }
            else if (thirdSide > firstSide && thirdSide > secondSide && thirdSide == (firstSide + secondSide))
            {
                rightTriangle = true;
            }
            else{
                rightTriangle = false;
            }

            switch (rightTriangle)
            {
            case true: Console.WriteLine("And yes, this is a right triangle!");
                break;
            case false: Console.WriteLine("And no, this is not a right triangle!");
                break;
            }
        }
    }
}