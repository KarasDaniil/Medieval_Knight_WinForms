using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Character
{
    public delegate void TradeDelegate();
    interface INpc : ICharacter
    {
        void SellOwnItem(ICharacter customer, params IItem[] selledItem);
        void BuyOtherItems(ICharacter customer, params IItem[] boughtItem);
        TradeDelegate TradeComplete { get; set; }//{ add => TradeComplete += value; remove => TradeComplete -= value; }
    }
}
