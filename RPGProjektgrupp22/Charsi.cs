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
        }

        public void GreetPlayer()
        {
            Console.WriteLine(differentTypesOfGreetings[new Random().Next(1, differentTypesOfGreetings.Length)]);
        }
            

        public void OptionForPlayerMeeting()
        {
            Console.WriteLine("1. Sell items\n" +
            "2. Buy items\n" +
            "3. Hear stories");
        }

        public void SellItems(Player player)
        {
            throw new NotImplementedException();
        }

        public void BuyItems(Player player)
        {
            throw new NotImplementedException();
        }

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
        }

        
    }
}
