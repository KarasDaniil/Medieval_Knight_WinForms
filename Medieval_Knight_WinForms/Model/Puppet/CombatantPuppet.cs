using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Puppet
{
    class CombatantPuppet : ICombatantPuppet //"кукла персонажа" - удобный агрегатор екипированых предметов
    {
        public virtual IArmor Chest { get; set; }
        public virtual IArmor Head { get; set; }
        public virtual IWeapon Weapon { get; set; }
        public virtual IJewelry Jewelry { get; set; }
    }
}
