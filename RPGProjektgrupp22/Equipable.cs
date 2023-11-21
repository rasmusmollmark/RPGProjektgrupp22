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
        public Equipable(int sellValue)
        {
            this.sellValue = sellValue;
        }
    }
}
