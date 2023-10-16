using System.Collections;
using System.Collections.Generic;

class Program
{

    public static void Main(string[] args)
    {
        Console.Clear();

        MyQueue queue = new MyQueue();
        queue.Enqueue(1.0);
        queue.Enqueue(2.0);
        queue.Enqueue(3.0);
        

        Console.ReadKey();
    }
}