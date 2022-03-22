using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a number:");
            int aux = int.Parse(Console.ReadLine());
            CountToN(aux);
            CountToN(aux/2);
            float var = GetRandomNumber();
            Console.WriteLine(var);
            ShowPlayerStatus(aux);
        }

        private static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        // Testing Return
        private static float GetRandomNumber()
        {
            return 4.123f;
        }

        //Void Returning Test
        private static void ShowPlayerStatus(int livesLeft)
        {
            /*
            if (livesLeft == 0)
                return;
            Console.WriteLine("Player is alive and well!");
            */
            if (livesLeft > 0)
                Console.WriteLine("Player is alive and well!");
        }
    }
}
