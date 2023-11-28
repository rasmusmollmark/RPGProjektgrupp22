using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class LeatherCap : Helmet
    {
        public LeatherCap() : base(new Random().Next(1, 7), "Leather Cap")
        {
        }
    }
}
