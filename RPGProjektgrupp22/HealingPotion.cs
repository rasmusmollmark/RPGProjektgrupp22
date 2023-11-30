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
        int price;
        public HealingPotion(int hpHealed, string type, int price)
        {
            this.hpHealed = hpHealed;
            this.type = type + " healing potion";
            this.price = price;
        }
        public string ConsumableToString() => type + " heals "+hpHealed+" hp. Price: " + price;

        public int HPHealed => hpHealed;
        
    }
}
