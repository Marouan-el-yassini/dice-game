using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int playerRandomNumb;
            int enenyRandomNumb;

            int playerScore = 0;
            int enemyScore = 0;

            Random random = new Random();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("press any key");
                Console.ReadKey();

                playerRandomNumb = random.Next(1,7);
                Console.WriteLine("your number is:"+playerRandomNumb);

                enenyRandomNumb = random.Next(1, 7);
                Console.WriteLine("the enemy number is:"+enenyRandomNumb);

                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);
                

                if (playerRandomNumb > enenyRandomNumb)
                {
                    playerScore++;
                    Console.WriteLine("you win in this round");
                   
                }
                else if (playerRandomNumb<enenyRandomNumb)
                {
                    enemyScore++;
                    Console.WriteLine("enemy win in this round");

                }
                else
                {
                    Console.WriteLine("draw");
                }

                if (playerScore<enemyScore)
                {
                    Console.WriteLine("you are win");
                }
                else if (playerScore > enemyScore)
                {
                    Console.WriteLine("enemy win");
                }
                else
                {
                    Console.WriteLine("the draw");
                }
            }

            Console.ReadKey();
        }
    }
}
