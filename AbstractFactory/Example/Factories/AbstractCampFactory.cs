using AbstractFactory.Example.Items;
using AbstractFactory.Example.Mobs;

namespace AbstractFactory.Example.Factories
{
    public abstract class AbstractCampFactory
    {
        // These methods could provide instances of objects using different patterns such as Abstract Method or even Prototype
        public abstract Mob CreateEnemyMob();
        public abstract Item CreateLootItem();
    }
}

