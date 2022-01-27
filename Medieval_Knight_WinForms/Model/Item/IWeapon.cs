namespace Medieval_Knight_WinForms.Model.Item
{
    interface IWeapon : IItem
    {
        int WeaponAtack { get; }
        int WeaponDamage { get; }
    }
}
