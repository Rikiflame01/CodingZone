using System;
//2023/1/9
//Damian Grant Grobler
namespace AreaOfTriangle; //Change the namespace to CodingZone to run test it from program.cs remember it's a class function so for example this will be AreaOfTriangle.Mainlogic();

public class AreaOfTriangle
{


    public static int TriArea(int b, int h)
    {
        return b * h / 2;

    }


    public static void MainLogic()
    {
        Console.WriteLine("Please enter the base of the triangle");
        int baseInt = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please enter the height of the triangle");
        int heightInt = Convert.ToInt32(Console.ReadLine());

        TriArea(baseInt, heightInt);
        double area = TriArea(heightInt, baseInt); //You can do this??
        Console.WriteLine($"{area}"); //Learned that $"{}" converts it to an interpolated string (ToString representations of the expressions' results)
    }
}