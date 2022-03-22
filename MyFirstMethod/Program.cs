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
            Console.Write("Tell me a number:");
            int aux = int.Parse(Console.ReadLine());
            Console.Write("Tell me another number:");
            int aux2 = int.Parse(Console.ReadLine());
            CountToN(aux, aux2);
            //CountToN(aux/2);
            //CountTo10();
            //float var = GetRandomNumber();
            //Console.WriteLine(var);
            //ShowPlayerStatus(aux);
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
        private static void CountToN(int n1, int n2)
        {
            if(n1 != n2 && n1 > n2)
            {
                for (int i = n2 + 1; i < n1; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else if(n1 != n2 && n2 > n1)
            {
                for (int i = n1 + 1; i < n2; i++)
                {
                    Console.WriteLine(i);
                }

            }
            else
                Console.WriteLine("The numbers are equal!");
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
