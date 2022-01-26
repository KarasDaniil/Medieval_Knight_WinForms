using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Character
{
    abstract class AbstractNpc : Character, INpc
    {
        protected AbstractNpc(string name) : base(name)
        {
        }

        protected AbstractNpc(string name, IInventory inventory) : base(name, inventory)
        {
        }

        public TradeDelegate TradeComplete { get; set; }

        //эти методы абстрактны, потому что нпс это может быть не только торговец, но и, например, кузнец или зачарователь,
        //взаемодействие с которыми также описывается сигнатурой этих методов
        public abstract void BuyOtherItems(ICharacter customer, params IItem[] boughtItem);

        public abstract void SellOwnItem(ICharacter customer, params IItem[] selledItem);
    }
}
