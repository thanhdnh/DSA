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

        Stack st = new Stack();
        st.Push(1);
        st.Push("hello");

        Stack<int> sti = new Stack<int>();
        sti.Push(1); sti.Push(0);

        Queue myqueue = new Queue();
        myqueue.Enqueue(1); myqueue.Enqueue("Hello");

        Queue<float> queuef = new Queue<float>();
        queuef.Enqueue(1.2f);

        Console.ReadKey();
    }
}