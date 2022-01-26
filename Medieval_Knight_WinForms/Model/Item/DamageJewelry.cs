using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Stats;

namespace Medieval_Knight_WinForms.Model.Item
{
    class DamageJewelry : AbstractJewelry
    {
        public DamageJewelry(string name, decimal cost, double maxHpMult, double attackMult, double defenceMult, double damageMult)
            : base(name, cost, maxHpMult, attackMult, defenceMult, damageMult)
        {
            JewelSkillName = "Simple damage";
        }

        public override void JewelSkillCast(ICombatant skillTarget)
        {
            skillTarget.Stats.CurrentHp -= 15;
            //if (skillTarget.Stats.CurrentHp == 0)
            //    skillTarget.Die();
            //jewelSkillCast?.Invoke(this, null);
        }
    }
}
