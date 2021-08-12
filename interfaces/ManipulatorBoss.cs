using System;

namespace ClickerGame
{
    class ManipulatorBoss : Boss
    {
        public override int Level => 4;

        //public override int HealthPoint => 1200;
        public override int HealthPoint { get; set; }

        public override int Regeneration { get; set; }

        public override string Name => Boss.NamesOfBosses[Level - 1];

        public override int DropItem()
        {
            throw new NotImplementedException();
        }
    }
}
