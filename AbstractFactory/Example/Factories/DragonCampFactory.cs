using AbstractFactory.Example.Items;
using AbstractFactory.Example.Mobs;

namespace AbstractFactory.Example.Factories
{
    public class DragonCampFactory : AbstractCampFactory
    {
        public override Mob CreateEnemyMob() => new Dragon();

        public override Item CreateLootItem()
        {
            var rng = new Random();
            return new DragonScales(rng.Next(1, 5));
        }
    } 
}
