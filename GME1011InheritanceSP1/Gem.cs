using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011InheritanceSP1
{
    internal class Gem : Loot
    {

            private int _magic;

            public Gem() : base(1, 1, "shiny stone")
            {
                _magic = 1;
            }

            public Gem(int value, int rarity, string description, int magic) : base(value, rarity, description)
            {
            _magic = magic;
            }

            public int GetMagic() { return _magic; }

            public void CastSpell()
            {
            Console.WriteLine("You've been gemmed!!!");
            }

            public override string ToString()
            {
                return "Gem[" + base.ToString() + ", magic: " + _magic + "]";
            }

        }
}
