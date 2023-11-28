using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Inventory
    {
        private List<Equipable> EquipableList = new List<Equipable>();
        private List<Consumable> consumablesList = new List<Consumable>();
        public bool hasChestArmor = false;
        public bool hasWeapon = false;
        public bool hasHelmet = false;
        public bool hasShield = false;
        public bool hasBoots = false;
        public bool HasGloves = false;
        public bool hasAmulet = false;
        public bool hasRing1 = false;
        public bool hasRing2 = false;
        public Inventory() 
        {
            EquipableList.Add(new StarterSword());
            EquipableList.Add(new StarterShield());
            hasShield = true;
            hasWeapon = true;
            for(int i = 0; i < 4; i++)
            {
                consumablesList.Add(new MinorHealingPotion());
            }
        }


        public void AddItemToInventory(Equipable item) => EquipableList.Add(item);

        public string InventoryToString()
        {
            string result = "";
            result += "Equipment: \n";
            foreach(Equipable item in EquipableList)
            {
               result += item.EquipableToString()+ "Equipped: "+ item.isEquipped() +"\n";
            }
            result += "\nConsumables: \n";
            foreach(Consumable consumable in consumablesList)
            {
                result += consumable.ConsumableToString() + "\n";
            }
            return result;
        }
    }
}
