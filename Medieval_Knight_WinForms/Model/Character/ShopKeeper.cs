using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using System;
using System.Linq;
namespace Medieval_Knight_WinForms.Model.Character
{
    class ShopKeeper : AbstractNpc //Описание нпс - торговца 
    {
        public ShopKeeper(string name) : base(name)
        {
            SetDefaultShopInventory();
        }

        public ShopKeeper(string name, IInventory inventory) : base(name, inventory)
        {
            SetDefaultShopInventory();
        }

        public override void BuyOtherItems(ICharacter customer, params IItem[] boughtItems)//Метод покупки торговцем предметов
        {
            if (boughtItems.Length == 0)//не* лишняя заглушка - проверка
                return;
            if (Inventory.Gold < (from item in boughtItems select item.ItemCost).Sum())//если сумма выбраных предметов превышает золото, то обмен не произойтет
            {
                System.Windows.Forms.MessageBox.Show("Shop does not have enought gold");
                return;
            }
            foreach (var item in boughtItems)//цикл где происходит передача предметов и вычитание золота
            {
                if (item.IsЕquipped)//пропускает продажу екипированых предметов
                    continue;
                Inventory.DeductGold(item.ItemCost);
                customer.Inventory.AddGold(item.ItemCost);
                Inventory.AddItem(item);
                item.ItemCost = Math.Round(item.ItemCost * Convert.ToDecimal(1.25), 2);//торговец делает наценку при покупке(чтобы продать дороже)
                customer.Inventory.RemoveItem(item);
            }
            TradeComplete?.Invoke();//активация делегата, о завершении торговли (Чтобы обновить UI)
        }

        public override void SellOwnItem(ICharacter customer, params IItem[] selledItems)//Метод продажи торговцем предметов
        {
            if (selledItems.Length == 0)//не* лишняя заглушка - проверка
                return;
            if (customer.Inventory.Gold < (from item in selledItems select item.ItemCost).Sum())//если сумма выбраных предметов превышает золото, то обмен не произойтет
            {
                System.Windows.Forms.MessageBox.Show("Not enought gold");
                return;
            }
            foreach (var item in selledItems)//цикл где происходит передача предметов и вычитание золота
            {
                customer.Inventory.DeductGold(item.ItemCost);
                Inventory.AddGold(item.ItemCost);
                customer.Inventory.AddItem(item);
                Inventory.RemoveItem(item);
            }
            TradeComplete?.Invoke();//активация делегата, о завершении торговли (Чтобы обновить UI)
        }

        private void SetDefaultShopInventory()//метод задает стартовый инвентарь для торговца
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
        }
    }
}
