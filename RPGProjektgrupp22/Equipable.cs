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
        public Equipable(int sellValue, string type)
        {
            this.sellValue = sellValue;
            this.type = type;
        }

        public abstract string EquipableToString();
        
    }
}
