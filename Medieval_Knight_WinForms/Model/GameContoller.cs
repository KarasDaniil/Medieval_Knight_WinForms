using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Factories;
using Medieval_Knight_WinForms.Model.Stats;
using System.Collections.Generic;
using System.Linq;
namespace Medieval_Knight_WinForms.Model
{
    class GameContoller//Класс служит прослойкой между UI и системой(игрой)
    {                  //Благодаря етому UI имеет доступ только к минимально необходимому функционалу 
        private static Player _player;
        private static List<INpc> _npcList;
        private static List<ICombatant> _combatantList;

        private static ICombatantFactory _factory;

        static GameContoller()
        {
            _npcList = new List<INpc>();
            _combatantList = new List<ICombatant>();
            //выбрал фабрику, так как я только там буду изменять старые типы на разработаные новые,
            //и все будет работать штатно, и не нужно никуда в глубь лезть исправлять
            _factory = Factory.GetFactory(Enum.Specification.CombatantType.Player);
            _player = (Player)_factory.GetCombatant("Hero", 1);
            _combatantList.Add(_player);

        }

        public static Player Player { get => _player; }

        //свойсва с удобным доступом, мгновенной выборкой нужного из колекции бойцов
        public static List<string> CombatantNamesList { get => (from combatant in _combatantList select combatant.Name).ToList(); }
        public static List<ICombatantStats> CombatantStatList { get => (from combatant in _combatantList select combatant.Stats).ToList(); }

        public static void CreateShopKeeper(string shopName, DieDelegate eventHandlerDie)
        {
            //Создает нового торговца, если не существует торговца с таким же именем
            if (!_npcList.Contains(_npcList.Find(npc => npc.Name == shopName)))
            {
                _npcList.Add(new ShopKeeper(shopName));
                _npcList[^1].Died += eventHandlerDie;
            }
        }

        public static void CreateEnemy(string enemyName, double powerMultipler, DieDelegate eventHandlerDie)
        {
            //Создает нового врага, если не существует врага с таким же именем
            if (!_combatantList.Contains(_combatantList.Find(enemy => enemy.Name == enemyName)))
            {
                _factory = Factory.GetFactory(Enum.Specification.CombatantType.Enemy);
                _combatantList.Add(_factory.GetCombatant(enemyName, powerMultipler));
                _combatantList[^1].Died += eventHandlerDie;
            }
        }

        //методы получения из колекций нпс и врага по имени 
        public static INpc GetNpc(string npcName)
        {
            return _npcList.Find(npc => npc.Name == npcName);
        }

        public static ICombatant GetEnemy(string enemyName)
        {
            return _combatantList.Find(enemy => enemy.Name == enemyName);
        }

        public static void Attack(string attackerName, string defenderName)//метод описание атаки
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

        public static void CastSkill(string attackerName, string defenderName)//Способность от бижутерии
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
