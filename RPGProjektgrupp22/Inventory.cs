using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

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

        public int Heal(int playerHealth)
        {
            int heal = 0;
            for(int i = 0; i < consumablesList.Count; i++)
            {
                Console.WriteLine(i+1+". " + consumablesList[i].ConsumableToString());
            }
            while(true)
            {
                Console.Write("\nCurrent helth: "+ playerHealth + "\nPlease input the number of the item you would like to consume (anything else for no): ");
                if (int.TryParse(Console.ReadLine(), out int inputForConsumable) && inputForConsumable > 0 && inputForConsumable <= consumablesList.Count)
                {
                    heal += Consume(inputForConsumable - 1);
                    Console.WriteLine("Potion consumed successfully!\n");
                }
                else
                {
                    break;
                }
            }
            return playerHealth += heal;
            
        }

        private int Consume(int index) => (consumablesList[index] as HealingPotion).HPHealed;

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

        public int GetDamageModifier()
        {
            if (firstHand != null)
            {
                return (firstHand as Weapon).DamageModifier;
            }
            return 0;
        }

        public int GetBlockChance()
        {
            if (secondHand != null)
            {
                return (secondHand as Shield).BlockChance;
            }
            return 0;
        }

        internal int GetAllAdditionalDefense() 
        {
            int result = 0;
            if(chestArmor != null)
            {
                result += (chestArmor as ChestArmor).Defense;
            }
            if(helm != null)
            {
                result += (helm as Helmet).Defense;
            }
            if(secondHand != null)
            {
                result += (secondHand as Shield).Defense;
            }
            return result;
        } 
        
    }
}
