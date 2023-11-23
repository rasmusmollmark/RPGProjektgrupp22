using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    internal class Dungeon
    {
        private List<string> dungeonNameList = new List<string>() { "Ice Dungeon", "Fire Dungeon", "Noob Dungeon", "Water dungeon"};
        private Random rnd = new Random();
        private int dungeonsCleared = 0;
        private int dungeonIndex;
        private bool explored = false;
        public bool Explored 
        {
            get { return explored; }
        }
        public Dungeon(int i)
        {
            dungeonIndex = i;
            Console.WriteLine("A dungeon named" + dungeonNameList[i] + " has been created");
        } 
        public bool Explore (Player player)
        {
            int randomOutcome = rnd.Next(1, 10);
            if (explored)
            {
                Console.WriteLine("This dungeon has already been explored");
                return false;
            }
            if (randomOutcome < 6) 
            {
                Console.WriteLine("You encounter an enemy");
                EncounterEnemy();
                //Console.WriteLine("You are in the" + dungeonNameList[dungeonIndex]);
            }

            else
            {
                Console.WriteLine("You found a chest!");
                FindChest();
                //Console.WriteLine("You are in the" + dungeonNameList[dungeonIndex]);
            }
            explored = true;
            return true;


        }

        public string GetDungeonName()
        {
            return dungeonNameList[dungeonIndex];
        }

        private void EncounterEnemy()
        {
            Console.WriteLine("You have encountered an enemy!");
            Console.WriteLine("You fought fiercely and succeded!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();


        }

        private void FindChest()
        {
            Console.WriteLine("You found a chest with items!");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();



        }
        private void GoToNextStage(Player player)
        {
            Console.WriteLine("Congratulations, " + player.GetName() + "! You have completed " + player.GetLevelsCompleted() + " dungeons and advanced to the next stage.");

            // Återställ räknaren för klarade dungeons för nästa omgång
            player.ResetLevelsCompleted();
        }

    }
}
