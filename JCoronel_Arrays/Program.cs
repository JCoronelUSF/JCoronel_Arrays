using System.Globalization;

namespace JCoronel_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] fibonacci = new int[25];

            for (int i = 0; i < 25; i++)
            {
                if (i < 25)
                {
                    fibonacci[i] = i;
                }

                if (i >= 2)
                {
                   fibonacci[i] = fibonacci[i - 1] + fibonacci[i - 2];
                }
            }

            int ix = 0;
            foreach (int number in fibonacci)
            {
                Console.WriteLine("Fibonacci number (" + ix + ") = " + fibonacci[ix]);
                ix++;
            }
        }
    }
}