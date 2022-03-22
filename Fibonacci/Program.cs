using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insira um número: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(Fibonacci(num));
        }

        private static int Fibonacci(int n)
        {   
            if (n >= 2) return Fibonacci(n - 1) + Fibonacci(n - 2);
            
            return 1;
        }

        private static int Factorial(int n)
        {
            if (n > 1) return Factorial(n - 1) * n;
            return 1;
        }
    }
}
    


