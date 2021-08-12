using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class Bow : Weapon
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
        public Bow()
        {
            Name = "Bow";
            Level = ItemLevel.high;
            Damage = (int)DamageScale.high;
        }


        public override void Fire()
        {
            throw new NotImplementedException();
        }
    }
}
