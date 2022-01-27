using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Inventory
{
    interface ICombatantInventory : IInventory
    {
        void EquipItem(int itemIndex);
        void UnequipItem(int itemIndex);
    }
}
