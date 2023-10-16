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
        System.Console.WriteLine(queue.AddQueue());
        System.Console.WriteLine(queue.GetValue(1));
        System.Console.WriteLine(queue.GetValue(3));

        Console.ReadKey();
    }
}