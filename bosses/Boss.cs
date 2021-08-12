namespace ClickerGame
{
    public abstract class Boss : IBossAward
    {
        public abstract int Level { get; }      
        public abstract int HealthPoint { get; set; }
        public abstract int Regeneration { get; set; }
        public abstract string Name { get; }

        public abstract int DropItem();

        public static string[] NamesOfBosses = new string[]
        {
            "The Martyr Boss", 
            "The Screamer Boss", 
            "The Fearmonger Boss", 
            "The Manipulator Boss", 
            "The Bumbler Boss",
            "The Clueless Boss",
            "The Old-Schooler",
            "The God Boss"
        };
    }
}
