using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using System;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class PlayerFactory : ICombatantFactory //Фабрика где создается, боец - игрок
    {
        public ICombatant GetCombatant(string name, double powerMultipler)//Specification.CharacterType characterType
        {
            if (powerMultipler > 3)
                powerMultipler = 3;
            else if (powerMultipler < 1)
                powerMultipler = 1;
            //создание базовых предметов (есть доп множитель для регулирование)        
            var defaultChest = new StandartArmor("Default Chest", 1, Convert.ToInt32(4 * powerMultipler), Specification.ItemType.ArmorChest);
            var defaultHead = new StandartArmor("Default Head", 1, Convert.ToInt32(2 * powerMultipler), Specification.ItemType.ArmorHead);
            var defaultWeapon = new StandartWeapon("Default Weapon", 1, Convert.ToInt32(5 * powerMultipler), Convert.ToInt32(5 * powerMultipler));
            var defaultJewelry = new StandartJewelry("Default Jewelry", 1, 1, 1, 1, 1);
            //создание одетой куклы
            var playerPuppet = new CombatantPuppet(defaultChest, defaultHead, defaultWeapon, defaultJewelry);

            var playerInventory = new CombatantInventory(playerPuppet);     
            playerInventory.AddGold(5000);

            //создание блока характеристик, с базовыми значения
            var playerStats = new CombatantStats(playerPuppet, 150, 10, 10, 5, 12);
            //сверха х-ик с екипровкой
            playerStats.UpdateItemsStats();
            playerStats.CurrentHp = playerStats.MaxHP;
            var player = new Player(name, playerInventory, playerPuppet, playerStats);//собственно создание объекта
            return player;
        }
    }
}
