using Medieval_Knight_WinForms.Model.Inventory;
namespace Medieval_Knight_WinForms.Model.Character
{
    public delegate void DieDelegate();
    interface ICharacter
    {
        string Name { get; }
        IInventory Inventory { get; }
        void Die();
        DieDelegate Died { get; set; }
    }
}
