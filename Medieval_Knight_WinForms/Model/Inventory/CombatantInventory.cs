using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Inventory
{
    class CombatantInventory : StandartInventory, ICombatantInventory // особенность инвентаря бойца - возможность одеть предмет из инвентаря
    {
        private ICombatantPuppet _puppet;
        public CombatantInventory(ICombatantPuppet holderCharacter) : base()
        {
            _puppet = holderCharacter;
            ValidateInventory();
        }

        private void ValidateInventory()//метод нужен чтобы снять все предметы, если придет собраная кукла(инвентарь) 
        {
            foreach (var item in ItemsList)
            {
                item.Unequip(_puppet);
            }
        }

        public void EquipItem(int itemIndex)
        {
            //Если инвентарь уже содержит екипированый предмет такого же типа, то одевание предмета не будет
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
            //Если инвентарь уже содержит екипированый предмет такого же типа, то предмет будет снят
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
