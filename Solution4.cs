using System;
namespace Assignment
{
    public class OddEven4
    {
        static void isOddOrEven(int[] numberArr)
        {
            int oddSum = 0;
            int evenSum = 0;

            for (int i = 0; i < numberArr.Length; i++)
            {
                if (numberArr[i] % 2 == 0)

                    evenSum += numberArr[i];
                else
                    oddSum += numberArr[i];
            }

            Console.WriteLine("sum of even number is {0}\n sum of odd number is {1}", evenSum, oddSum);
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


