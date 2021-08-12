namespace ClickerGame
{
    public class EmperorChest : Chest
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
        public EmperorChest()
        {
            Name = "EmperorChest";
            Level = ItemLevel.high;
            Reduction = (int)ReductionScale.highChest;
        }
    }
}
