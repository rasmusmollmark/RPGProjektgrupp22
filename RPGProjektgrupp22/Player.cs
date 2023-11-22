using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public class Player
    {
        private int health = 20;
        private int baseDamage = 1;
        private string name;
        private int levelsCompleted = 0;

        private Inventory inventory;
        public Player(string name)
        {
            this.name = name;
            inventory = new Inventory();
        }

        public void LevelCompleted()
        {
            levelsCompleted++;
            baseDamage++;
            health += 2;
        }
        public int GetLevelsCompleted() { return levelsCompleted; }
        public string GetName() { return name; }
        public void ResetLevelsCompleted() { levelsCompleted = 0; }
    }
}
