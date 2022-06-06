namespace AbstractFactory.Example.Items;

public class WolfFangs : Item
{
    public const int DEFAULT_AMOUNT = 4;

    public WolfFangs() : base(DEFAULT_AMOUNT)
    {
    }
    
    public WolfFangs(int argAmount) : base(argAmount)
    {
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }
}