using System;
//2023/1/9
//Damian Grant Grobler
namespace ConvertMinutesintoSeconds;

public class ConvertMinutesintoSeconds
{

    public static int convert(int minutes) => minutes*60;

    public static void MainLogic()
    {
        Console.WriteLine("Enter amount of minutes to convert");
        int userinput = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine(convert(userinput));
    }
}