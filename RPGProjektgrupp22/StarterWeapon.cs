using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class StarterWeapon : Weapon
    {
        public StarterWeapon(int damageModifier, string type) : base(damageModifier, 1, type) 
        {
            
        }
    }
}
