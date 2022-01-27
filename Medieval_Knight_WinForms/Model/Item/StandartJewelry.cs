using Medieval_Knight_WinForms.Model.Character;
using System;
namespace Medieval_Knight_WinForms.Model.Item
{
    class StandartJewelry : AbstractJewelry
    {
        public StandartJewelry(string name, decimal cost, double maxHpMult, double attackMult, double defenceMult, double damageMult)
            : base(name, cost, maxHpMult, attackMult, defenceMult, damageMult)
        {
            JewelSkillName = "Heal";
        }

        public override void JewelSkillCast(ICombatant target)
        {
            target.Stats.CurrentHp += Convert.ToInt32(target.Stats.MaxHP * 0.25);
        }
    }
}
