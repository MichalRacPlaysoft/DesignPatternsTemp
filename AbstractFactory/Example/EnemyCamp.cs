using AbstractFactory.Example.Factories;

namespace AbstractFactory.Example
{
    using Mobs;
    using Items;
    
    public class EnemyCamp
    {
        public Mob Mob { get; }
        public Item Item { get; }

        public EnemyCamp(AbstractCampFactory argCampFactory)
        {
            Mob = argCampFactory.CreateEnemyMob();
            Item = argCampFactory.CreateLootItem();
        }

        public override string ToString()
        {
            return "Camp consist of: \n" 
                   + $"{Mob} and {Item.Amount} {Item.Name}";
        }
    }
}

