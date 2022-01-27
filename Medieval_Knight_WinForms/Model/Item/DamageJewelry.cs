using Medieval_Knight_WinForms.Model.Character;

namespace Medieval_Knight_WinForms.Model.Item
{
    class DamageJewelry : AbstractJewelry //Другой тип бижутерии, создан для демострации полиморфизма
    {
        public DamageJewelry(string name, decimal cost, double maxHpMult, double attackMult, double defenceMult, double damageMult)
            : base(name, cost, maxHpMult, attackMult, defenceMult, damageMult)
        {
            JewelSkillName = "Simple damage";
        }

        public override void JewelSkillCast(ICombatant skillTarget)
        {
            skillTarget.Stats.CurrentHp -= 15;
        }
    }
}
