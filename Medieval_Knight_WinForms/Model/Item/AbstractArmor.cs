using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
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

        public override void Equip(ICombatantPuppet puppet)
        {
            //puppet - кукла персонажа - удобный агрегатор екипированых предметов
            if (ItemType == Specification.ItemType.ArmorChest)
                puppet.Chest = this;
            else if (ItemType == Specification.ItemType.ArmorHead)
                puppet.Head = this;

            IsЕquipped = true;
            //ItemEquiped?.Invoke(this, null);
        }

        public override void Unequip(ICombatantPuppet puppet)
        {
            //null - безопасно, см. set в CombatantPuppet
            if (ItemType == Specification.ItemType.ArmorChest)
                puppet.Chest = null;
            else if (ItemType == Specification.ItemType.ArmorHead)
                puppet.Head = null;

            IsЕquipped = false;
        }
    }
}
