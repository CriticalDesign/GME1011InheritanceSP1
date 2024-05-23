namespace GME1011InheritanceSP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            List<Loot> lootBox = new List<Loot>();
            lootBox.Add(new Loot());
            lootBox.Add(new Loot(10, 3, "high quality lute"));
            lootBox.Add(new Loot(5, 2, "rusty steel sword"));
            lootBox.Add(new Loot(100, 4, "gem of reincarnation"));
            lootBox.Add(new Loot(1, 1, "apple"));
            lootBox.Add(new Loot(75, 2, "protective clothing"));

            int myLootIndex = rng.Next(1, lootBox.Count);
            Loot myLoot = lootBox[myLootIndex];
            Console.WriteLine("You reach into the creaky, rusty loot box and retrieve a " + myLoot.DescribeLoot());
            Console.WriteLine("Attempting Enchantment...");
            if(rng.Next(1,101) <= 50)
            {
                myLoot.Enchant();
                Console.WriteLine("It worked, I'm kinda surprised!");
            }
            else
            {
                Console.WriteLine("Figures...no luck!");
            }
            Console.WriteLine(myLoot);

            Console.WriteLine("-------------------------");

            Weapon myWeapon = new Weapon();
            myWeapon.Enchant();
            Console.WriteLine("Value:" + myWeapon.GetValue());
            Console.WriteLine("Description:" + myWeapon.DescribeLoot());
            Console.WriteLine("How rare:" + myWeapon.HowRare());
            Console.WriteLine("Is Enchanted?:" + myWeapon.IsEnchanted());

            Console.WriteLine("Damage:" + myWeapon.GetDamage());
            Console.WriteLine("Durability:" + myWeapon.GetDurability());

            Console.WriteLine("Damage dealt: " + myWeapon.Attack());

            Console.WriteLine();

            Weapon alisWeapon = new Weapon(100, 2, "sword, just sword", 9, 4);

            Console.WriteLine(alisWeapon.GetValue());
            Console.WriteLine(alisWeapon.DescribeLoot());
            Console.WriteLine(alisWeapon.HowRare());
            Console.WriteLine(alisWeapon.IsEnchanted());

            Console.WriteLine(alisWeapon.GetDamage());
            Console.WriteLine(alisWeapon.GetDurability());

            Console.WriteLine("Damage dealt: " + alisWeapon.Attack());


            Console.WriteLine("-------------------------");

            Food myFood = new Food();
            
            Console.WriteLine("Value:" + myFood.GetValue());
            Console.WriteLine("Description:" + myFood.DescribeLoot());
            Console.WriteLine("How rare:" + myFood.HowRare());
            Console.WriteLine("Is Enchanted?:" + myFood.IsEnchanted());

            Console.WriteLine("Healing Power:" + myFood.GetHealing());
            Console.WriteLine("Freshness:" + myFood.GetFreshness());

            Console.WriteLine("Healing received: " + myFood.Eat());

            Console.WriteLine();

            Food aaronsFood = new Food(100, 2, "Cambrian cafeteria food", 10, 5);
            aaronsFood.Enchant();

            Console.WriteLine("Value:" + aaronsFood.GetValue());
            Console.WriteLine("Description:" + aaronsFood.DescribeLoot());
            Console.WriteLine("How rare:" + aaronsFood.HowRare());
            Console.WriteLine("Is Enchanted?:" + aaronsFood.IsEnchanted());

            Console.WriteLine("Healing Power:" + aaronsFood.GetHealing());
            Console.WriteLine("Freshness:" + aaronsFood.GetFreshness());

            Console.WriteLine("Healing received: " + aaronsFood.Eat());





            /*
            int lootBoxValue = 0;
            for (int i = 0; i < lootBox.Count; i++)
            {
                Console.WriteLine(lootBox[i].DescribeLoot() + " - " + lootBox[i].GetValue());
                lootBoxValue += lootBox[i].GetValue();
            }
            Console.WriteLine("This loot is worth: " + lootBoxValue);
            */

        }
    }
}
