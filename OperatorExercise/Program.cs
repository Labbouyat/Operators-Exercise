using System;

namespace OperatorExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int d = a / b;
            int e = a % b;
            if (a ==17 && b ==4)
            Console.WriteLine($"quotient: {d}");
            Console.WriteLine($"remainder: {e}");
        }
    }
}
