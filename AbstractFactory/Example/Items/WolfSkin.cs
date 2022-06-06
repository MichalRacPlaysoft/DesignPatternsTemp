namespace AbstractFactory.Example.Items;

public class WolfSkin : Item
{
    public const int DEFAULT_AMOUNT = 1;
    public WolfSkin() : base(DEFAULT_AMOUNT)
    {
    }

    public override void Use()
    {
        throw new NotImplementedException();
    }
}