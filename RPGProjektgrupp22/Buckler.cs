using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Buckler : Shield
    {
        public Buckler() : base(new Random().Next(1, 8) + 10, new Random().Next(10, 25) + 10, "Buckler")
        {
        }
    }
}
