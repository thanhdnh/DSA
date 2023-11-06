using System.Collections;

class LocationDictionary:DictionaryBase{
    public void Add(string code, Location location){
        base.InnerHashtable.Add(code, location);
    }
    public Location Item(string code){
        return (Location)base.InnerHashtable[code];
    }
    public void Remove(string code){
        base.InnerHashtable.Remove(code);
    }
}