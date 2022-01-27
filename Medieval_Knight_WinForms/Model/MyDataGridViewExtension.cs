using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Stats;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
namespace Medieval_Knight_WinForms.Model
{
    static class MyDataGridViewExtension
    {
        public static void SetItemTable(this DataGridView dataGridView, BindingSource bindingSource, List<IItem> itemsList)
        {
            //Заглушка чтобы не перекидавить привязки лишний раз 
            if (dataGridView.DataSource == null | bindingSource == null) /**/
            {
                bindingSource.DataSource = itemsList;
                dataGridView.DataSource = bindingSource;
            }
            try
            {
                bindingSource.ResetBindings(true);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            var str = new StringBuilder();
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[0].Value = false;
                str.Clear();
                //формирование описания предметов
                if ((IItem)row.DataBoundItem is IArmor armor)
                {
                    str.Append($"Type: {armor.ItemType}\nArmor Score: {armor.ArmorScore}");
                    row.Cells["ItemName"].ToolTipText = str.ToString();
                }
                else if ((IItem)row.DataBoundItem is IWeapon weapon)
                {
                    str.Append($"Type: {weapon.ItemType}\nAttack: {weapon.WeaponAtack}\nDamage: {weapon.WeaponDamage}");
                    row.Cells["ItemName"].ToolTipText = str.ToString();
                }
                else if ((IItem)row.DataBoundItem is IJewelry jewelry)
                {
                    str.Append($"Type: {jewelry.ItemType}\nMax HP multipler: {jewelry.MaxHpMult}\nAttack multipler: {jewelry.AttackMult}" +
                        $"\nDefence multipler: {jewelry.DefenceMult}\nDamage multipler: {jewelry.DamageMult}" +
                        $"\nSkill: {jewelry.JewelSkillName}");
                    row.Cells["ItemName"].ToolTipText = str.ToString();
                }
                else
                {
                    str.Append($"Unknown");
                    row.Cells["ItemName"].ToolTipText = str.ToString();
                }
            }
        }
        public static void SetStatTable(this DataGridView dataGridView, BindingSource bindingSource, List<ICombatantStats> combatantStats, List<string> names)
        {
            bindingSource.DataSource = combatantStats;

            //Заглушка чтобы не перекидавить привязку лишний раз 
            if (dataGridView.DataSource == null)
            {
                dataGridView.DataSource = bindingSource;
            }
            bindingSource.ResetBindings(true);

            var tmpStr = new StringBuilder();
            for (int i = 0; i < combatantStats.Count; i++)//проход по всем строкам и присвоение правильного(уникального) описания для каждого Стата
            {
                //Присвоение имени бойца в столбец
                dataGridView.Rows[i].Cells["CombatantName"].Value = names[i];
                tmpStr.Clear();
                //формирование строки для описания подробностей характеристики (громоздко, но зато удобно - один метод на все статы)
                tmpStr.Append($"Value: {combatantStats[i].MaxHP}\nBase: {Convert.ToInt32(combatantStats[i].MaxHP / combatantStats[i].AttachedPuppet.Jewelry.MaxHpMult)}" +
                    $"\nJewel Name: {combatantStats[i].AttachedPuppet.Jewelry.ItemName}" +
                    $"\nJewel multipler: {combatantStats[i].AttachedPuppet.Jewelry.MaxHpMult}");
                dataGridView.Rows[i].Cells["MaxHP"].ToolTipText = tmpStr.ToString();
                tmpStr.Clear();
                tmpStr.Append($"Value: {combatantStats[i].CurrentHp}");
                dataGridView.Rows[i].Cells["CurrentHp"].ToolTipText = tmpStr.ToString();
                tmpStr.Clear();
                tmpStr.Append($"Value: {combatantStats[i].Attack}" +
                    $"\nItem Name: {combatantStats[i].AttachedPuppet.Weapon.ItemName}" +
                    $"\nItem Bonus: {combatantStats[i].AttachedPuppet.Weapon.WeaponAtack}" +
                    $"\nJewel multipler: {combatantStats[i].AttachedPuppet.Jewelry.AttackMult}");
                dataGridView.Rows[i].Cells["Attack"].ToolTipText = tmpStr.ToString();
                tmpStr.Clear();
                tmpStr.Append($"Value: {combatantStats[i].Defence}" +
                    $"\nItems Names: {combatantStats[i].AttachedPuppet.Chest.ItemName}, {combatantStats[i].AttachedPuppet.Head.ItemName}" +
                    $"\nItem Bonus: {combatantStats[i].AttachedPuppet.Chest.ArmorScore + combatantStats[i].AttachedPuppet.Head.ArmorScore}" +
                    $"\nJewel multipler: {combatantStats[i].AttachedPuppet.Jewelry.DefenceMult}");
                dataGridView.Rows[i].Cells["Defence"].ToolTipText = tmpStr.ToString();
                tmpStr.Clear();
                tmpStr.Append($"Value: {combatantStats[i].DamageMax}" +
                    $"\nItem Name: {combatantStats[i].AttachedPuppet.Weapon.ItemName}" +
                    $"\nItem Bonus: {combatantStats[i].AttachedPuppet.Weapon.WeaponDamage}" +
                    $"\nJewel multipler: {combatantStats[i].AttachedPuppet.Jewelry.DamageMult}");
                dataGridView.Rows[i].Cells["DamageMin"].ToolTipText = tmpStr.ToString();
                tmpStr.Clear();
                tmpStr.Append($"Value: {combatantStats[i].DamageMin}" +
                    $"\nItem Name: {combatantStats[i].AttachedPuppet.Weapon.ItemName}" +
                    $"\nItem Bonus: {combatantStats[i].AttachedPuppet.Weapon.WeaponDamage}" +
                    $"\nJewel multipler: {combatantStats[i].AttachedPuppet.Jewelry.DamageMult}");
                dataGridView.Rows[i].Cells["DamageMax"].ToolTipText = tmpStr.ToString();
            }
            //выключаю лишний столбец
            dataGridView.Columns["AttachedPuppet"].Visible = false;
            //ссужаю ширину столбика к границам заголовка столбика
            dataGridView.Columns["MaxHP"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView.Columns["CurrentHp"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView.Columns["Attack"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView.Columns["Defence"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView.Columns["DamageMin"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            dataGridView.Columns["DamageMax"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
        }
    }
}
