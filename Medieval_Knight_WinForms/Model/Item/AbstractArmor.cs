using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
using System;
namespace Medieval_Knight_WinForms.Model.Item
{
    abstract class AbstractArmor : AbstractItem, IArmor
    {
        public virtual int ArmorScore { get; private set; }

        public AbstractArmor(string name, decimal cost, Specification.ItemType itemType, int armor) : base(name, cost, itemType)
        {
            //явный недостаток разработаной системы - позволение клиенту самому указать тип брони
            if (itemType != Specification.ItemType.ArmorHead && itemType != Specification.ItemType.ArmorChest)
            {
                System.Windows.Forms.MessageBox.Show("Created armor with wrong item type!");
                ItemType = Specification.ItemType.ArmorChest;//чтобы не было runtime ошибки
            }
            ArmorScore = armor;
        }

        //public event EventHandler ItemEquiped;
        //public event EventHandler ItemUnequiped;

        //public abstract void BeginDefendAction(ICombatantStats stats);
        //public abstract void EndDefendAction(ICombatantStats stats);
        //public event EventHandler ArmorWasHit;

        public override void Equip(ICombatantPuppet puppet)
        {
            if (ItemType == Specification.ItemType.ArmorChest)
                puppet.Chest = this;
            else if (ItemType == Specification.ItemType.ArmorHead)
                puppet.Head = this;

            IsЕquipped = true;
            //ItemEquiped?.Invoke(this, null);
        }

        public override void Unequip(ICombatantPuppet puppet)
        {
            if (ItemType == Specification.ItemType.ArmorChest)
                puppet.Chest = null;
            else if (ItemType == Specification.ItemType.ArmorHead)
                puppet.Head = null;

            IsЕquipped = false;
            //ItemUnequiped?.Invoke(this, null);
        }
    }
}
