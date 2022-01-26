using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Stats
{
    interface ICombatantStats
    {
        int MaxHP { get; }
        int CurrentHp { get; set; }
        int Attack { get; }
        int Defence { get; }
        int DamageMin { get; }
        int DamageMax { get; }
        ICombatantPuppet AttachedPuppet { get; }
        //void LevelUpStats(int maxHpLevelBonus, int attackLevelBonus, int defenceLevelBonus, int damageLevelBonus);
        void UpdateItemsStats();
    }
}
