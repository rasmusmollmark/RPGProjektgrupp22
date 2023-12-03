using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Helmet : Equipable
    {
        public int Defense { get; private set; }
        public Helmet(int defense, string type) : base(defense / 3, type)
        {
            Defense = defense;
        }

        public override string EquipableToString() => type + " Defense: " + Defense;

    }
}
