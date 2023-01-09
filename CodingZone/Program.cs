using System;

namespace CodingZone // Note: actual namespace depends on the project name.
{
    internal class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            int baseNum = 0;
            int heightNum = 0;
            int calculation = (baseNum * heightNum) / 2;

            Console.WriteLine("Please enter the base of the triangle.");
            baseNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the height of the triangle.");
            heightNum = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(calculation);
        }
    }
}
