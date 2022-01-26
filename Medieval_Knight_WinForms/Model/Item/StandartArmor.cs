using Medieval_Knight_WinForms.Model.Enum;
namespace Medieval_Knight_WinForms.Model.Item
{
    class StandartArmor : AbstractArmor
    {
        public StandartArmor(string name, decimal cost, int armor, Specification.ItemType itemType) : base(name, cost, itemType, armor)
        {

        }
        //private bool _defendState = false;

        //public override void BeginDefendAction(ICombatantStats stats)
        //{
        //    if (!_defendState)
        //    {
        //        if (stats.AttachedPuppet.Chest != null)
        //        {

        //        }
        //        if (stats.AttachedPuppet.Head != null)
        //        {

        //        }
        //    }
        //}

        //public override void EndDefendAction(ICombatantStats stats)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
