namespace AbstractFactory.Example.Items
{
    public abstract class Item
    {
        public string Name => GetType().Name;
        public int Amount { get; }

        protected Item(int argAmount)
        {
            Amount = argAmount;
        }
        
        public abstract void Use();

        public virtual void Inspect()
        {
            Console.WriteLine($"{Name} in amount of {Amount}");
        }
    }
}

