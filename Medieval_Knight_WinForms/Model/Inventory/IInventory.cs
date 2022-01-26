using Medieval_Knight_WinForms.Model.Item;
using System.Collections.Generic;
namespace Medieval_Knight_WinForms.Model.Inventory
{
    interface IInventory
    {
        decimal Gold { get; }
        List<IItem> ItemsList { get; }

        void AddItem(params IItem[] addedItem);
        void RemoveItem(IItem removedItem);
        public void AddGold(decimal goldPlus);
        public void DeductGold(decimal goldMinus);
    }
}
