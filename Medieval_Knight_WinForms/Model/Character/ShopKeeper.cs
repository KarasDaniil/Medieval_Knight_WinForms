using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using System;
using System.Linq;
namespace Medieval_Knight_WinForms.Model.Character
{
    class ShopKeeper : AbstractNpc
    {
        public ShopKeeper(string name) : base(name)
        {
        }

        public ShopKeeper(string name, IInventory inventory) : base(name, inventory)
        {

        }

        //public virtual event Action TradeComplete;

        public override void BuyOtherItems(ICharacter customer, params IItem[] boughtItems)//Метод покупки торговцем предметов
        {
            if (boughtItems.Length == 0)
                return;
            if (Inventory.Gold < (from item in boughtItems select item.ItemCost).Sum())
            {
                System.Windows.Forms.MessageBox.Show("Shop does not have enought gold");
                return;
            }
            foreach (var item in boughtItems)
            {
                if (item.IsЕquipped)
                    continue;
                Inventory.DeductGold(item.ItemCost);
                customer.Inventory.AddGold(item.ItemCost);
                Inventory.AddItem(item);
                item.ItemCost = Math.Round(item.ItemCost * Convert.ToDecimal(1.25), 2);
                customer.Inventory.RemoveItem(item);
            }
            TradeComplete?.Invoke();
        }

        public override void SellOwnItem(ICharacter customer, params IItem[] selledItems)
        {
            if (selledItems.Length == 0)
                return;
            if (customer.Inventory.Gold < (from item in selledItems select item.ItemCost).Sum())
            {
                System.Windows.Forms.MessageBox.Show("Not enought gold");
                return;
            }
            foreach (var item in selledItems)
            {
                customer.Inventory.DeductGold(item.ItemCost);
                Inventory.AddGold(item.ItemCost);
                customer.Inventory.AddItem(item);
                Inventory.RemoveItem(item);
            }
            TradeComplete?.Invoke();
        }

        public virtual void SetDefaultShopInventory()
        {
            //*Переделать в фабрику!!!
            Inventory.AddGold(1000);
            Inventory.AddItem(new StandartWeapon("Good Sword", 70, 12, 8), new CursedWeapon("Cursed Sword", 20, 15, 15));

            Inventory.AddItem(new StandartArmor("Full Plate Armor", 400, 45, Specification.ItemType.ArmorChest));
            Inventory.AddItem(new StandartArmor("Half Plate Armor", 299, 30, Specification.ItemType.ArmorChest));
            Inventory.AddItem(new StandartArmor("Chainmail Armor", 200, 18, Specification.ItemType.ArmorChest));
            Inventory.AddItem(new StandartArmor("Crusader Helmet", 180, 20, Specification.ItemType.ArmorHead));
            Inventory.AddItem(new StandartArmor("Simple Helmet", 150, 12, Specification.ItemType.ArmorHead));
            Inventory.AddItem(new StandartJewelry("Red Jewel", 600, 1, 1.2, 1, 1.25), new StandartJewelry("Green Jewel", 800, 1.5, 1, 1.3, 1), new StandartJewelry("Blue Jewel", 2000, 1.5, 1.5, 1.5, 1.5));
            Inventory.AddItem(new DamageJewelry("Damage Jewel", 1500, 1, 1, 1, 1));
            //Inventory.AddItem(new StandartArmor("Test Helmet", 1, 1, Specification.ItemType.Jewelry));
        }
    }
}
