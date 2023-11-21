using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Inventory
    {
        public Equipable chestArmor;
        public Equipable weapon;
        public Equipable helmet;
        public Equipable shield;
        public Equipable boots;
        public Equipable gloves;
        public Equipable amulet;
        public Equipable ring1;
        public Equipable ring2;
        public Inventory() 
        {
            weapon = new StarterSword();
            shield = new StarterShield();
        }
    }
}
