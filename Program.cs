using System.Collections;
using System.Collections.Generic;

class Program
{
    static Array createMatrix(int[] lengths, int[] lowerbounds){
        Array matrix = Array.CreateInstance(typeof(Single), 
                                    lengths, 
                                    lowerbounds
                                    );
        Random r = new Random();
        for(int i=matrix.GetLowerBound(0); i<=matrix.GetUpperBound(0); i++)
            for(int j=matrix.GetLowerBound(1); j<=matrix.GetUpperBound(1);j++)
                matrix.SetValue(r.NextSingle(), i, j);
        return matrix;
    }
    static Array addMatrices(Array a, Array b){
        Array c = (Array)a.Clone();
        for(int i=c.GetLowerBound(0); i<=c.GetUpperBound(0); i++)
            for(int j=c.GetLowerBound(1); j<=c.GetUpperBound(1);j++)
                c.SetValue((float)a.GetValue(i,j)+(float)b.GetValue(i,j), i, j);
        return c;
    }
    static void printMatrix(Array x){
        for(int i=x.GetLowerBound(0); i<=x.GetUpperBound(0); i++){
            for(int j=x.GetLowerBound(1); j<=x.GetUpperBound(1);j++)
                Console.Write("{0, 15}", x.GetValue(i, j));
            Console.WriteLine();
        }
        System.Console.WriteLine("\n====\n");
    }
    static Array createSparseMatrix(Array x){
        Array c = (Array)x.Clone();
        for(int i=c.GetLowerBound(0); i<=c.GetUpperBound(0); i++)
            for(int j=c.GetLowerBound(1); j<=c.GetUpperBound(1);j++)
                if(i!=j)
                    c.SetValue(0f, i, j);
        return c;
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        /*Array a = createMatrix(new int[]{4, 4}, new int[]{1, 1});
        Array b = createMatrix(new int[]{4, 4}, new int[]{1, 1});
        printMatrix(a);
        printMatrix(b);
        
        Array sum = addMatrices(a, b);
        printMatrix(sum);

        printMatrix(createSparseMatrix(a));*/

        /*List<float> list = new List<float>();
        list.Add(1.2f);
        list.AddRange(new float[]{2f, 3f, 5f});
        List<float>.Enumerator en = list.GetEnumerator();
        while (en.MoveNext())
            Console.WriteLine(en.Current);


        ArrayList arl = new ArrayList();
        arl.Add(3); arl.Add(5);
        float s = (int)arl[0] + (int)arl[1];
        System.Console.WriteLine(s);*/

        Array course = Array.CreateInstance(typeof(Course), 5);
        course.SetValue(new Course("DSA", 7.4f), 0);
        course.SetValue(new Course("OOP", 7.3f), 1);

        Console.ReadKey();
    }
}