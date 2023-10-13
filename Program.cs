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
    }
    public static void Main(string[] args)
    {
        Console.Clear();

        Array a = createMatrix(new int[]{2, 3}, new int[]{1, 1});
        Array b = createMatrix(new int[]{2, 3}, new int[]{1, 1});
        printMatrix(a);
        System.Console.WriteLine("----");
        printMatrix(b);
        System.Console.WriteLine("----");
        Array sum = addMatrices(a, b);
        printMatrix(sum);

        Console.ReadKey();
    }
}