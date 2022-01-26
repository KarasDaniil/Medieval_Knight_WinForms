using Medieval_Knight_WinForms.Model;
using Medieval_Knight_WinForms.Model.Item;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Medieval_Knight_WinForms.View
{
    public partial class FormShop : Form
    {
        private readonly BindingSource _bindingSourceShop;
        private readonly BindingSource _bindingSourcePlayer;
        private string _defaultShopName;
        public FormShop()
        {
            InitializeComponent();
            _defaultShopName = "Stiven";
            GameContoller.CreateShopKeeper(_defaultShopName, null);
            //подписка на событие на события завршения торговли, чтобы обновить таблицы и золото
            GameContoller.GetNpc(_defaultShopName).TradeComplete += UpdateInfo;
            GameContoller.GetNpc(_defaultShopName).TradeComplete += SetGoldNettoLabels;
            _bindingSourceShop = new BindingSource();
            _bindingSourcePlayer = new BindingSource();
        }

        private void UpdateInfo()//Методы установки таблицы, нужны чтобы обновлять всплывающие подсказки о деталях снаряжения                               
        {
            DGV_ShopInventory.SetItemTable(_bindingSourceShop, GameContoller.GetNpc(_defaultShopName).Inventory.ItemsList);

            DGV_PlayerInventory.SetItemTable(_bindingSourcePlayer, GameContoller.Player.Inventory.ItemsList);
        }

        private void Bt_BuySelected_Click(object sender, EventArgs e)//кнопка-обработчик покупки героем предметов
        {
            //по причине неопределенности LINQ для DataGridViewRowCollection и тонкости сложной привязки данных, пришлось скопировать 
            List<IItem> boughtItems = new List<IItem>();
            //перебор строк и отбор отмеченых предметов
            foreach (DataGridViewRow row in DGV_ShopInventory.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    boughtItems.Add((IItem)row.DataBoundItem);
                }
            }
            GameContoller.GetNpc(_defaultShopName).SellOwnItem(GameContoller.Player, boughtItems.ToArray());

            //_shopKeeper.SellOwnItem(Player.Hero, from row in DGV_ShopInventory.Rows
            //                                     where (DataGridViewRow)row.
            //                                     select row);
        }

        private void Bt_SellSelected_Click(object sender, EventArgs e)//кнопка-обработчик продажи героем предметов
        {
            List<IItem> selledItems = new List<IItem>();
            foreach (DataGridViewRow row in DGV_PlayerInventory.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    selledItems.Add((IItem)row.DataBoundItem);
                }
            }
            GameContoller.GetNpc(_defaultShopName).BuyOtherItems(GameContoller.Player, selledItems.ToArray());
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            UpdateInfo();
            SetGoldNettoLabels();
        }

        private void SetGoldNettoLabels()//Обработка изменения золота
        {
            label_ShopCurrentGoldNum.Text = $"{GameContoller.GetNpc(_defaultShopName).Inventory.Gold}";
            label_YourCurrentGoldNum.Text = $"{GameContoller.Player.Inventory.Gold}";
            decimal ShopItemGoldSum = 0;
            foreach (DataGridViewRow row in DGV_ShopInventory.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    ShopItemGoldSum += ((IItem)row.DataBoundItem).ItemCost;
                }
            }

            decimal CustomerItemGoldSum = 0;
            foreach (DataGridViewRow row in DGV_PlayerInventory.Rows)
            {
                if (row.Cells[0].Value != null && (bool)row.Cells[0].Value)
                {
                    CustomerItemGoldSum += ((IItem)row.DataBoundItem).ItemCost;
                }
            }
            label_ShopCurrentGoldNetto.Text = $"{ShopItemGoldSum - CustomerItemGoldSum}";
            label_YourCurrentGoldNetto.Text = $"{CustomerItemGoldSum - ShopItemGoldSum}";
        }

        private void DGV_PlayerInventory_CellContentClick(object sender, DataGridViewCellEventArgs cell)
        {
            if (cell.ColumnIndex == 0 && cell.RowIndex != -1)
            {
                //нужно чтобы с первого клика срабатывало переключение галки 
                //Без этого: сначала вызывается это события, и только ПОЗЖЕ меняется значание чекБокса, то-есть считает измения золота с задержкой в 1 клик 
                ((DataGridViewCheckBoxCell)DGV_PlayerInventory.Rows[cell.RowIndex].Cells[cell.ColumnIndex]).Value = 
                    !Convert.ToBoolean(((DataGridViewCheckBoxCell)DGV_PlayerInventory.Rows[cell.RowIndex].Cells[cell.ColumnIndex]).Value); 
                SetGoldNettoLabels();
            }
        }

        private void DGV_ShopInventory_CellContentClick(object sender, DataGridViewCellEventArgs cell)
        {
            if (cell.ColumnIndex == 0 && cell.RowIndex != -1)
            {
                ((DataGridViewCheckBoxCell)DGV_ShopInventory.Rows[cell.RowIndex].Cells[cell.ColumnIndex]).Value = 
                    !Convert.ToBoolean(((DataGridViewCheckBoxCell)DGV_ShopInventory.Rows[cell.RowIndex].Cells[cell.ColumnIndex]).Value);
                SetGoldNettoLabels();
            }
        }

        private void Bt_PlusGold_Click(object sender, EventArgs e)
        {
            GameContoller.Player.Inventory.AddGold(200);
            SetGoldNettoLabels();
        }

        private void Bt_MinusGold_Click(object sender, EventArgs e)
        {
            GameContoller.Player.Inventory.DeductGold(200);
            SetGoldNettoLabels();
        }

        private void FormShop_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
