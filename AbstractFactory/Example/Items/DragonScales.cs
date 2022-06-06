namespace AbstractFactory.Example.Items;

public class DragonScales : Item
{
    public DragonScales(int argAmount) : base(argAmount)
    {
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }

    public override void Inspect()
    {
        base.Inspect();
        Console.WriteLine($"They are shiny");
    }
}