using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class ChestLoot : Loot
    {
        private int gold;
        public ChestLoot()
        {
            gold = new Random().Next(10, 30);
        }

        public int Gold => gold;

        public Equipable Item => null;


    }
}
