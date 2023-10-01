using System;

namespace CodingZone
{
    public class CodingZone
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my Coding Zone");
            int num = Convert.ToInt32(Console.ReadLine());

            string monthName = NumberToMonth.MonthName(num);
            Console.WriteLine(monthName);
        }
       
    }
}
