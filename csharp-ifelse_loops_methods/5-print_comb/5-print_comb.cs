using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        
        for (int i = 0; i <= 99; i++)
        {
            output += i.ToString("00");
            if (i < 99)
            {
                output += ", ";
            }
        }
        
        Console.Write(output);
        Console.Write("\n");
    }
}
