using Medieval_Knight_WinForms.Model.Inventory;
namespace Medieval_Knight_WinForms.Model.Character
{
    abstract class Character : ICharacter //нужен чтобы я лишний раз не описывал свойста и метод смерти
    {
        public virtual string Name { get; protected set; }

        public virtual IInventory Inventory { get; protected set; }

        public virtual DieDelegate Died { get; set; } 

        protected Character(string name)
        {
            Name = name;
            Inventory = new StandartInventory();
        }
        protected Character(string name, IInventory inventory)
        {
            Name = name;
            Inventory = inventory;
        }
        virtual public void Die()
        {
            System.Windows.Forms.MessageBox.Show($"{Name} died!");
            Died?.Invoke();
        }
    }
}
