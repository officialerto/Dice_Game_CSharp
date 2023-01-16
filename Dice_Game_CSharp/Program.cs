using System;

namespace Dice_Game_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNum;
            int enemyRandomNum;

            int playerPoints = 0;
            int enemyPoints = 0;

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Press Any Key to Roll the Dice.");
                Console.ReadKey();
                Console.WriteLine("");
                playerRandomNum = random.Next(1, 7);

                Console.WriteLine("You rolled a " + playerRandomNum);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = random.Next(1, 7);
                Console.WriteLine("Enemy AI rolled a " + enemyRandomNum);
                Console.WriteLine("");

                if (enemyRandomNum > playerRandomNum)
                {
                    enemyPoints++;
                }
                else if (enemyRandomNum < playerRandomNum)
                {
                    playerPoints++;
                }

                Console.WriteLine("ENEMY: " + enemyPoints);
                Console.WriteLine("PLAYER: " + playerPoints);

                if (enemyPoints > playerPoints)
                {
                    Console.WriteLine("-------------- ENEMY WIN!! --------------");
                    Console.WriteLine("");
                }
                else if (enemyPoints < playerPoints)
                {
                    Console.WriteLine("-------------- PLAYER WIN!! --------------");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("-------------- DRAW!! --------------");
                    Console.WriteLine("");
                }
            }

            Console.ReadKey();

        }
    }
}
