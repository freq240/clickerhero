using System.Collections.Generic;

namespace ClickerGame
{
    class Hero
    {
        public static int ID { get; set; }

        public const int STANDART_DAMAGE_VALUE = 10;
        public const int STANDART_REDUCTION_VALUE = 5;

        public static List<IItem> EquipedItems = new List<IItem>();

        public static int HeroDamage = STANDART_DAMAGE_VALUE;
        public static int HeroReduction = STANDART_REDUCTION_VALUE;

        public static int HeroLevel = 1;
    }
}
