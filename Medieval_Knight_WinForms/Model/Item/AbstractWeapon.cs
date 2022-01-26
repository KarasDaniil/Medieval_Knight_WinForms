using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
using System;
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

        //public event EventHandler ItemEquiped;
        //public event EventHandler ItemUnequiped;

        //public event EventHandler WeaponHited;

        public override void Equip(ICombatantPuppet puppet)
        {
            puppet.Weapon = this;
            IsЕquipped = true;
            //ItemEquiped?.Invoke(this, null);
        }
        public override void Unequip(ICombatantPuppet puppet)
        {
            puppet.Weapon = null;
            IsЕquipped = false;
            //ItemUnequiped?.Invoke(this, null);
        }
    }
}
