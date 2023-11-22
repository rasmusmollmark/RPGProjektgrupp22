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
        public Dungeon(int i)
        {
            Console.WriteLine("A dungeon named" + dungeonNameList[i] + " has been created");
        } 
        public void Explore()
        {
            int randomOutcome = rnd.Next(1, 10);

            if (randomOutcome > 6) 
            {
                Console.WriteLine("You encounter an enemy");
            }

            else
            {
                Console.WriteLine("You found a chest!");
            }
        }

        private void EncounterEnemy()
        {
            Console.WriteLine("You have encountered an enemy!");
            
        }

        private void FindChest()
        {
            Console.WriteLine("You found a chest with items!");



        }
        private void GoToNextStage(Player player)
        {
            Console.WriteLine("Congratulations, " + player.GetName() + "! You have completed " + player.GetLevelsCompleted() + " dungeons and advanced to the next stage.");

            // Återställ räknaren för klarade dungeons för nästa omgång
            player.ResetLevelsCompleted();
        }

    }
}
