using System;

namespace ClickerGame
{
    class BumblerBoss : Boss
    {
        public override int Level => 5;

        //public override int HealthPoint => 1500;
        public override int HealthPoint { get; set; }

        public override int Regeneration { get; set; }

        public override string Name => Boss.NamesOfBosses[Level - 1];

        public override int DropItem()
        {
            throw new NotImplementedException();
        }
    }
}
