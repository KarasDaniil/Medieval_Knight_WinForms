using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using System;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class EnemyFactory : ICombatantFactory
    {
        public ICombatant GetCombatant(string name, double powerMultipler)//Specification.CharacterType characterType
        {
            if (powerMultipler > 3)
                powerMultipler = 3;
            else if (powerMultipler < 1)
                powerMultipler = 1;
            var defaultChest = new StandartArmor("Enemy Default Chest", 550, Convert.ToInt32(40 * powerMultipler), Specification.ItemType.ArmorChest);
            var defaultHead = new StandartArmor("Enemy Default Head", 350, Convert.ToInt32(30 * powerMultipler), Specification.ItemType.ArmorHead);
            var defaultWeapon = new StandartWeapon("Enemy Default Weapon", 400, Convert.ToInt32(25 * powerMultipler), Convert.ToInt32(20 * powerMultipler));
            var defaultJewelry = new StandartJewelry("Enemy Default Jewelry", 1000, 1.2, 1.2, 1.2, 1.2);
            var enemyPuppet = new CombatantPuppet(defaultChest, defaultHead, defaultWeapon, defaultJewelry);

            var enemyInventory = new CombatantInventory(enemyPuppet);
            enemyInventory.AddItem(defaultChest, defaultHead, defaultWeapon, defaultJewelry);
            enemyInventory.AddGold(1111);
            var enemyStats = new CombatantStats(enemyPuppet, 150, 10, 10, 5, 12);
            enemyStats.UpdateItemsStats();
            enemyStats.CurrentHp = enemyStats.MaxHP;
            var enemy = new Enemy(name, enemyInventory, enemyPuppet, enemyStats);
            return enemy;
        }
    }
}
