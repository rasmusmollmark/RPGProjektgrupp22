using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Story
    {
        Player player;
        public Story() 
        {

            player = new Player(getPlayerName());
            printStartOfGame();

        }

        private string getPlayerName()
        {
            Console.Write("Skriv in din spelares namn: ");
            return Console.ReadLine();
        }

        private void printCurrentLocation(string location)
        {

        }

        private void printStartOfGame()
        {
            Console.WriteLine("This is an rpg based game where you will face different challanges by exploring a collection of dungeons.\n" +
                "You will choose one of the provided dungeons and explore it. If you survive you will have the opportunity to go back to town.\n" +
                "In town you will be able to sell your loot and buy equipment and or consumables such as health potions.\n" +
                "\nPress any key when ready: ");
            Console.ReadKey();Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
               
        }
    }
}
