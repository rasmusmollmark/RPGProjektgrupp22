using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public interface IVendor
    {
        protected VendorInventory Inventory { get; }
        protected List<string> Lore {get;}
        protected string[] DifferentTypesOfGreetings { get; }

        public void AddLore();

        public void GenerateInventory();

        // 1: Här används Default Interface Methods
        // 2: Det görs genom att alla klasser som implementerar gränssnittet har tillgång till dessa metoder
        // 3: Det görs för att återanvända kod, slippa ha samma kod flera gånger
        public void TellGossip()
        {
            for (int i = 0; i < Lore[1].Length; i++)
            {
                Console.Write(Lore[1][i]);
                Thread.Sleep(10);
                if (Console.KeyAvailable)
                {
                    break;
                }
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public void TellWelcome()
        {
            for (int i = 0; i < Lore[0].Length; i++)
            {
                Console.Write(Lore[0][i]);
                Thread.Sleep(10);
                if (Console.KeyAvailable)
                {
                    break;
                }
            }
            Console.ReadKey();
            Console.WriteLine();
        }

        public void GreetPlayer() => Console.WriteLine(DifferentTypesOfGreetings[new Random().Next(1, DifferentTypesOfGreetings.Length)]);

        public void OptionForPlayerMeeting() => Console.WriteLine("1. Sell items\n" +
            "2. Buy items\n" +
            "3. Hear stories\n" +
            "4. Back to town");

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

        public bool PlayerHasEnoughGold(Player player, int price) => player.Gold >= price;

        public void BuyItems(Player player);
    }
}
