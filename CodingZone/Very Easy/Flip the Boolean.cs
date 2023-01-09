using System;
//2023/1/9
//Damian Grant Grobler
namespace FlipTheBoolean;

public class FlipTheBoolean
{
    public static bool Reverse(bool boolean)
    {
        if (boolean == true)
        {
            return false;
        }
        else if (boolean == false)
        {
            return true;
        }
        return boolean;
    }

    public static void MainLogic()
    {
        
    }
}

/*
Create a function that reverses a boolean value.


 */