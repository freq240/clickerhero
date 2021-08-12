namespace ClickerGame
{
    public abstract class Chest : IArmor
    {
        public abstract int Reduction { get; set; }
        public abstract ItemLevel Level { get; set; }
        public abstract string Name { get; set; }
    }
}
