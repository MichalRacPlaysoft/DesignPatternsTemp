namespace AbstractFactory.Example.Mobs;

public abstract class Mob
{
    protected string Name => GetType().Name;
    public abstract void Attack();

    public override string ToString() => Name;
}