namespace GME1011InheritanceSP1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random rng = new Random();
            List<Loot> lootBox = new List<Loot>();

            for (int i = 0; i < 10; i++)
            {
                int randomChance = rng.Next(1, 101);
                if (randomChance < 25)
                    lootBox.Add(new Loot());
                else if (randomChance < 50)
                    lootBox.Add(new Gem());
                else if (randomChance < 75)
                    lootBox.Add(new Weapon());
                else
                    lootBox.Add(new Food());
            }
          

            int totalValue = 0;
            int totalHealing = 0;
            int totalDamage = 0;
            foreach (Loot loot in lootBox)
            {
                Console.WriteLine(loot.DescribeLoot() + ":" + loot.GetValue());
                loot.Enchant();
                totalValue += loot.GetValue();

                if(loot.GetType() == typeof(Food))
                    totalHealing += ((Food)loot).GetHealing();

                if (loot.GetType() == typeof(Weapon))
                    totalDamage += ((Weapon)loot).GetDamage();

                if (loot.GetType() == typeof(Gem))
                    ((Gem)loot).CastSpell();

                //Console.WriteLine(loot.ToString());

            }
            Console.WriteLine("Value: " + totalValue);
            Console.WriteLine("Damage: " + totalDamage);
            Console.WriteLine("Healing: " + totalHealing);






        }
    }
}
