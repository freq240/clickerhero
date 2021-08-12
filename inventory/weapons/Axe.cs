using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class Axe : Weapon
    {
        public override ItemLevel Level { get; set; }
        private int damage;
        public override int Damage
        {
            get
            {
                return damage;
            }
            set
            {
                damage = value;
            }
        }
        public override string Name { get; set; }
        public Axe()
        {
            Name = "Axe";
            Level = ItemLevel.low;
            Damage = (int)DamageScale.low;
        }

        public override void Fire()
        {
            throw new NotImplementedException();
        }

    }
}
