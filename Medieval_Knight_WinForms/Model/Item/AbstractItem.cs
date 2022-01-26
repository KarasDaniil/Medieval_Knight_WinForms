using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Item
{
    abstract class AbstractItem : IItem //Создан, чтобы я лишний раз не повторял свойства и их конструктор
    {
        public virtual string ItemName { get; }
        public virtual decimal ItemCost { get; set; }
        public virtual Specification.ItemType ItemType { get; protected set; }
        public virtual bool IsЕquipped { get; protected set; }
        public AbstractItem(string name, decimal cost, Specification.ItemType itemType)
        {
            ItemName = name;
            ItemCost = cost;
            ItemType = itemType;
            IsЕquipped = false;
        }
        public abstract void Equip(ICombatantPuppet puppet);

        public abstract void Unequip(ICombatantPuppet puppet);
    }
}
