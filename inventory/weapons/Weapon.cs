using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public abstract class Weapon : IWeapon
    {
        public abstract int Damage { get; set; }
        public abstract ItemLevel Level { get; set; }
        public abstract string Name { get; set; }
        public abstract void Fire();

    }
}
