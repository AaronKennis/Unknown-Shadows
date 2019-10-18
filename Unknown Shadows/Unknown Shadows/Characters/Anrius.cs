using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unknown_Shadows.Characters
{
    class Anrius : Hero
    {
        public Anrius()
          : base(
                "Anrius",
                new Interfaces.Bite(5),
                new Interfaces.Shapeshifter(),
                new Interfaces.Elf(),
                new Interfaces.Male()

                )
        { }
         
    }
}
