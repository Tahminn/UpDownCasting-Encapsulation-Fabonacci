using System;

namespace FibonacciSequence__GoldenRatio_
{    
    class FIbonacci
    {

        public static int GoldenRatio(int n)
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
}
