using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;

class Program
{
    public static int SeqSearch(int[] arr, int value){
        for(int i=0;i<arr.Length;i++)
        {
            if(value==arr[i])
            {
                return i;
            }
            
        }
        return -1;
    }
    public static int SeqSearchLast(int[] arr, int value){
        for(int i=arr.Length-1;i>=0;i--)
        {
            if(value==arr[i])
            {
                return i;
            }
            
        }
        return -1;
    }
    public static int RecuSearch(int[] arr, int index,int value){
        if(index>=arr.Length)
        {
            return -1;
        }
        if(value==arr[index])
        {
            return index;
        }
        return RecuSearch(arr,index+1,value);
    }
    public static int SenSearch(int[] arr ,int value){
        int x = arr[arr.Length-1];
        arr[arr.Length-1]=value;
        int i = 0;
        while(arr[i]!=value){
            i++;
        }
        arr[arr.Length-1]=x;
        if(i<arr.Length-1 || arr[arr.Length-1]==value) return i;
        else return -1;
    }
    public static int BinSearch(int[] sortedarr, int value){
        int left = 0, right = sortedarr.Length -1;
        while(left<=right){
            int mid = (left+right)/2;
            if(sortedarr[mid] == value) return mid;
            else if(sortedarr[mid]<value) left = mid+1;
            else right = mid-1;
        }
        return -1;
    }
    public static int BinSearchRecu(int[] sortedarr, int value, 
                                            int left, int right){
        if(left<=right)
        {
            int mid=(right+left)/2;
            if(sortedarr[mid]==value)
                return mid;
            else if(sortedarr[mid]<value)
                BinSearchRecu(sortedarr,value,mid+1,right);
            else
                BinSearchRecu(sortedarr,value,left,mid-1);
        }
        return -1;
    }
    public static int BinSearch2(int[] unsortedarr, int value){
        int[] sortedarr = (int[])unsortedarr.Clone();
        int[] indices = new int[sortedarr.Length];
        for(int i=0; i<indices.Length; i++)
            indices[i] = i;
        for(int i=0; i<sortedarr.Length-1; i++)
            for(int j=i+1; j<sortedarr.Length; j++)
                if(sortedarr[i]>sortedarr[j]){
                    int temp = sortedarr[i];
                    sortedarr[i] = sortedarr[j];
                    sortedarr[j] = temp;
                    int tindex = indices[i];
                    indices[i] = indices[j];
                    indices[j] = tindex;
                }
        int result = BinSearch(sortedarr, value);
        return (result<0)?(-1):(indices[result]);
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        int[] a={3, 9, 2, 8, 7};
        int result=BinSearch2(a, 8);
        Console.WriteLine(result + "\n");

        for(int i=0; i<a.Length; i++)
            Console.WriteLine(a[i] + ", ");

        Console.ReadLine();
    }
}