using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using System.Linq;
namespace Medieval_Knight_WinForms.Model.Inventory
{
    class CombatantInventory : StandartInventory, ICombatantInventory
    {
        private ICombatantPuppet _puppet;
        public CombatantInventory(ICombatantPuppet holderCharacter) : base()
        {
            _puppet = holderCharacter;
            ValidateInventory();
        }

        private void ValidateInventory()
        {
            foreach (var item in ItemsList)
            {
                item.Unequip(_puppet);
            }
        }

        public void EquipItem(int itemIndex)
        {
            if (ItemsList.Contains(ItemsList.Find(item => item.ItemType == ItemsList[itemIndex].ItemType && item.IsЕquipped)))
            {

                System.Windows.Forms.MessageBox.Show("Slot taken");
            }
            else
            {
                ItemsList[itemIndex].Equip(_puppet);
            }
        }

        public void UnequipItem(int itemIndex)
        {
            if (ItemsList.Contains(ItemsList.Find(item => item.ItemType == ItemsList[itemIndex].ItemType && item.IsЕquipped)))
            {
                ItemsList[itemIndex].Unequip(_puppet);
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Item is already unequiped");
            }
        }
    }
}
