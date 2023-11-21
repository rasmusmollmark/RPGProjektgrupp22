using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public abstract class Shield : Equipable
    {
        protected int defense;
        protected int blockChance;
        public Shield(int defense, int blockChance, int sellValue) : base(sellValue)
        {
            this.defense = defense;
            this.blockChance = blockChance;
        }
    }
}
