using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Puppet
{
    interface ICombatantPuppet //"кукла персонажа" - удобный агрегатор екипированых предметов
    {
        IArmor Chest { get; set; }
        IArmor Head { get; set; }
        IWeapon Weapon { get; set; }
        IJewelry Jewelry { get; set; }
    }
}
