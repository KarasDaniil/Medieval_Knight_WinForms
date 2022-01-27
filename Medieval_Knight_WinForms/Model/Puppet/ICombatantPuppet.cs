using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Puppet
{
    interface ICombatantPuppet //"кукла персонажа" - удобный агрегатор екипированых предметов
    {                          //По сути хранит ссылки на екипированые предметы в инвентаре, чтобы потом их там не искать - удобно
        IArmor Chest { get; set; }
        IArmor Head { get; set; }
        IWeapon Weapon { get; set; }
        IJewelry Jewelry { get; set; }
    }
}
