using System;

class Program
{
    static void Main(string[] args)
    {
        Queue<int> myIntQ = new Queue<int>();

        myIntQ.Enqueue(100);
        myIntQ.Enqueue(101);
        Console.WriteLine("Number of nodes in queue: " + myIntQ.Count());
    }
}