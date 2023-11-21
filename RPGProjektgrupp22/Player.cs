using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Player
    {
        int hp = 10;
        private Inventory inventory;
        public Player()
        {
            inventory = new Inventory();
        }
    }
}
