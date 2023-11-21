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
            Console.WriteLine("Välkommen till vårt spel!\nSpelaren kommer under spelets gång få olika alternativ att välja mellan.\n" +
                "Exempel: \n" +
                "1. Gå in i grottan\n" +
                "2. Fortsätt längs stigen\n" +
                "3. Gå tillbaks till lägret\n" +
                "Valet bestämmer hur spelet fortsätter.");
            string result = "Du befinner dig i lägret Kurast. Utanför lägrets murar befinner sig onda väsen som vill döda dig.\n\n" +
                "I lägret finns det olika personer du kan prata med";
            for(int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i]);
                Thread.Sleep(60);
            }
        }
    }
}
