using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Item
{
    interface IItem
    {
        bool IsЕquipped { get; }
        string ItemName { get; }
        Specification.ItemType ItemType { get; }
        decimal ItemCost { get; set; }
        void Equip(ICombatantPuppet puppet);
        void Unequip(ICombatantPuppet puppet);
        //event EventHandler ItemEquiped;
        //event EventHandler ItemUnequiped;
    }
}
