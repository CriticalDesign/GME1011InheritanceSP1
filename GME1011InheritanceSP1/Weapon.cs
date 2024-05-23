using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GME1011InheritanceSP1
{
    //Inheritance - one class inherits (or receives) elements from another
    //Parent/super/base class - the class that has the elements to be received
    //Child/sub class - the clas that recieves elements from the parent class

    //internal class subClass : superClass (childClass : parentClass)

    internal class Weapon : Loot
    {

        //1. ALL super/parent class attributes are inherited

        //2. A child/sub class MAY (not required) define their own
        //attributes.
        private int _damage;
        private int _durability;

        public Weapon() : base(10, 1, "plain stick") {
            _damage = 3;
            _durability = 5;
        }

        public Weapon(int value, int rarity, string description, int damage, int durability) : base(value, rarity, description)
        {
            if (damage < 0 || damage > 20)
                damage = 3;

            if (durability < 0 || durability > 10)
                durability = 5;

            _damage = damage;
            _durability = durability;
        }

        //3. ALL methods/behaviours in parent/super class are 
        //inherited by the child/sub class

        //4. A child/sub class MAY write their own methods behaviours
        public int GetDamage() {  return _damage; }
        public int GetDurability() { return _durability;  }

        public int Attack()
        {
            Random rng = new Random();
            return rng.Next(1, _damage);
        }

        //5. A child/sub class MAY override any super/parent class methods
        public override void Enchant()
        {
            base.Enchant();

            _damage *= 3;
            _durability *= 2;
            _value *= 2;

        }
    }
}
