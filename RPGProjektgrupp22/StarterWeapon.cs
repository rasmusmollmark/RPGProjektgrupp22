using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class StarterWeapon : Weapon
    {
        public StarterWeapon(int minDamage, int maxDamage) : base(minDamage, maxDamage, 1) 
        {
            
        }
    }
}
