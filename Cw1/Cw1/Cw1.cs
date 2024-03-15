// See https://aka.ms/new-console-template for more information

namespace Cw1;

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
        foreach (int e in input) {
            sum += e;
        }

        return (double)sum / input.Length;
    }
}