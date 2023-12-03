using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    // 1: Här används konceptet abstrakt klass
    // 2: Det används genom att skapa denna superklass 
    public abstract class Equipable
    {
        private int sellValue;
        public int SellValue { 
            get => sellValue; 
            private set { 
                if (value < 1) 
                { 
                    sellValue = 1; 
                } 
                else 
                { 
                    sellValue = value; 
                } 
            } 
        }
        // 1: Här används åtkomstmodifieraren protected
        // 2: Konceptet används genom att låta subtyper av klassen använda variabeln
        // 3: För att återanvända kod, alla klasser behöver den, spara på rader
        protected string type {  get; set; }
        public bool IsEquipped { get; private set; } = false;
        
        public Equipable(int sellValue, string type)
        {
            SellValue = sellValue;
            this.type = type;
        }

        public abstract string EquipableToString();
        
        // 1: Här används Computed properties
        // 2: Det används genom att ta värdet av sellValue och multiplicera det med 3
        // 3: Det används för att slippa ha två olika variabler, en för sälj och en för köp.
        public int Price => SellValue * 3;

        public void Equip()
        {
            IsEquipped = true;
        }
        public void UnEquip()
        {
            IsEquipped = false;
        }
    }
}
