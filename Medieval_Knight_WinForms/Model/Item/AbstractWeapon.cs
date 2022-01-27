using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Item
{
    abstract class AbstractWeapon : AbstractItem, IWeapon
    {
        public virtual int WeaponAtack { get; protected set; }
        public virtual int WeaponDamage { get; protected set; }

        public AbstractWeapon(string name, decimal cost, int atack, int damage) : base(name, cost, Specification.ItemType.Weapon)
        {
            WeaponAtack = atack;
            WeaponDamage = damage;
        }

        public override void Equip(ICombatantPuppet puppet)
        {
            puppet.Weapon = this;
            IsЕquipped = true;
        }

        public override void Unequip(ICombatantPuppet puppet)
        {
            //null - безопасно, см. set в CombatantPuppet
            puppet.Weapon = null;
            IsЕquipped = false;
        }
    }
}
