using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Character
{
    abstract class AbstractCombatant : Character, ICombatant
    {
        public virtual ICombatantPuppet Puppet { get; protected set; }

        public virtual ICombatantStats Stats { get; protected set; }

        //public event Action EquipmentChange;
        public StatsChange EquipmentChange { get; set; }
        public StatsChange JewelSkillCasted { get; set; }
        public AttackComplete AttackComplete { get; set; }

        protected AbstractCombatant(string name, ICombatantInventory inventory, ICombatantPuppet puppet, ICombatantStats stats) : base(name, inventory)
        {          
            Puppet = puppet;
            Stats = stats;
        }

        public virtual void EquipItem(int itemIndex)
        {
            //это безопасное приведение, так как, благодаря конструктору, сюда не может придти старший инвентарь, который без методов екипировки
            ((ICombatantInventory)Inventory).EquipItem(itemIndex);
            Stats.UpdateItemsStats();
            EquipmentChange?.Invoke();
        }

        public virtual void UnequipItem(int itemIndex)
        {
            ((ICombatantInventory)Inventory).UnequipItem(itemIndex);
            Stats.UpdateItemsStats();
            EquipmentChange?.Invoke();
        }

        //У разных бойцов может быть совершенно разная формула урона, поетому здесь абстракция
        public abstract void Attack(ICombatant attackTarget);

        public abstract void CastJewelSkill(ICombatant skillTarget);
    }
}
