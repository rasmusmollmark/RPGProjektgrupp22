using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Player : Character
    {
        public int health { get; set; }
        public int damage { get; set;}
        public string name { get; set; }
        public bool isDead { get; set; }

        private int levelsCompletedThisStage = 0;
        private int levelsCompletedTotal = 0;

        private Inventory inventory;


        public Player(string name)
        {
            this.name = name;
            inventory = new Inventory();
            damage = 1;
            isDead = false;
        }

        public void LevelCompleted()
        {
            levelsCompletedThisStage++;
            levelsCompletedTotal++;
            damage++;
            health += 2;
        }

        public int GetLevelsCompleted() => levelsCompletedThisStage;
        

        public string GetName() => name;


        public void ResetLevelsCompleted() => levelsCompletedThisStage = 0;

        public string PrintInventory() => inventory.InventoryToString();

        public void takeDamage(int damage)
        {
            health -= damage;
            if(health < 0)
            {

            }
        }
    }
}
