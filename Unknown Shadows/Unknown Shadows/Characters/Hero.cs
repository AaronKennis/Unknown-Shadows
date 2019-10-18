using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Characters
{
   class Hero : Character
    {
        Interfaces.IAttackBehavior attackBehavior;

        private string name;
        public string Name { get => name; }

        public int Age { get; set; } = 12;
        Interfaces.Classes Class;
        Interfaces.IRace race;
        Interfaces.IGender gender;


        public int Life { get; set; } = 200;


        public Hero(string name, Interfaces.IAttackBehavior attackBehavior, Interfaces.Classes Class, Interfaces.IRace race, Interfaces.IGender gender)
        {
            this.attackBehavior = attackBehavior;
            this.name = name;
            this.Class = Class;
            this.race = race;
            this.gender = gender;
        }
    }
}
