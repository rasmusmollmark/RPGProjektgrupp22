using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    internal class NotEquipped : Equipable
    {
        public NotEquipped() : base(0, "Unequipped")
        {
            
        }

        public override string EquipableToString() => "";
    }
}
