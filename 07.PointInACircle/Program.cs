/*Problem 7. Point in a Circle
 * Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */

using System;

class PointInACircle
{
    static void Main()
    {
        Console.Title = "Point in a Circle";
        Console.Write("Enter number \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter number \"y\": ");
        double y = double.Parse(Console.ReadLine());
        byte radius = 2;

        bool inside = (x * x) + (y * y) <= radius * radius;

        Console.WriteLine("Inside: {0}", inside);
    }
}
