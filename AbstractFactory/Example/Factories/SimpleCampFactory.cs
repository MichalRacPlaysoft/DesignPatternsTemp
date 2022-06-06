using AbstractFactory.Example.Items;
using AbstractFactory.Example.Mobs;

namespace AbstractFactory.Example.Factories;

public static class SimpleCampFactory
{
    public static EnemyCamp CreateEnemyCamp(string area)
    {
        EnemyCamp camp = null;
        
        if (area == "volcano")
        {
            camp = new EnemyCamp(new Dragon(), new DragonScales(4));
        }
        else if (area == "forest")
        {
            camp = new Random().Next(2) == 0 
                ? new EnemyCamp(new Wolf(), new WolfFangs(4)) 
                : new EnemyCamp(new Wolf(), new WolfSkin());
        }
        else
        {
            Console.WriteLine($"Unknown area: {area}\n"); 
        }
        
        return camp;
    }

    
}