using Medieval_Knight_WinForms.Model.Character;
namespace Medieval_Knight_WinForms.Model.Item
{
    interface IJewelry : IItem
    {
        double MaxHpMult { get; }//множетели х-ик
        double AttackMult { get; }
        double DefenceMult { get; }
        double DamageMult { get; }
        string JewelSkillName { get; }
        void JewelSkillCast(ICombatant target);//особая способность бижутерии
    }
}
