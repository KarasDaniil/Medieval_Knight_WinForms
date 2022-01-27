using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using System;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class EnemyFactory : ICombatantFactory //Фабрика где создается, боец - враг
    {
        public ICombatant GetCombatant(string name, double powerMultipler)//Specification.CharacterType characterType
        {
            if (powerMultipler > 3)
                powerMultipler = 3;
            else if (powerMultipler < 1)
                powerMultipler = 1;
            //создание базовых предметов
            var defaultChest = new StandartArmor("Enemy Default Chest", 550, Convert.ToInt32(40 * powerMultipler), Specification.ItemType.ArmorChest);
            var defaultHead = new StandartArmor("Enemy Default Head", 350, Convert.ToInt32(30 * powerMultipler), Specification.ItemType.ArmorHead);
            var defaultWeapon = new StandartWeapon("Enemy Default Weapon", 400, Convert.ToInt32(25 * powerMultipler), Convert.ToInt32(20 * powerMultipler));
            var defaultJewelry = new StandartJewelry("Enemy Default Jewelry", 1000, 1.2, 1.2, 1.2, 1.2);
            //создание одетой куклы
            var enemyPuppet = new CombatantPuppet(defaultChest, defaultHead, defaultWeapon, defaultJewelry);
            //создание инвентаря с этой куклой 
            var enemyInventory = new CombatantInventory(enemyPuppet);
            //добавление в инветарь базовых передметов, чтобы можно было их украсть (флаг екипировки у них снят, но это не важно)
            enemyInventory.AddItem(defaultChest, defaultHead, defaultWeapon, defaultJewelry);
            enemyInventory.AddGold(1111);
            //создание блока характеристик, с базовыми значения
            var enemyStats = new CombatantStats(enemyPuppet, 150, 10, 10, 5, 12);
            //сверха х-ик с екипровкой
            enemyStats.UpdateItemsStats();
            enemyStats.CurrentHp = enemyStats.MaxHP;
            var enemy = new Enemy(name, enemyInventory, enemyPuppet, enemyStats);//собственно создание объекта
            return enemy;
        }
    }
}
