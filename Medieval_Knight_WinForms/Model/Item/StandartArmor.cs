using Medieval_Knight_WinForms.Model.Enum;
namespace Medieval_Knight_WinForms.Model.Item
{
    class StandartArmor : AbstractArmor 
    {
        public StandartArmor(string name, decimal cost, int armor, Specification.ItemType itemType) : base(name, cost, itemType, armor)
        {
        }
    }
}
