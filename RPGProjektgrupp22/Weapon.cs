using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public abstract class Weapon : Equipable
    {
        protected int damageModifier;
        public Weapon(int damageModifier, int sellValue) : base(sellValue)
        {
           this.damageModifier = damageModifier;
        }

    }
}
