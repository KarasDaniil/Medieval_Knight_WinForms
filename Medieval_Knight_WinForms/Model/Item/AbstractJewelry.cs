using Medieval_Knight_WinForms.Model.Character;
using Medieval_Knight_WinForms.Model.Enum;
using Medieval_Knight_WinForms.Model.Puppet;
namespace Medieval_Knight_WinForms.Model.Item
{
    abstract class AbstractJewelry : AbstractItem, IJewelry
    {
        public virtual double MaxHpMult { get; protected set; }
        public virtual double AttackMult { get; protected set; }
        public virtual double DefenceMult { get; protected set; }
        public virtual double DamageMult { get; protected set; }
        public virtual string JewelSkillName { get; protected set; }
        public AbstractJewelry(string name, decimal cost, double maxHpMult, double attackMult, double defenceMult, double damageMult) : base(name, cost, Specification.ItemType.Jewelry)
        {
            MaxHpMult = maxHpMult;
            AttackMult = attackMult;
            DefenceMult = defenceMult;
            DamageMult = damageMult;
            JewelSkillName = "None";
        }

        //Для каждой бижутерии способность должна быть своя. 
        public abstract void JewelSkillCast(ICombatant target);

        public override void Equip(ICombatantPuppet puppet)
        {
            puppet.Jewelry = this;
            IsЕquipped = true;
        }
        public override void Unequip(ICombatantPuppet puppet)
        {
            //null - безопасно, см. set в CombatantPuppet
            puppet.Jewelry = null;
            IsЕquipped = false;
        }
    }
}
