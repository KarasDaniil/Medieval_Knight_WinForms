using Medieval_Knight_WinForms.Model.Item;
using System.Collections.Generic;
namespace Medieval_Knight_WinForms.Model.Inventory
{
    class StandartInventory : IInventory
    {
        public virtual decimal Gold { get; protected set; }
        public virtual List<IItem> ItemsList { get; protected set; }

        public StandartInventory()
        {
            Gold = 0;
            ItemsList = new List<IItem>();
        }
        public StandartInventory(int gold)
        {
            Gold = gold;
            ItemsList = new List<IItem>();
        }

        public virtual void AddItem(params IItem[] addedItem)
        {
            ItemsList.AddRange(addedItem);
        }

        public virtual void RemoveItem(IItem removedItem)
        {
            ItemsList.Remove(removedItem);
        }

        public virtual IItem GetItem(int itemIndex)
        {
            return ItemsList[itemIndex];
        }

        public virtual void AddGold(decimal goldPlus)
        {
            Gold += goldPlus;
        }

        public virtual void DeductGold(decimal goldMinus)
        {
            Gold -= goldMinus;
            if (Gold < 0)
                Gold = 0;
        }
    }
}
