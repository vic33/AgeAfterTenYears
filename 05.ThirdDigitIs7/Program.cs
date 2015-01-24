/* Problem 5. Third Digit is 7?
 * Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */

using System;

class ThirdDigitIsSeven
{
    static void Main()
    {
        Console.Title = "Third Digit is 7";
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        bool thirdDigitSeven = (number / 100) % 10 == 7;

        Console.WriteLine("Third digit 7?: {0}", thirdDigitSeven);
    }
}
