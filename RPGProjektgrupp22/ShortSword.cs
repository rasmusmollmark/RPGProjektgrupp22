using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class ShortSword : Weapon
    {
        public ShortSword() : base(new Random().Next(1, 4) + 1, new Random().Next(1, 6) + 10, "Short Sword")
        { }
    }
}
