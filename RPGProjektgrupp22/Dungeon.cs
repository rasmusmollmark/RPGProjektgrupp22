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
        private string dungeonName;
        private static Random generator = new Random();
        public Dungeon()
        {
            dungeonName = dungeonNameList[generator.Next(1, dungeonNameList.Count())];
        }   
    }
}
