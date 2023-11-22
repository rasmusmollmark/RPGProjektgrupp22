using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class HealingPotion : Consumable
    {
        int hpHealed;
        string type;
        public HealingPotion(int hpHealed, string type)
        {
            this.hpHealed = hpHealed;
            this.type = type + " healing potion";
        }
        public string ConsumableToString() => type + " heals "+hpHealed+" hp";
        
    }
}
