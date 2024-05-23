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
    internal class Food : Loot
    {
        //1. ALL super/parent class attributes are inherited

        //2. A child/sub class MAY (not required) define their own
        //attributes.
        private int _healingPower;
        private int _freshness;

        public Food() : base(1, 1, "yummy apple")
        {
            _healingPower = 5;
            _freshness = 3;
        }

        public Food(int value, int rarity, string description, int healing, int freshness) : base(value, rarity, description)
        {
            if (healing < 0 || healing > 10)
                healing = 5;

            if (freshness < 0 || freshness > 10)
                freshness = 3;

            _healingPower = healing;
            _freshness = freshness;
        }

        //3. ALL methods/behaviours in parent/super class are 
        //inherited by the child/sub class

        //4. A child/sub class MAY write their own methods behaviours
        public int GetHealing() { return _healingPower; }
        public int GetFreshness() { return _freshness; }


        public int Eat()
        {
            return _healingPower;
        }

        //5. A child/sub class MAY override any super/parent class methods
        public override void Enchant()
        {
            base.Enchant();

            _healingPower *= 3;
            _freshness = 100;
        }
    }
}
