using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using System;

namespace Medieval_Knight_WinForms.Model.Character
{
    class Enemy : AbstractCombatant, ICombatant //описание бойца - врага
    {
        public Enemy(string name, ICombatantInventory inventory, ICombatantPuppet puppet, ICombatantStats stats) : base(name, inventory, puppet, stats)
        {
        }

        public override void Attack(ICombatant attackTarget)
        {
            var rand = new Random();
            var totalDamage = rand.Next(Stats.DamageMin, Stats.DamageMax) + Convert.ToInt32((1 + (Stats.Attack - attackTarget.Stats.Defence) * 0.01) * rand.Next(Stats.DamageMin, Stats.DamageMax));
            attackTarget.Stats.CurrentHp -= totalDamage < 0 ? 1 : totalDamage;
            AttackComplete?.Invoke();//активация делегата чтобы обновий UI
        }

        public override void CastJewelSkill(ICombatant skillTarget)
        {
            Puppet.Jewelry.JewelSkillCast(skillTarget);
            JewelSkillCasted?.Invoke();//активация делегата чтобы обновий UI
        }
    }
}
