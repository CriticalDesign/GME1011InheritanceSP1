namespace GME1011InheritanceSP1
{
    internal class Loot
    {
        //attributes
        protected int _value;
        private int _rarity;
        private string _description;
        private bool _isEnchanted;

        //no argument constructor
        public Loot()
        {
            _description = "coin";   //description = "plain thin brittle stick";
            _rarity = 0;             //rarity = 1;
            _value = 1;              //value = 0;
            _isEnchanted = false;
        }

        public Loot(int value, int rarity, string description)
        {
            if (value < 0)
                value = 0;

            if (rarity < 0)
                rarity = 0;

            if (description == "" || description == null)
                description = "loot of unknown origin";


            _value = value;
            _rarity = rarity;
            _description = description;      
            _isEnchanted = false;
        }

        public string DescribeLoot() { return _description; }      
        public int GetValue() { return _value; }

        public string HowRare()
        {
            if (_rarity == 0)
                return "so common";
            else if(_rarity == 1)
                return "common but cool";
            else if (_rarity == 2)
                return "hey, that's unusual";
            else if (_rarity == 3)
                return "whoa, seriously?";
            else
                return "holy sh*t, I can't believe it";
        }

        public int GetRarity(){ return _rarity; }

        public bool IsEnchanted() { return _isEnchanted; }

        public virtual void Enchant()
        {
            if (!_isEnchanted)
            {

                if (_rarity < 4)
                    _rarity++;
                _value *= 2;
                _description = "Enchanted: " + _description;
                _isEnchanted = true;
            }

        }
        public override string ToString()
        {
            return "Loot[" + _description + ", rarity: " + _rarity + ", " + HowRare() + ", value:" + _value + "]";
        }

    }
}
