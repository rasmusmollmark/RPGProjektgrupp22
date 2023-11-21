using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    internal class Dungeon
    {
        private List<string> dungeonNameList = new List<string>() { "Ice Dungeon", "Fire Dungeon", "Noob Dungeon", "Water dungeon"};
        
        
        public Dungeon(int i)
        {
            Console.WriteLine("A dungeon named" + dungeonNameList[i] + " has been created");
        }   
    }
}
