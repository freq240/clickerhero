namespace ClickerGame
{
    public class VikingHead : Head
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
        public VikingHead()
        {
            Name = "VikingHead";
            Level = ItemLevel.mid;
            Reduction = (int)ReductionScale.midHead;
        }
    }
}
