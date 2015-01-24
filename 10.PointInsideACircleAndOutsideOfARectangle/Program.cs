/*Problem 10. Point Inside a Circle & Outside of a Rectangle
 * Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */

using System;

class PointInsideCircleOutsideRectangle
{
    static void Main()
    {
        Console.Title = "Point inside a circle & Outside of a rectangle";
        Console.Write("Enter number \"x\": ");
        double x = double.Parse(Console.ReadLine());
        Console.Write("Enter number \"y\": ");
        double y = double.Parse(Console.ReadLine());
        // (x - center_x)^2 + (y - center_y)^2 < radius^2.
        bool isInCirle = (Math.Pow(x - 1, 2) + Math.Pow(y - 1, 2)) <= Math.Pow(1.5, 2);
        bool outOfRectngle = x > 1 && x <= 5 && y > -1 && y <= 1;

        if (isInCirle == true && outOfRectngle != true)
        {
            Console.WriteLine("inside K & outside of R: yes");
        }
        else
        {
            Console.WriteLine("inside K & outside of R: no");
        }
    }

}
