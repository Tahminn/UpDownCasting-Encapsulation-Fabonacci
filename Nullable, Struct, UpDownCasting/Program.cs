using System;

public class Fibonacci
{
    public static int GoldenRatio(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return GoldenRatio(n - 1) + GoldenRatio(n - 2);
        }
    }


    public static void Main(string[] args)
    {
        int n = 11;
        Console.Write(GoldenRatio(n));
    }
}
class FIbonacci2
{

    static int GoldenRatio(int n)
    {

        int[] gratio = new int[n + 2];
        int i;

        gratio[0] = 0;
        gratio[1] = 1;

        for (i = 2; i <= n; i++)
        {
            gratio[i] = gratio[i - 1] + gratio[i - 2];
        }

        return gratio[n];
    }
    public static void Main()
    {
        int n = 11;
        Console.WriteLine(GoldenRatio(n));
    }
}