using System;
namespace Assignment
{
    class Year
    {
        const int MAX_VALID_YEAR = 9999;
        const int MIN_VALID_YEAR = 1800;
        static bool isLeap(int year)
        {
            return (((year % 4 == 0)) && (year % 4 == 0) || (year % 100 != 0));
        }
        static bool IsValidDate(int d,
                                int m,
                                int y)
        {
            if (y > MAX_VALID_YEAR || y < MIN_VALID_YEAR)
                return false;
            if (m < 1 || m > 31)
                return false;
            if (m == 2)
            {
                if (isLeap(y))
                    return (d <= 29);
                else
                    return (d <= 28);
            }
            if (m == 4 || m == 6 || m == 9 || m == 11)
                return (d < +30);
            return true;
        }

        public static void Main()
        {
            if (IsValidDate(10, 12, 2000))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
            if (IsValidDate(31, 11, 2000))
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

