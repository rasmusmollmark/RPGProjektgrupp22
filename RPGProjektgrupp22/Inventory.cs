using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Inventory
    {
        private List<Equipable> itemsInventoryList = new List<Equipable>();
        private List<Consumable> consumablesList = new List<Consumable>();
        
        private Equipable firstHand;
        private Equipable secondHand;
        private Equipable helm;
        private Equipable chestArmor;


        public Inventory() 
        {
            EquipStarterItems();
            for(int i = 0; i < 4; i++)
            {
                consumablesList.Add(new MinorHealingPotion());
            }
        }

        private void EquipStarterItems()
        {
            firstHand = new StarterSword();
            secondHand = new StarterShield();
            firstHand.Equip();
            secondHand.Equip();
        }

        public void AddItemToInventory(Equipable item) => itemsInventoryList.Add(item);

        public string InventoryToString()
        {
            string result = "";
            result += "Equipped: \n" + EquippedItemsToString();
            result += "Items in inventory: \n";
            foreach(Equipable item in itemsInventoryList)
            {
               result += item.EquipableToString() + "\n";
            }
            result += "\nConsumables: \n";
            foreach(Consumable consumable in consumablesList)
            {
                result += consumable.ConsumableToString() + "\n";
            }
            return result;
        }

        private string EquippedItemsToString()
        {
            string result = "";
            if(firstHand != null)
            {
                result += firstHand.EquipableToString() + "\n";
            }
            if(secondHand != null)
            {
                result += secondHand.EquipableToString() + "\n";
            }
            if (helm != null)
            {
                result += helm.EquipableToString() + "\n";
            }
            if (chestArmor != null)
            {
                result += chestArmor.EquipableToString() + "\n";
            }
            return result;
        }

        public void Interact()
        {
            if(itemsInventoryList.Count > 0)
            {
                Console.WriteLine("Would you like to equip non-equipped items? (1 for yes, anything else for no)");
                if(int.TryParse(Console.ReadLine(), out int input) && input == 1)
                {
                    for(int i = 0; i < itemsInventoryList.Count; i++)
                    {
                        Console.WriteLine(i + 1 +". "+ itemsInventoryList[i].EquipableToString());
                    }
                    Console.Write("Please input the number of the item you would like to equip (anything else for no): ");
                    if(int.TryParse(Console.ReadLine(), out int inputForItem) && inputForItem > 0 && inputForItem <= itemsInventoryList.Count)
                    {
                        Equip(inputForItem - 1);
                        Console.WriteLine("Item swapped successfully!");
                    }
                }
            }
        }

        private void Equip(int index)
        {
            switch (itemsInventoryList[index])
            {
                case Weapon sword:
                    Equip(index, firstHand, sword);
                    firstHand = sword;
                    firstHand.Equip();
                    break;
                case Shield shield:
                    Equip(index, secondHand, shield);
                    secondHand = shield;
                    secondHand.Equip();
                    break;
                case Helmet helmet:
                    Equip(index, helm, helmet);
                    helm = helmet;
                    helm.Equip();
                    break;
                case ChestArmor armor:
                    Equip(index, chestArmor, armor);
                    chestArmor = armor;
                    chestArmor.Equip();
                    break;

            }
        }
        private void Equip(int index, Equipable equipped, Equipable toBeEquipped)
        {
            if(equipped != null)
            {
                itemsInventoryList[index] = equipped;
                equipped.UnEquip();
            }
            else
            {
                itemsInventoryList.Remove(toBeEquipped);
            }
        }
    }
}
