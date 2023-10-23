using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

public class Program
{
  public class Node
  {
    public object element;
    public Node link;
    public Node()
    {
      element = null;
      link = null;
    }
    public Node(object element)
    {
      this.element = element;
      link = null;
    }
  }
  public class LinkedList
  {
    public Node header;
    public LinkedList()
    {
      header = new Node("Header");
    }
    private Node Find(object element)
    {
      Node current = new Node();
      current = header;
      while (current.element != element)
        current = current.link;
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node current = new Node();
      Node newnode = new Node(newelement);
      current = Find(afterelement);
      newnode.link = current.link;
      current.link = newnode;
    }
    public Node FindPrev(object element)
    {
      Node current = header;
      while (current.link != null && current.link.element != element)
        current = current.link;
      return current;
    }
    public void Remove(object element)
    {
      Node current = FindPrev(element);
      if (current.link != null)
        current.link = current.link.link;
    }
    public void Print()
    {
      Node current = new Node();
      current = header;
      while (current.link != null)
      {
        Console.WriteLine(current.link.element);
        current = current.link;
      }
    }
    //Exercise
    public int FindMax(){
      Node current = header;
      int max = int.Parse(current.link.element.ToString());
      current = current.link;
      while(current.link!=null){
        if(int.Parse(current.link.element.ToString())>max){
          max = int.Parse(current.link.element.ToString());
        }
        current=current.link;
      }
      return max;
    }
    public double Average(){
      Node current = header;
      int count=1;
      current = current.link;
      double sum=double.Parse(current.element.ToString());
      while(current.link!=null)
      {
          double a = double.Parse(current.link.element.ToString());
          sum+=a;
          count++;
          current=current.link;
      }
      return sum/count;
    }
  }
  public class Node2
  {
    public object element;
    public Node2 flink, blink;
    public Node2()
    {
      element = null;
      flink = blink = null;
    }
    public Node2(object element)
    {
      this.element = element;
      flink = blink = null;
    }
  }

  public class DoubleLinkedList
  {
    public Node2 header;
    public DoubleLinkedList()
    {
      header = new Node2("Header");
    }
    private Node2 Find(object element)
    {
      Node2 current = new Node2();
      current = header;
      while (current.element != element)
      {
        current = current.flink;
      }
      return current;
    }
    public void Insert(object newelement, object afterelement)
    {
      Node2 current = new Node2();
      Node2 newnode = new Node2(newelement);
      current = Find(afterelement);
      newnode.flink = current.flink;
      newnode.blink = current;
      current.flink = newnode;
    }
    public void Remove(object element)
    {
      Node2 current = Find(element);
      if (current.flink != null)
      {
        current.blink.flink = current.flink;
        current.flink.blink = current.blink;
        current.flink = null;
        current.blink = null;
      }
    }
    private Node2 FindLast()
    {
      Node2 current = new Node2();
      current = header;
      while (!(current.flink == null))
        current = current.flink;
      return current;
    }
    public void Print()
    {
      Node2 current = new Node2();
      current = FindLast();
      while (!(current.blink == null))
      {
        Console.WriteLine(current.element);
        current = current.blink;
      }
    }

    //Exercise
    public int FindMax2()
    {
      Node2 current = header;
      current=current.flink;
      int Max= int.Parse(current.element.ToString());
      while(current.flink!=null)
      {
        int a = int.Parse(current.flink.element.ToString());
        if(a>Max)
          {
            Max=a;
          }
          current=current.flink;
      }
      return Max;
      
    }
  }
  static void Main()
  {
    Console.Clear();

    /*LinkedList list = new LinkedList();
    list.Insert("4", "Header");
    list.Insert("1", "4");
    list.Insert("9", "1");
    list.Insert("2", "9");
    list.Insert("3", "2");
    list.Print();
    Console.WriteLine("Max: {0}", list.FindMax());
    Console.WriteLine("Average: {0}", list.Average());*/

    /*DoubleLinkedList dlist = new DoubleLinkedList();
    dlist.Insert("72", "Header");
    dlist.Insert("45", "72");
    dlist.Insert("11", "45");
    dlist.Insert("40", "11");
    dlist.Insert("79", "40");
    dlist.Print();
    Console.WriteLine("Max2: {0}", dlist.FindMax2());
    */

    LinkedList<int> llnet = new LinkedList<int>();
    llnet.AddFirst(new LinkedListNode<int>(10));
    LinkedListNode<int> temp = new LinkedListNode<int>(11);
    llnet.AddLast(temp);
    llnet.AddAfter(temp, new LinkedListNode<int>(99));
    llnet.AddBefore(temp, new LinkedListNode<int>(999));
    foreach(int v in llnet)
      System.Console.Write(v + " ");
    System.Console.WriteLine();

    Console.ReadLine();
  }
}