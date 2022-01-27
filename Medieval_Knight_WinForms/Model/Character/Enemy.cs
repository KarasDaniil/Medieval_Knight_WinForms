using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using System;

namespace Medieval_Knight_WinForms.Model.Character
{
    class Enemy : AbstractCombatant
    {
        public Enemy(string name, ICombatantInventory inventory, ICombatantPuppet puppet, ICombatantStats stats) : base(name, inventory, puppet, stats)
        {
            //*переделать в фабрику!!!
            puppet.Weapon = new StandartWeapon("EnemyWeapon", 100, 20, 35);
            puppet.Chest = new StandartArmor("EnemyChest", 100, 45, Specification.ItemType.ArmorChest);
            puppet.Head = new StandartArmor("EnemyHead", 100, 30, Specification.ItemType.ArmorHead);
            puppet.Jewelry = new StandartJewelry("EnemyJewel", 780, 1.2, 1.2, 1.2, 1.2);
            inventory.AddItem(puppet.Weapon, puppet.Chest, puppet.Head, puppet.Jewelry);
            stats.UpdateItemsStats();
            stats.CurrentHp = stats.MaxHP;
        }

        public override void Attack(ICombatant attackTarget)
        {
            var rand = new Random();
            var totalDamage = rand.Next(Stats.DamageMin, Stats.DamageMax) + Convert.ToInt32((1 + (Stats.Attack - attackTarget.Stats.Defence) * 0.01) * rand.Next(Stats.DamageMin, Stats.DamageMax));
            attackTarget.Stats.CurrentHp -= totalDamage < 0 ? 1 : totalDamage;
            //if (attackTarget.Stats.CurrentHp == 0)
            //    attackTarget.Die();
            AttackComplete?.Invoke();
        }

        public override void CastJewelSkill(ICombatant skillTarget)
        {
            Puppet.Jewelry.JewelSkillCast(skillTarget);
            JewelSkillCasted?.Invoke();
        }
    }
}
