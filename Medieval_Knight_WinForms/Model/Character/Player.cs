using Medieval_Knight_WinForms.Model.Inventory;
using Medieval_Knight_WinForms.Model.Puppet;
using Medieval_Knight_WinForms.Model.Stats;
using Medieval_Knight_WinForms.Model.Item;
using System;
namespace Medieval_Knight_WinForms.Model.Character
{
    class Player : AbstractCombatant
    {
        public static Player Hero { get; private set; }

        private Player(string playerName) : base(playerName)
        {
        }

        public static Player GetPlayer(string playerName)
        {
            if (Hero == null)
            {
                Hero = new Player(playerName);
                Hero.Inventory = new CombatantInventory(Hero.Puppet);
                Hero.Inventory.AddItem(new StandartWeapon("Sword", 10, 10, 15), new StandartWeapon("Great Sword", 25, 25, 25), new StandartWeapon("Short Sword", 15, 15, 40));
                Hero.Inventory.AddGold(5000);
            }
            return Hero;
        }

        private Player(string playerName, ICombatantInventory inventory, ICombatantPuppet puppet, ICombatantStats stats) : base(playerName, inventory, puppet, stats)
        {
        }

        public static Player GetPlayer(string playerName, ICombatantInventory inventory, ICombatantPuppet puppet, ICombatantStats stats)
        {
            if (Hero == null)
            {
                Hero = new Player(playerName, inventory, puppet, stats);
                Hero.Inventory.AddItem(new StandartWeapon("Sword", 10, 10, 15), new StandartWeapon("Great Sword", 25, 25, 25), new StandartWeapon("Short Sword", 15, 15, 40));
                Hero.Inventory.AddGold(5000);
            }
            return Hero;
        }

        public override void Attack(ICombatant attackTarget)
        {
            var rand = new Random();
            var totalDamage = rand.Next(Stats.DamageMin, Stats.DamageMax) + Convert.ToInt32(( 1 + (Stats.Attack - attackTarget.Stats.Defence ) * 0.01) * rand.Next(Stats.DamageMin, Stats.DamageMax));
            attackTarget.Stats.CurrentHp -= totalDamage < 0 ? 1 : totalDamage;
            //if (attackTarget.Stats.CurrentHp == 0)
            //    attackTarget.Die();
            AttackComplete?.Invoke();
        }

        public override void CastJewelSkill(ICombatant skillTarget)
        {
            if(Puppet.Jewelry != null)
            {
                Puppet.Jewelry.JewelSkillCast(skillTarget);
                JewelSkillCasted?.Invoke();
            }
        }
    }
}
