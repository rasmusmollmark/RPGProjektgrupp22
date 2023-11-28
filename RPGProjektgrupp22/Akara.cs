using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Akara : Vendor
    {
        private string name = "Akara";
        private List<string> Lore = new List<string>();
        private VendorInventory inventory;
        private string[] differentTypesOfGreetings = new string[] {"Good day.",
"Good evening.",
"Good morning.",
"Greetings.",
"Hello.",
"The Order welcomes you.",
"Welcome back, my friend. We are still clearing the monastery, but you're welcome to stay here as long as you need.",
"Yes?"};
        public string Name => name;

        public VendorInventory Inventory => inventory;

        

        public Akara() 
        {
            GenerateInventory();
            AddLore();
        }

        
            

        public string InventoryToString() => inventory.InventoryToString();

        public void TellGossip()
        {
            for(int i = 0; i < Lore[1].Length; i++)
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

        public void AddLore()
        {
            string welcome = "I am  Akara, High Priestess of the Sisterhood of the Sightless Eye.\n" +
                "I welcome you, traveler, to our camp, but I'm afraid I can offer you but poor shelter within these rickety walls." +
                "\nYou see, our ancient Sisterhood has  Fallen under a strange curse. The mighty Citadel from which we have \n" +
                "guarded the gates to the East for generations, has been corrupted by the evil Demoness, Andariel.\n" +
                "I still can't believe it... but she turned many of our sister Rogues against us and drove us from our ancestral home.\n" +
                "Now the last defenders of the Sisterhood are either dead or scattered throughout the wilderness." +
                "\nI implore you, stranger. Please help us. Find a way to lift this terrible curse and \n" +
                "we will pledge our loyalty to you for all time.";
            Lore.Add(welcome);

            string gossipAboutCharsi = " Charsi is young and innocent. However, I believe her Barbarian blood thrills to the \n" +
                "prospect of adventure and danger. She takes great Pride in her work and finds comfort in the fact that her \n" +
                "weapons and armor are helping to end this evil Plague.";
            Lore.Add(gossipAboutCharsi);
           
            
        }

        public void GenerateInventory()
        {
            inventory = new VendorInventory(new Random().Next(4, 7));
        }

        public void OptionForPlayerMeeting()
        {
            Console.WriteLine("1. Sell items\n" +
            "2. Buy items\n" +
            "3. Hear stories\n" +
            "4. Back to town");

        }

        public void GreetPlayer()
        {
            Console.WriteLine(differentTypesOfGreetings[new Random().Next(1, differentTypesOfGreetings.Length)]);
        }

        public void SellItems(Player player)
        {
            throw new NotImplementedException();
        }

        public void BuyItems(Player player)
        {
        }
    }
}
