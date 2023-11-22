using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Player
    {
        private int health = 20;
        private int baseDamage = 1;
        private string name;
        private int levelsCompletedThisStage = 0;
        private int levelsCompletedTotal = 0;

        private Inventory inventory;
        public Player(string name)
        {
            this.name = name;
            inventory = new Inventory();
        }

        public void LevelCompleted()
        {
            levelsCompletedThisStage++;
            levelsCompletedTotal++;
            baseDamage++;
            health += 2;
        }

        public int GetLevelsCompleted() => levelsCompletedThisStage;
        

        public string GetName() => name;


        public void ResetLevelsCompleted() => levelsCompletedThisStage = 0;

        public string PrintInventory() => inventory.InventoryToString();
        
    }
}
