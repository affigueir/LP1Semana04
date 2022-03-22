using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {   
            int aux;
            if(args.Length > 0)
            {
                aux = int.Parse(args[0]);
            }
            else
            {
                Console.Write("Insira um número: ");
                aux = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(Fibonacci(aux));
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
    


