using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Characters.Interfaces
{
    interface IAttackBehavior
    {
        int Damage { get; }
        void Attack(Characters.Character attacker, Characters.Character target);
    }
}
