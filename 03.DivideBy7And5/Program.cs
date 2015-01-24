/* Problem 3. Divide by 7 and 5
 * Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */

using System;

class DivideBySevenAndFIve
{
    static void Main()
    {
        Console.Title = "Divide by 7 and 5";
        Console.Write("Please enter a number (positive): ");
        int number = int.Parse(Console.ReadLine());
        Console.Clear();

        bool result = number % 7 == 0 && number % 5 == 0 && number != 0;
        Console.WriteLine(result);
    }
}
