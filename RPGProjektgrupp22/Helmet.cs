using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Helmet : Equipable
    {
        private int defense;
        public Helmet(int defense, string type) : base(defense/4, type)
        {
            this.defense = defense;
        }

        public override string EquipableToString() => type + " Defense: " + defense;

        public int Defense
        {
            get => defense;
        }
    }
}
