using System.Diagnostics;

public class MyQueue
{
    Node2 rear, front; 
    public bool IsEmpty()
    {
        return rear == null || front == null;
    }
    public void Enqueue(object ele)
    {
        Node2 n = new Node2();
        n.data = ele;
        if (rear == null)
        {
            rear = n; front = n;
        }
        else
        {
            rear.prev = n;
            n.next = rear; rear = n;
        }
    }
    public Node2 Dequeue()
    {
        if (front == null) return null;
        Node2 d = front;
        front = front.prev;
        if (front == null)
            rear = null;
        else
            front.next = null;
        return d;
    }
    public double AddQueue(){
        double sum = 0;
        Node2 current = front;
        while(current!=null){
            double temp = (double)current.data;
            sum += temp;
            current = current.prev;
        }
        return sum;
    }
    public object GetValue(int i){
        Node2 current = front;
        int index = 0;
        while(current!=null){
            if(i==index)
                return current.data;
            index++;
            current = current.prev;
        }
        return null;
    }
}