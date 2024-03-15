public class Cw1 {
    public static void Main(string[] args) {
        //1. Primitive
        int g = 10;
        int h2 = g;
        //string = String
        //Nullable<int> = int?
        Console.WriteLine("Test Commit");
        Console.WriteLine("Commit v2");
        Console.WriteLine("Commit w IDE");


        //2. Complex
        //Student std;
        Console.WriteLine("Hello, World!");
    }

    public static void Calc(int a, int b) {
        int c = a + b;
        Console.WriteLine("hahaha");
    }

    public static double Avg(int[] input) {
        int sum = 0;
        foreach (int temp in input) {
            sum += temp;
        }

        return (double)sum / input.Length;
    }

    public static int Max(int[] input) {
        int output = input[0];
        foreach (int i in input)
            if (i > output)
                output = i;
        return output;
    }
}