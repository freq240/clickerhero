namespace ClickerGame
{
    public class SoldierChest : Chest
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
        public SoldierChest()
        {
            Name = "SoldierChest";
            Level = ItemLevel.low;
            Reduction = (int)ReductionScale.lowChest;
        }      
    }
}
