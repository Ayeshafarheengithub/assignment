using System;
    namespace Assignment
{
    public class Interest
    {
        static double InterestAmount(double principalAmount, int numberOfyears, double rateOfinterest)
        {
            return ((principalAmount * numberOfyears * rateOfinterest) / 100);
        }

        static void readElementsFromConsole(ref double principalAmount, ref int numberOfyear, ref double rateOfinterest)
        {
            Console.WriteLine("Enter the principle Amount");
            principalAmount = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of year");
            numberOfyear = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the rate of interest");
            rateOfinterest = double.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            int numberOfyear = 0;
            double principalAmount = 0;
            double rateOfinterest = 0;
            readElementsFromConsole(ref principalAmount, ref numberOfyear, ref rateOfinterest);

            double interest = InterestAmount(principalAmount, numberOfyear, rateOfinterest);
            Console.WriteLine("interest amount is {0}", interest);
            Console.WriteLine("total with interest amount is{0}", principalAmount + interest);
        }
    }
    }