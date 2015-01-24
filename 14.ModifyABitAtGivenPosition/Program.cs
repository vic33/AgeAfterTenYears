/*Problem 14. Modify a Bit at Given Position
 * We are given an integer number n, a bit value v (v=0 or 1) and a position p.
 * Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */

using System;

class ModifyBitAtPosition
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value: ");
        int newBitValue = int.Parse(Console.ReadLine());

        int result;

        if (newBitValue == 1)
        {
            int mask = 1 << position;
            result = (int)number | mask;
        }
        else
        {
            int mask = ~(1 << position);
            result = (int)number & mask;
        }

        Console.WriteLine("\n{0} --> {1}\n", number, result);
        Console.WriteLine(Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine(Convert.ToString(result, 2).PadLeft(32, '0'));
    }
}
