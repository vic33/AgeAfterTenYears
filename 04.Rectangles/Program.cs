/*Problem 4. Rectangles
 * Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */

using System;

class Rectangles
{
    static void Main()
    {
        Console.Title = "Rectangles";
        Console.Write("Enter width: ");
        double width = double.Parse(Console.ReadLine());
        Console.Write("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double perimeter = 2 * (width + height);
        double area = width * height;
        Console.Clear();

        Console.WriteLine("Perimeter: {0}\nArea: {1}", perimeter, area);

    }
}
