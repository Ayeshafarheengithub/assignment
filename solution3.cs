using System;
namespace Assignment
{
    class Operators
    {
        static void processFunc(double value1, double value2, string operation)
        {
            switch (operation)
            {
                case "+":
                    Console.WriteLine($"The added value is {value1 + value2}");
                    break;
                case "-":
                    Console.WriteLine($"The Subtracted value is {value1 - value2}");
                    break;
                case "X":
                    Console.WriteLine($"The Multiplied value is {value1 * value2}");
                    break;
                case "/":
                    Console.WriteLine($"The Divided value is {value1 / value2}");
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }
        }

        static double inputDouble(string question)
        {
            Console.WriteLine(question);
            return double.Parse(Console.ReadLine());
        }
        static string inputString(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine();
        }

        static void Main(string[] args)
        {
            var value1 = inputDouble("Enter the first value");
            var value2 = inputDouble("Enter the second value");
            var choice = inputString("Enter the choice as +, - X or /");
            processFunc(value1, value2, choice);
        }
    }
}
