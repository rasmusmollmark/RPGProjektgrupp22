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
        private int gold = 10;
        private int xp = 0;
        private int xpToNextLevel = 20;
        private int level = 1;

        private Inventory inventory;


        public Player(string name) : base(name, 100, 20, 20, 15, 10)
        {
            inventory = new Inventory();
        }

        

        public void RecieveLoot(Loot loot, int xpGiven)
        {
            gold += loot.Gold;
            inventory.AddItemToInventory(loot.Item);
            xp += xpGiven;
            CheckIfLevelUp();
        }

        private void CheckIfLevelUp()
        {
            if(xp > xpToNextLevel)
            {
                LevelUp();
            }
        }

        private void LevelUp()
        {
            xp -= xpToNextLevel;
            level++;
            xpToNextLevel *= 2;
            PrintLevelUp();
        }

        private void PrintLevelUp()
        {
            Console.WriteLine("Level up!\n"
                +name +" is now level "+ level+". \n" +
                "Xp needed for next level: (" +xp+"/"+xpToNextLevel+")");
        }

        public void RecieveLoot(Loot loot)
        {
            gold += loot.Gold;
        }


        public void LevelCompleted()
        {
            levelsCompletedThisStage++;
            levelsCompletedTotal++;
            damage++;
            Health += 2;
        }

        public int GetLevelsCompleted() => levelsCompletedThisStage;
        
        public void ResetLevelsCompleted() => levelsCompletedThisStage = 0;

        public string PrintInventory() => "\nHitpoints: " + Health + "\n" + "Gold: "+ gold + "\n" + inventory.InventoryToString();

        public void InteractWithInventory()
        {
            inventory.Interact();
            Console.Write("Press 1 to use consumable: ");
            if(int.TryParse(Console.ReadLine(), out int result) && result == 1)
            {
                Health = inventory.Heal(Health);
            }
        }

        public override int GetStrength() => strength * inventory.GetDamageModifier();

        public override int GetDefense() => defense + inventory.GetAllAdditionalDefense();


        public bool DoesPlayerBlock() => new Random().Next(1, 101) <= inventory.GetBlockChance();
    }
    
}
