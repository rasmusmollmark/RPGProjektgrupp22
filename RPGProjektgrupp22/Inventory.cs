using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Inventory
    {
        private List<Equipable> inventoryList = new List<Equipable>();
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
            inventoryList.Add(new StarterSword());
            inventoryList.Add(new StarterShield());
            hasShield = true;
            hasWeapon = true;
        }


        public string InventoryToString()
        {
            string result = "";
            foreach(Equipable item in inventoryList)
            {
               result += item.EquipableToString()+"\n";
            }
            return result;
        }
    }
}
