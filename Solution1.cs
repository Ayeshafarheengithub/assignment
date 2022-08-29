using System;
namespace Assignment
{

    class ConsoleApp2
    {
        static void Main()
        {
            displayRanges();
        }

        private static void displayRanges()
        {
            Console.WriteLine($"The range of int is {int.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of double is {double.MinValue} and {double.MaxValue}");
            Console.WriteLine($"The range of float is {float.MinValue} and {int.MaxValue}");
            Console.WriteLine($"The range of decimal is {int.MinValue} and {int.MaxValue}");
        }
    }
}