using System;
using Enemies;

class Program
{
    static void Main(string[] args)
    {
        Enemies.Zombie newObject = new Enemies.Zombie();
        Console.WriteLine($"newObject is of type {newObject.GetType()}");
        Console.WriteLine($"String representation: {newObject.ToString()}");
    }
}
