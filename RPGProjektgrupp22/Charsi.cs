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
        private string name = "Charsi";
        private List<string> Lore = new List<string>();
        private VendorInventory inventory;
        private string[] differentTypesOfGreetings = new string[]{"Farewell.",
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
        public string Name => name;

        public VendorInventory Inventory => inventory;

        public Charsi()
        {
            GenerateInventory();
            AddLore();
        }

        

        public void AddLore()
        {
            string welcome = "Hi there. I'm  Charsi, the blacksmith here in camp. It's good to see some strong adventurers around here.\n" +
                "Many of our Sisters fought bravely against Diablo when he first attacked the town of  Tristram. \n" +
                "They came back to us true veterans, bearing some really powerful items. Seems like their victory was short-lived, though...\n" +
                "Most of them are now corrupted by  Andariel.";
            string gossip = "Akara, our priestess and seer, is most upset by the corruption of our Sisters. I fear that she blames herself.";
            Lore.Add(welcome);
            Lore.Add(gossip);
        }


        public void GenerateInventory()
        {
            inventory = new VendorInventory();
        }

        public void TellGossip()
        {
            for(int i = 0; i < Lore[1].Length; i++)
            {
                Console.Write(Lore[1][i]);
                Thread.Sleep(10);
                if (Console.KeyAvailable)
                {
                    return;
                }
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public void GreetPlayer()
        {
            Console.WriteLine(differentTypesOfGreetings[new Random().Next(1, differentTypesOfGreetings.Length)]);
        }
            

        public void OptionForPlayerMeeting()
        {
            Console.WriteLine("1. Sell items\n" +
            "2. Buy items\n" +
            "3. Hear stories\n" +
            "4. Back to town");
        }

        public void SellItems(Player player)
        {
            Console.WriteLine("WARNING\nSold items cannot be bought back!");
            Thread.Sleep(1000);
            List<Equipable> sellList = player.GetSellList();
            while (true && sellList.Count > 0)
            {
                player.PrintSellInventory(sellList);
                Console.WriteLine("Please input the number of the item you would like to sell: (0 to exit vendor)");
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= sellList.Count)
                {
                    player.Gold += sellList[input - 1].SellValue;
                    player.RemoveItemFromInventory(sellList[input - 1]);
                    sellList.Remove(sellList[input - 1]);
                    Console.WriteLine("Item sold successfully! " +
                        "\nBalance: " + player.Gold);
                }
                else if (input == 0)
                {
                    return;
                }
            }
        }

        public void BuyItems(Player player)
        {
            while (true)
            {
                
                Console.WriteLine(inventory.InventoryToString());
                Console.WriteLine(player.Gold + " gold\nPlease input the number of the item you would like to buy: (press 0 to exit vendor)");
                if (int.TryParse(Console.ReadLine(), out int input) && input > 0 && input <= inventory.equipables.Count)
                {
                    Equipable equipable = inventory.equipables[input - 1];
                    if (PlayerHasEnoughGold(player, equipable))
                    {
                        player.RecieveBoughtEquippable(equipable);
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

        private bool PlayerHasEnoughGold(Player player, Equipable equipable) => player.Gold >= equipable.Price;

        private void RemoveItemFromInventory(Equipable equipable) => inventory.equipables.Remove(equipable);
    

    public void TellWelcome()
        {
            for (int i = 0; i < Lore[0].Length; i++)
            {
                Console.Write(Lore[0][i]);
                Thread.Sleep(10);
                if (Console.KeyAvailable)
                {
                    return;
                }
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public string InventoryToString() => inventory.InventoryToString();
            
    }
}
