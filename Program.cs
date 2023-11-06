using System.Collections;
using System.ComponentModel;
using System.Runtime.Intrinsics.Arm;

public class Program
{
  static void Main()
  {
    Console.Clear();

    LocationDictionary ld = new LocationDictionary();
    ld.Add("001", new Location("HCM", 10000000, 9000));
    ld.Add("002", new Location("HN", 8000000, 8000));
    ld.Add("003", new Location("DN", 1000, 8000));

    IDictionaryEnumerator e = ld.GetEnumerator();
    while(e.MoveNext())
      Console.WriteLine($"{e.Key}=>{e.Value}");

    //============
    Dictionary<string, Location> mydic = 
                  new Dictionary<string, Location>();
    mydic.Add("001", new Location("HCM", 10, 9000));
    mydic.Add("002", new Location("HN", 8, 8000));
    mydic.Add("003", new Location("DN", 1, 8000));
    foreach(KeyValuePair<string, Location> v in mydic)
      Console.WriteLine($"{v.Key}=>{v.Value}");

    Console.ReadLine();
  }
}