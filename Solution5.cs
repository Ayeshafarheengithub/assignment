using System;
    namespace Assignment
{
    public class OddOrEven
    {
        static double InterestAmount(double principalAmount, int numberOfyears, double rateOfinterest)
            {
            return ((principalAmount * numberOfyears * rateOfinterest) / 100);
    }

        static void readElementsFromConsole(ref double principalAmount,ref double numberOfinterest, ref double rateOfinterest)
        {
            Console.WriteLine("Enter the principle Amount");
            principalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of year");
            numberOfinterest = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate oif interest");
            rateOfinterest = double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int numberOfyear = 0;
            double,princip
        }
    }