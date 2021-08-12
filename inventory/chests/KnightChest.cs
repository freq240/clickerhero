namespace ClickerGame
{
    public class KnightChest : Chest
    {
        private int reduction;
        public override int Reduction
        {
            get
            {
                return reduction;
            }
            set
            {
                reduction = value;
            }
        }
        public override ItemLevel Level { get; set; }
        public override string Name { get; set; }
        public KnightChest()
        {
            Name = "KnightChest";
            Level = ItemLevel.mid;
            Reduction = (int)ReductionScale.midChest;
        }
    }
}
