using System;
using System.Linq;
using static System.Math;
//2023/1/9
//Damian Grant Grobler
namespace absValue;

public class absValue
{
    //return the absolute value of the sum of the array.{
    public static int GetAbsSum(int[] arr)
    {
        //return arr.Select(Math.Abs).Sum(); //To calculate the absolute value of the sum of an int array. Math.Abs

        return arr.Sum(n => Abs(n));
    }




public static void MainLogic()
    {
        int[] array1 = new int[] { 1, -3, 5, -7, 9 };

        Console.WriteLine(GetAbsSum(array1));

    }
}

/*
 My code

        public static int GetAbsSum(int[] arr)
        {
        int sum = 0;
        foreach (int i in arr)
        {
            if (i < 0)
            {
                Math.Abs(i);
                sum += i * -1;
            }
            if (i >= 0)
            {
                Math.Abs(i);
                sum += i;
            }

        }
        return sum;
    }
 */