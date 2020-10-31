using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int days_in_week= 7;
            Console.WriteLine(days_in_week);
            double weeks_in_year= 52.3;
            System.Console.WriteLine(weeks_in_year);
            double days_in_year = days_in_week * weeks_in_year;
            System.Console.WriteLine(days_in_year);
        }
    }
}
