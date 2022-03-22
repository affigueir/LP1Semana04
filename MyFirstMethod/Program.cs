using System;

namespace MyFirstMethod
{
    class Program
    {
        /// <summary>
        /// Method testing main 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Tell me a number:");
            int aux = int.Parse(Console.ReadLine());
            CountToN(aux);
            CountToN(aux/2);
            CountTo10();
            float var = GetRandomNumber();
            Console.WriteLine(var);
            ShowPlayerStatus(aux);
        }
        /// <summary>
        /// Asks for value and counts to it
        /// </summary>
        /// <param name="n"></param>
        private static void CountToN(int n)
        {
            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine(i);
            }
        }
        /// <summary>
        /// Counts to 10
        /// </summary>
        private static void CountTo10()
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        // Testing Return
        private static float GetRandomNumber()
        {
            return 4.123f;
        }

        /// <summary>
        /// Void Returning Test
        /// </summary>
        /// <param name="livesLeft"></param>
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
