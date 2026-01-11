using System;

class Program
{
    static void Main(string[] args)
    {
        string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# is an object-oriented programming language.";
        str = str.Substring(49, 21) + str.Substring(114, 4) + str.Substring(142, 3);
        Console.WriteLine(str);
    }
}
