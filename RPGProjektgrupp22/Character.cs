using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public interface Character
    {
        int health{ get; set; }
        string name { get; set; }
        int damage {  get; set; }
        bool isDead {  get; set; }

        public void takeDamage(int damage);

    }
}
