using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class SpartaHead : Head
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
        public SpartaHead()
        {
            Name = "SpartaHead";
            Level = ItemLevel.high;
            Reduction = (int)ReductionScale.highHead;
        }
    }
}
