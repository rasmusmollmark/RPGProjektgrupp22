using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGProjektgrupp22
{
    public abstract class Character
    {
        protected int health;
        protected string name;
        protected int damage;
        protected bool isDead = false;
        public Character(string name, int health, int damage)
        {
            this.name = name;
            this.health = health;
            this.damage = damage;
        }

        public bool IsDead => isDead;

        public string GetName() => name;

        public void TakeDamage(int damage)
        {
            health -= damage;
            if (health < 0)
            {
                isDead = true;
            }
        }

        public void AttackCharacter(Character character)
        {
            character.TakeDamage(damage);
        }

    }
}
