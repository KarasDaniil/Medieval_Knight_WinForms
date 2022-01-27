using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Item
{
    class CursedWeapon : AbstractWeapon //Другой тип оружия, создан для демонстрации полиморфизма
    {
        public CursedWeapon(string name, decimal cost, int atack, int damage) : base(name, cost, atack, damage)
        {
        }

        public override void Equip(ICombatantPuppet puppet)
        {
            puppet.Weapon = this;
            IsЕquipped = true;
            System.Windows.Forms.MessageBox.Show($"Equiped item have a curse!");
        }
        public override void Unequip(ICombatantPuppet puppet)
        {
            System.Windows.Forms.MessageBox.Show($"Unable to unequip cursed item!");
        }
        public virtual void CurseRemove(ICombatantPuppet puppet)
        {
            System.Windows.Forms.MessageBox.Show($"Curse supressed!");
            puppet.Weapon = null;
            IsЕquipped = false;
        }
    }
}
