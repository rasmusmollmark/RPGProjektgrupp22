using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public abstract class Weapon : Equipable
    {
        protected int minDamage;
        protected int maxDamage;
        public Weapon(int minDamage, int maxDamage, int sellValue) : base(sellValue)
        {
           this.minDamage = minDamage;
           this.maxDamage = maxDamage;
        }

    }
}
