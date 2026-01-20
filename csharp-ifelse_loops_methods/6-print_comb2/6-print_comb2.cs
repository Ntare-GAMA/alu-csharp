using System;

class Program
{
    static void Main(string[] args)
    {
        string output = "";
        
        for (int i = 0; i < 9; i++)
        {
            for (int j = i + 1; j <= 9; j++)
            {
                output += i.ToString() + j.ToString();
                if (!(i == 8 && j == 9))
                {
                    output += ", ";
                }
            }
        }
        
        Console.Write(output);
        Console.WriteLine();
    }
}
