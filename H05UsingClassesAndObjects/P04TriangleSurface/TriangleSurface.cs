//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.

using System;

class TriangleSurface
{
    static void Main()
    {
        Console.WriteLine("1) Side and an altitude to it");
        Console.WriteLine("2) Three sides");
        Console.WriteLine("3) Two sides and an angle between them");
        Console.WriteLine("Choose a method to calculate the surface of the triangle: ");
        short myChoice = short.Parse(Console.ReadLine());

        double a = 0.0;
        double b = 0.0;
        double c = 0.0;
        double d = 0.0;
        double h = 0.0;

        switch (myChoice)
        {
            case 1:
                Console.Write("side: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("altitude: ");
                h = double.Parse(Console.ReadLine());
                Console.WriteLine("the surface is: {0}", CalcAreaWithAltitude(a, h));
                break;
            case 2:
                Console.Write("first side: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("second side: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("third side: ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("the surface is: {0}", CalcAreaWithSides(a, b, c));
                break;
            case 3:
                Console.Write("first side: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("second side: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("angle: ");
                d = double.Parse(Console.ReadLine());
                Console.WriteLine("the surface is: {0}", CalcAreaWithSidesAndAngle(a, b, d));
                break;
            default:
                Console.WriteLine("Something somewhere went terribly wrong!");
                break;
        }
    }

    //triangle surface is equal to 1/2 of side multiplied by hypotenuse
    static double CalcAreaWithAltitude(double side, double altitude)
    {
        double res = (side * altitude) / 2;
        return res;
    }

    //Heron's formula: S = sqrt(s(s-a)(s-b)(s-c))
    //where surface is half the perimeter of the triangle
    static double CalcAreaWithSides(double a, double b, double c)
    {
        double halfP = (a + b + c) / 2;
        double res = Math.Sqrt(halfP * (halfP - a) * (halfP - b) * (halfP - c));
        return res;
    }

    //triangle surface is equal to the multiplication of two 
    //of its sides and the angle locked between them
    static double CalcAreaWithSidesAndAngle(double a, double b, double degree)
    {
        double res = (a * b * Math.Sin((degree / 180) * Math.PI)) / 2;
        return res;
    }
}