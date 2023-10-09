//https://github.com/thanhdnh/DSA

class Program
{
    static void Swap<T>(ref T a, ref T b){
        T temp = a;
        a = b;
        b= temp;
    }
    static T Add<T>(T a, T b){
        try{
            int lenA = ((dynamic)a).Length;
            int lenB = ((dynamic)b).Length;
            if(a is System.String && b is System.String){
                return (dynamic)a + (dynamic)b;
            }else{
                T result = (dynamic)new double[lenA+lenB];
                int k = 0;
                for(int i=0; i<lenA; i++)
                    ((dynamic)result)[k++] = ((dynamic)a)[i];
                for(int i=0; i<lenB; i++)
                    ((dynamic)result)[k++] = ((dynamic)b)[i];
                return result;
            }
        }catch(Exception e){
            return (dynamic)a + (dynamic)b;
        }
    }
    public static string Arr2Str(int[] ar){
        string result = "";
        for(int i=0; i<ar.Length; i++)
            result += ar[i] + ", ";
        return result;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        /*int a = 5, b = 10;
        System.Console.WriteLine("{0}+{1}={2}", a, b, Add<int>(a, b));

        string s1 = "Before", s2 = "After";
        System.Console.WriteLine("{0}+{1}={2}", s1, s2, Add<string>(s1, s2));
        */

        double[] ar1 = {1, 2, 3};
        double[] ar2 = {4, 5};
        //System.Console.WriteLine(Arr2Str(ar1));
        //System.Console.WriteLine(Arr2Str(ar2));
        //System.Console.WriteLine(Arr2Str(Add<int[]>(ar1, ar2)));
        Timing counter = new Timing();
        counter.startTime();
        Add<double[]>(ar1, ar2);
        counter.StopTime();
        System.Console.WriteLine("Time: " + counter.Result());
        Console.ReadKey();
    }
}