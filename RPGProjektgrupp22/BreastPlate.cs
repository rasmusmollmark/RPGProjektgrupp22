using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class BreastPlate : ChestArmor
    {
        public BreastPlate() : base("Breast Plate", new Random().Next(4, 12))
        {

        }
    }
}
