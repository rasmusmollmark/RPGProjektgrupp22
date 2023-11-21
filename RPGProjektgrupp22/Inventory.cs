using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Inventory
    {
        Equipable chestArmor;
        Equipable weapon;
        Equipable helmet;
        Equipable shield;
        Equipable boots;
        Equipable gloves;
        Equipable amulet;
        Equipable ring1;
        Equipable ring2;
        public Inventory() 
        {
            weapon = new StarterSword();
            shield = new StarterShield();
        }
    }
}
