using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
namespace Medieval_Knight_WinForms.Model.Character
{
    delegate void AttackComplete();
    delegate void StatsChange();
    interface ICombatant : ICharacter
    {
        ICombatantStats Stats { get; } //контейнер х-ик
        ICombatantPuppet Puppet { get; }//контейнер ссылок на екипированые предметы в инвентаре
        void Attack(ICombatant attackTarget);
        void CastJewelSkill(ICombatant skillTarget);
        StatsChange EquipmentChange { get; set; }
        StatsChange JewelSkillCasted { get; set; }
        AttackComplete AttackComplete { get; set; }
    }
}