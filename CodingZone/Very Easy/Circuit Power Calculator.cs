using System;
//2023/1/9
//Damian Grant Grobler
namespace CircuitPowerCalculator;

public class CircuitPowerCalculator
{

    public static int CircuitPower(int v, int c) => v * c; //Lambda expression example
    public static string Test(string something, string somethingElse) => something + " with " + somethingElse;

    public static void MainLogic()
    {
        Console.WriteLine(Test("something", "something else"));

        Console.WriteLine(CircuitPower(2,6));
    }

}

/*
 My code
    delegate int Del(int v, int c);


        Console.WriteLine("Lambda expression example fiddling");

        Console.WriteLine("Please enter voltage");
        int voltage = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter current");
        int current = Convert.ToInt32(Console.ReadLine());

        Del del = (v, c) => v * c;
        int circuitPower = del(voltage, current);

        Console.WriteLine(circuitPower);

 */