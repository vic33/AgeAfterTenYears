/*Problem 6. Four-Digit Number
 * Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
 * Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
 * Prints on the console the number in reversed order: dcba (in our example 1102).
 * Puts the last digit in the first position: dabc (in our example 1201).
 * Exchanges the second and the third digits: acbd (in our example 2101).
 * The number has always exactly 4 digits and cannot start with 0.
 */

using System;

class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Enter a four-digit number (etc.2015): ");
        string number = Console.ReadLine();

        int a = (int)char.GetNumericValue(number[0]);
        int b = (int)char.GetNumericValue(number[1]);
        int c = (int)char.GetNumericValue(number[2]);
        int d = (int)char.GetNumericValue(number[3]);

        int sumOfDigits = a + b + c + d;
        Console.WriteLine("Sum of digits: {0}", sumOfDigits);

        Console.WriteLine("Reversed: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in front: {0}{1}{2}{3}", d, a, b, c);
        Console.WriteLine("Second and third digits exchanged: {0}{1}{2}{3}", a, c, b, d);
    }
}
