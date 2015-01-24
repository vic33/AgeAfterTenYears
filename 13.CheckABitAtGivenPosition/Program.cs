/*Problem 13. Check a Bit at Given Position
 * Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) in given integer number n, has value of 1.
 */

using System;

class CheckBitAtPosition
{
    static void Main()
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());

        int mask = 1 << position;
        int numberAndMask = (int)number & mask;
        int bit = (int)numberAndMask >> position;

        Console.WriteLine("Is bit at position {0} in number {1} - 1?", position, number);
        Console.WriteLine(Convert.ToBoolean(bit) ? "Yes" : "No");
    }
}
