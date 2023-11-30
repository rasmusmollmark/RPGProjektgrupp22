using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public abstract class Equipable
    {
        protected int sellValue;
        protected string type;
        protected int buyValue;
        private bool equipped = false;
        public Equipable(int sellValue, string type)
        {
            this.sellValue = sellValue;
            this.type = type;
            buyValue = 3 * sellValue;
        }

        public abstract string EquipableToString();

        public bool isEquipped() => equipped;

        public void Equip()
        {
            equipped = true;
        }
        public void UnEquip()
        {
            equipped = false;
        }
    }
}
