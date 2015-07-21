using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NBU_RPG
{
    class GameEngine
    {
        protected static int zombieAttackChance;
        protected static int playerAttackChance;
        protected static int playerHealth = 15;
        protected static int zombieHealth = 6;

        public static string choice1;

        public static int itemDMG;

        public static void Incorrect()
        {
            Console.Write("Dont be a mess... That is invalid entry, please try again: ");
            Console.Write("\n");
        }

        public static void pHealthCheck()
        {
            if (playerHealth < 0)
            {
                playerHealth = 0;
            }
        }

        public static void zHealthCheck()
        {
            if (zombieHealth < 0)
            {
                zombieHealth = 0;
            }
        }

        public static StringBuilder StoryLine(string a)
        {
            var sb = new StringBuilder();
            sb.Append(a);
            return new StringBuilder(sb.ToString());
        }
        // Random method for zombie and player attacks
        public static int randomNum(int chance, int max)
        {
            Random random = new Random();
            int randomNum = random.Next(2, 4);
            return randomNum;
        }
       
    }
}
