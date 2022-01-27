using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class NullFactory : ICombatantFactory//на случай, если будет забыто создать фабрику для нового типа бойцов 
    {
        public ICombatant GetCombatant(string name, double powerMultipler)
        {
            //Я не хотел возвращать Null, поетому вернул такого вот "пустого" врага
            var puppet = new CombatantPuppet(new StandartArmor("", 1, 0, Specification.ItemType.ArmorChest), new StandartArmor("", 1, 0, Specification.ItemType.ArmorHead), new StandartWeapon("", 1, 0, 0), new StandartJewelry("", 1, 1, 1, 1, 1));
            return new Enemy("NullFactoryProduct", new CombatantInventory(puppet), puppet, new CombatantStats(puppet));
        }
    }
}
