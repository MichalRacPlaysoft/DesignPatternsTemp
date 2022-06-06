using AbstractFactory.Example.Items;
using AbstractFactory.Example.Mobs;

namespace AbstractFactory.Example.Factories
{
    public class WolfCampFactory : AbstractCampFactory
    {
        public override Mob CreateEnemyMob() => new Wolf();

        // Alternative: you can imagine a spreadsheet db table with different loots for different camps,
        // here we could just reference the data structure holding data for correct camp and choose correct item
        public override Item CreateLootItem()
        {
            var rng = new Random();
            return rng.Next() % 2 == 0 
                ? new WolfFangs() 
                : new WolfSkin();
        }
    }
}

