using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Player : Character
    {

        private int levelsCompletedThisStage = 0;
        private int levelsCompletedTotal = 0;

        private Inventory inventory;


        public Player(string name) : base(name, 50, 1)
        {
            inventory = new Inventory();
        }

        public void LevelCompleted()
        {
            levelsCompletedThisStage++;
            levelsCompletedTotal++;
            damage++;
            health += 2;
        }

        public int GetLevelsCompleted() => levelsCompletedThisStage;
        
        public void ResetLevelsCompleted() => levelsCompletedThisStage = 0;

        public string PrintInventory() => inventory.InventoryToString();

        
    }
    
}
