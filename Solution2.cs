using System;
namespace Assignment
{
    public class OddAndEven
    {
        static void isOddOrEven(int[] numberArr)
        {
            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] % 2 == 0)
                    Console.WriteLine(numberArr[i] + "is even");
                else
                    Console.WriteLine(numberArr[i] + "is Odd");
            }
        }
        static int[] readElementsFromConsole()
        {
            Console.WriteLine("Enter the size of the array");
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];

            Console.WriteLine("Enter the odd and Even number");
            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            return arr;
        }

        public static void Main(string[] args)
        {
            int[] arr = readElementsFromConsole();
            isOddOrEven(arr);

        }
    }
}


