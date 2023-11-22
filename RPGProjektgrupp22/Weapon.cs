using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Weapon : Equipable
    {
        protected int damageModifier;
        
        public Weapon(int damageModifier, int sellValue, string type) : base(sellValue, type)
        {
           this.damageModifier = damageModifier;
        }

        public override string EquipableToString() => type + " Damage: " + damageModifier;
        
    }
}
