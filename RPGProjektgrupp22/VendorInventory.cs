using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class VendorInventory
    {
        public List<Consumable> consumables = new List<Consumable>();
        public List<Equipable> equipables = new List<Equipable>();
        
        public VendorInventory(int amountOfHealingPotions)
        {
            createAkaraInventory(amountOfHealingPotions);
        }
        private void createAkaraInventory(int amountOfHealingPotions)
        {
            for (int i = 0; i < amountOfHealingPotions; i++)
            {
                switch (new Random().Next(1, 3))
                {
                    case 1:
                        consumables.Add(new MinorHealingPotion());
                        break;
                    case 2:
                        consumables.Add(new MajorHealingPotion());
                        break;
                }
            }
        
        }

        public VendorInventory() 
        {
            createCharsiInventory();
        }

        private void createCharsiInventory()
        {
            for(int i = 0; i < 4; i++)
            {
                equipables.Add(RandomizeEquippable.GetRandom());
            }
        }

        public string InventoryToString()
        {
            string result = "\n\n\nAvailable items:\n";
            for(int i  = 0; i < consumables.Count; i++)
            {
                result += i + 1 + ". "+ consumables[i].ConsumableToString() + "\n";
            }
            for (int i = 0; i < equipables.Count; i++)
            {
                result += i + 1 + ". " + equipables[i].EquipableToString() +" Price: "+ equipables[i].Price + "\n";
            }
            return result;
        }

    }
}
