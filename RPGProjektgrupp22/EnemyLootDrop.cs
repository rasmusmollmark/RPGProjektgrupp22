using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class EnemyLootDrop : Loot
    {
        private int gold;
        private Equipable equipable;
        public int Gold => gold;

        public Equipable Item => equipable;

        public EnemyLootDrop(int goldDroppedFromEnemy)
        {
            gold = goldDroppedFromEnemy;
            equipable = RandomizeEquippable.GetRandom();
        }

    }
}
