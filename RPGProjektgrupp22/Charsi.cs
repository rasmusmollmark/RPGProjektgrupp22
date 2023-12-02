using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Charsi : Vendor
    {
        public Charsi()
        {
            name = "Charsi";
            GenerateInventory();
            AddLore();
        }

        public override void AddLore()
        {
            string welcome = "Hi there. I'm  Charsi, the blacksmith here in camp. It's good to see some strong adventurers around here.\n" +
                "Many of our Sisters fought bravely against Diablo when he first attacked the town of  Tristram. \n" +
                "They came back to us true veterans, bearing some really powerful items. Seems like their victory was short-lived, though...\n" +
                "Most of them are now corrupted by  Andariel.";
            string gossip = "Akara, our priestess and seer, is most upset by the corruption of our Sisters. I fear that she blames herself.";
            lore.Add(welcome);
            lore.Add(gossip);
            differentTypesOfGreetings = new string[] {"Farewell.",
"Goodbye.",
"Good day.",
"Good evening.",
"Good morning.",
"Good to see you.",
"Greetings.",
"Hello.",
"I need your help.",
"Oh, hi there. It's good to see you again. Hey, nice armor!",
"What can I do for you?",
"What'cha need?"};
        }


        public override void GenerateInventory()
        {
            inventory = new VendorInventory();
        }
        public override void BuyItems(Player player)
        {
            while (true)
            {

                Console.WriteLine(inventory.InventoryToString());
                Console.WriteLine(player.Gold + " gold\nPlease input the number of the item you would like to buy: (press 0 to exit vendor)");
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= inventory.equipables.Count)
                {
                    Equipable equipable = inventory.equipables[input - 1];
                    if (PlayerHasEnoughGold(player, equipable.Price))
                    {
                        player.ReceiveBoughtEquippable(equipable);
                        player.Gold -= equipable.Price;
                        RemoveItemFromInventory(equipable);
                        Console.WriteLine("Item purchased successfully!\nItem bought: " + equipable.EquipableToString() + "\nCurrent balance: " + player.Gold);

                    }
                    else
                    {
                        Console.WriteLine("Not enough gold!");
                    }
                }
                else if (input == 0)
                {
                    return;
                }
            }
        }

        private void RemoveItemFromInventory(Equipable equipable) => inventory.equipables.Remove(equipable);

    }
}
