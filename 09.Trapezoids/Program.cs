/*Problem 9. Trapezoids
 * Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */

using System;

class Trapezoids
{
    static void Main()
    {
        Console.Title = "Area of trapezoids";
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());

        double areaOfTrapezoids = ((firstNumber + secondNumber) * thirdNumber) / 2;

        Console.WriteLine("Area of trapezoids: {0}", areaOfTrapezoids);
    }
}