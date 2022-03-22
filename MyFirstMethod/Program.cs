using System;

namespace MyFirstMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            CountTo10();
            CountTo10();
            float var = GetRandomNumber();
            Console.WriteLine(var);
            ShowPlayerStatus(1);
        }

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
