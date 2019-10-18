using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Characters.Interfaces
{
    class Bite : IAttackBehavior
    {
        private int damage = 0;
        public int Damage => damage;

        public Bite(int damage)
        {
            this.damage = damage;
        }
        public void Attack(Character attacker, Character target)
        {
            Console.WriteLine();
        }
    }
}
