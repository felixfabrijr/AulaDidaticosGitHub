 using System;

namespace ConsoleApp2
{

    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (var i in Fibonacci().Take(20))
            {
                Console.WriteLine(i);
            }
        }

        private static IEnumerable<int> Fibonacci()
        {
            int current = 1, next = 1;

            while (true)
            {
                yield return current;
                next = current + (current = next);
            }
        }
    }
}

