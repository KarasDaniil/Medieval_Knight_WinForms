using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using Medieval_Knight_WinForms.Model.Item;
using System.Collections.Generic;
using System.Linq;
namespace Medieval_Knight_WinForms.Model
{
    static class GameContoller//Класс служит прослойкой между UI и системой(игрой)
    {                         //Благодаря етому UI имеет доступ только к минимально необходимому функционалу 
        private static Player _player;
        private static List<INpc> _npcList;
        private static List<ICombatant> _combatantList;

        static GameContoller()
        {
            //выбрал такую инициализацию, так как я только здесь буду изменять старые типы на разработаные новые,
            //и все будет работать штатно, и не нужно никуда в глубь лезть исправлять
            var puppet = new CombatantPuppet(new StandartArmor("default", 1 , 0, Enum.Specification.ItemType.ArmorChest), new StandartArmor("default", 1, 0, Enum.Specification.ItemType.ArmorHead), new StandartWeapon("default", 1, 0, 0), new StandartJewelry("default", 1, 1, 1, 1, 1));
            _player = Player.GetPlayer("Hero", new CombatantInventory(puppet), puppet, new CombatantStats(puppet));

            _npcList = new List<INpc>();
            _combatantList = new List<ICombatant>();
            _combatantList.Add(_player);
        }

        //Поскольку, все сетеры "protected", кроме цены предмета, и нельзя изменить состояние Игрока, кроме как определенных методов, то
        //Следовательно инкапсуляция не нарушается
        public static Player Player { get => _player; }

        public static List<string> CombatantNamesList { get => (from combatant in _combatantList select combatant.Name).ToList(); }
        public static List<ICombatantStats> CombatantStatList { get => (from combatant in _combatantList select combatant.Stats).ToList(); }

        public static void CreateShopKeeper(string shopName, DieDelegate eventHandlerDie)
        {
            //Создает нового торговца, если не существует торговца с таким же именем
            if (!_npcList.Contains(_npcList.Find(npc => npc.Name == shopName))) {
                _npcList.Add(new ShopKeeper(shopName));
                ((ShopKeeper)_npcList[^1]).SetDefaultShopInventory();
                _npcList[^1].Died += eventHandlerDie;
            }
        }

        public static INpc GetNpc(string npcName)
        {
            return _npcList.Find(npc => npc.Name == npcName);
        }

        public static void CreateEnemy(string enemyName, DieDelegate eventHandlerDie)
        {
            //Создает нового врага, если не существует врага с таким же именем
            if (!_combatantList.Contains(_combatantList.Find(enemy => enemy.Name == enemyName)))
            {
                var enemyPuppet = new CombatantPuppet(new StandartArmor("default", 1, 0, Enum.Specification.ItemType.ArmorChest), new StandartArmor("default", 1, 0, Enum.Specification.ItemType.ArmorHead), new StandartWeapon("default", 1, 0, 0), new StandartJewelry("default", 1, 1, 1, 1, 1));
                _combatantList.Add(new Enemy(enemyName, new CombatantInventory(enemyPuppet), enemyPuppet, new CombatantStats(enemyPuppet)));
                _combatantList[^1].Died += eventHandlerDie;
            }
        }

        public static ICombatant GetEnemy(string enemyName)
        {
            return _combatantList.Find(enemy => enemy.Name == enemyName);
        }

        public static void Attack(string attackerName, string defenderName)
        {
            //быстрые ссылки, чтобы выполняеть только два поиска  
            var attacker = _combatantList.Find(combatant => combatant.Name == attackerName);
            var defender = _combatantList.Find(combatant => combatant.Name == defenderName);
            //? На случай если не найдет бойца
            attacker?.Attack(defender);
            if (defender?.Stats.CurrentHp > 0)
            {
                //контратака
                defender.Attack(attacker);
                if (attacker.Stats.CurrentHp == 0)
                {
                    _combatantList.Remove(attacker);
                    attacker.Die();
                }
            }
            else
            {
                _combatantList.Remove(defender);
                defender.Die();
            }
        }

        public static void CastSkill(string attackerName, string defenderName)//Способность от Джевела
        {
            var attacker = _combatantList.Find(combatant => combatant.Name == attackerName);
            var defender = _combatantList.Find(combatant => combatant.Name == defenderName);
            attacker?.CastJewelSkill(defender);
            if (defender?.Stats.CurrentHp == 0)
            {
                _combatantList.Remove(defender);
                defender.Die();
            }
        }
    }
}
