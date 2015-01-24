/*Problem 11. Bitwise: Extract Bit #3
 * Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
 * The bits are counted from right to left, starting from bit #0.
 * The result of the expression should be either 1 or 0.
 */

using System;

class ExtractBitNumber3
{
    static void Main()
    {
        Console.Title = "Problem 11. Bitwise: Extract Bit #3";
        Console.Write("Input positive number : ");
        uint n = uint.Parse(Console.ReadLine());
        if (n >= 0)
        {
            uint bit = (n >> 3) & 1;
            Console.WriteLine("Binary representation: {0}", Convert.ToString(n, 2).PadLeft(32, '0'));
            Console.WriteLine("Bit #3 is: {0}", bit);
        }
        else
        {
            Console.WriteLine("Invalid value!");
        }
    }
}

