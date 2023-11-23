using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace RPGProjektgrupp22
{
    public class Story
    {
        Player player;
        List<Dungeon> dungeons = new List<Dungeon>();
        public Story() 
        {
            for (int i = 0; i < 4; i++)
            {
                dungeons.Add(new Dungeon(i));
            }
            player = new Player(getPlayerName());
            printStartOfGame();
            beginStory();

        }

        private void beginStory()
        {
            ClearWindow();
            Console.WriteLine(player.PrintInventory());

            if (PlayerWantsToVisitTown())
            {
                GoToTown();
            }
            else
            {
                int dungeonChoice;

                do
                {
                    dungeonChoice = GetPlayerDungeonChoice();
                    bool goBackToTown = dungeons[dungeonChoice].Explore(player);

                    if (goBackToTown)
                    {
                        GoToTown();
                        return; 
                    }

                } while (true);
            }

        }

        private int GetUserInput()
        {
            if (int.TryParse(Console.ReadLine(), out int input))
            {
                return input;
            }
            else
            {
                return -1;
            }
        }

        private void GoToTown()
        {
            ClearWindow();
            Console.WriteLine("You're now in town.\n" +
                "1. See inventory\n" +
                "2. Go to vendors\n" +
                "3. Explore dungeons");
            int input = GetUserInput();
            while (input < 1 || input > 3)
            {
                Console.WriteLine("Invalid inputer. Enter a number between 1 and 3");
                input = GetUserInput();
            }
            switch (input)
            {
                case 1:
                    Console.WriteLine(player.PrintInventory());
                    break;
                case 2:
                    Console.WriteLine("Gping to vendors");
                    break;
                case 3:
                    beginStory();
                    break;
            }
        }

        private void ClearWindow()
        {
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
        }

        private bool PlayerWantsToVisitTown()
        {
            while (true)
            {
                Console.WriteLine("Do you want to visit town?\n" +
                    "1: Yes\n" +
                    "2. No, I want to explore");
                int input = GetUserInput();
                if (input < 3 && input > 0)
                {
                    switch (input)
                    {
                        case 1:
                            return true;
                        case 2:
                            return false;
                    }
                }
                Console.WriteLine("Wrong input!");
            }
        }

        private int GetPlayerDungeonChoice()
        {
            while (true)
            {
                Console.Write("Pick the dungeon you wish to explore (1-4): ");
                int input = GetUserInput();
                if (input > 0 && input < 5)
                {
                    return input-1;
                }
                Console.WriteLine("\nWrong input!");
            }

            Console.WriteLine("Pick the dungeon you wish to explore (1-4): ");
            int chosenDungeon;

            do
            {
                // Get the player's choice
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out chosenDungeon))
                {
                    // Check if the chosen number is within the valid range
                    if (chosenDungeon >= 1 && chosenDungeon <= 4)
                    {
                        // The input is valid, break out of the loop
                        break;
                    }
                }

                // If the input is invalid, ask the player to enter a valid number
                Console.WriteLine("Invalid input. Please enter a number between 1 and 4.");
            } while (true);

            // The player has chosen a valid dungeon, proceed with that dungeon
            ExploreDungeon(chosenDungeon - 1);
        }
        private void ExploreDungeon(int dungeonIndex)
        {
            Dungeon selectedDungeon = dungeons[dungeonIndex];

            // Display the name of the selected dungeon
            Console.WriteLine($"You have chosen to explore " + selectedDungeon.GetDungeonName());
            selectedDungeon.Explore(player);
            

        }

        private string getPlayerName()
        {
            Console.Write("Please enter your characters name: ");
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
            Console.ReadKey();
               
        }
    }
}
