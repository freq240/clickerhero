namespace ClickerGame
{
    interface IWeapon : IItem
    {
        int Damage { get; set; }
        
        void Fire();
    }
}
