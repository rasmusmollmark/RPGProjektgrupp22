using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class HealingPotion : IConsumable
    {
        public int HpHealed { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        
        public HealingPotion(int hpHealed, string type, int price)
        {
            HpHealed = hpHealed;
            Type = type + " healing potion";
            Price = price;
        }
        public string ConsumableToString() => Type + " heals " + HpHealed + " hp. Price: " + Price;
    }
}
