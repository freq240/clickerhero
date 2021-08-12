namespace ClickerGame
{
    public class MotoHead : Head
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

        public MotoHead()
        {
            Level = ItemLevel.low;
            Name = "MotoHead";
            Reduction = (int)ReductionScale.lowHead;
        }
    }
}
