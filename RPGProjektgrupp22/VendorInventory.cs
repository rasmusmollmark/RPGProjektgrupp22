using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class VendorInventory
    {
        List<Consumable> consumables = new List<Consumable>();
        List<Equipable> equipables = new List<Equipable>();
        
        public VendorInventory(int amountOfHealingPotions)
        {
            for (int i = 0; i < amountOfHealingPotions; i++)
            {
                switch(new Random().Next(1, 3)) 
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

        }

        public string InventoryToString()
        {
            string result = "";
            for(int i  = 0; i < consumables.Count; i++)
            {
                result += consumables[i].ConsumableToString() + "\n";
            }
            return result;
        }

    }
}
