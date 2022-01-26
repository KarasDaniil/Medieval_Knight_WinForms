using Medieval_Knight_WinForms.Model.Puppet;
using System;
namespace Medieval_Knight_WinForms.Model.Stats
{
    class CombatantStats : ICombatantStats
    {
        private int _maxHpBase, _maxHpLevelBonus;
        private int _currentHp;
        private int _attackBase, _attackItemBonus, _attackLevelBonus;
        private int _defenceBase, _defenceItemBonus, _defenceLevelBonus;
        private int _damageMinBase, _damageItemBonus, _damageLevelBonus;
        private int _damageMaxBase;

        private double _maxHpJewelryMult;
        private double _attackJewelryMult;
        private double _defenceJewelryMult;
        private double _damageJewelryMult;

        public virtual int MaxHP
        {
            get
            {
                return Convert.ToInt32((_maxHpBase + _maxHpLevelBonus) * _maxHpJewelryMult);
            }
        }
        public virtual int CurrentHp
        {
            get
            {
                return _currentHp;
            }
            set
            {
                _currentHp = value;
                if (_currentHp < 0)
                    _currentHp = 0;
                else if (_currentHp > MaxHP)
                    _currentHp = MaxHP;
            }
        }
        public virtual int Attack
        {
            get
            {
                return Convert.ToInt32((_attackBase + _attackItemBonus + _attackLevelBonus) * _attackJewelryMult);
            }
        }
        public virtual int Defence
        {
            get
            {
                return Convert.ToInt32((_defenceBase + _defenceItemBonus + _defenceLevelBonus) * _defenceJewelryMult);
            }
        }
        public virtual int DamageMin
        {
            get
            {
                return Convert.ToInt32((_damageMinBase + _damageItemBonus + _damageLevelBonus) * _damageJewelryMult);
            }
        }
        public virtual int DamageMax
        {
            get
            {
                return Convert.ToInt32((_damageMaxBase + _damageItemBonus + _damageLevelBonus) * _damageJewelryMult);
            }
        }

        public virtual ICombatantPuppet AttachedPuppet { get; }

        public CombatantStats(ICombatantPuppet attachedPuppet)
        {
            AttachedPuppet = attachedPuppet;
            _maxHpBase = 100;
            _currentHp = _maxHpBase;
            _attackBase = 4;
            _defenceBase = 3;
            _damageMinBase = 4;
            _damageMaxBase = 6;
            _maxHpLevelBonus = 0;
            _attackLevelBonus = 0;
            _defenceLevelBonus = 0;
            _damageLevelBonus = 0;
            _maxHpJewelryMult = 1;
            _attackJewelryMult = 1;
            _defenceJewelryMult = 1;
            _damageJewelryMult = 1;
            _attackItemBonus = 0;
            _defenceItemBonus = 0;
            _damageItemBonus = 0;
        }

        public CombatantStats(ICombatantPuppet attachedPuppet, int maxHpBase, int attackBase, int defenceBase, int damageMinBase, int damageMaxBase)
        {
            AttachedPuppet = attachedPuppet;
            _maxHpBase = maxHpBase;
            _currentHp = _maxHpBase;
            _attackBase = attackBase;
            _defenceBase = defenceBase;
            _damageMinBase = damageMinBase;
            _damageMaxBase = damageMaxBase;
            _maxHpLevelBonus = 0;
            _attackLevelBonus = 0;
            _defenceLevelBonus = 0;
            _damageLevelBonus = 0;
            _maxHpJewelryMult = 1;
            _attackJewelryMult = 1;
            _defenceJewelryMult = 1;
            _damageJewelryMult = 1;
            _attackItemBonus = 0;
            _defenceItemBonus = 0;
            _damageItemBonus = 0;
        }

        public virtual void LevelUpStats(int maxHpLevelBonus, int attackLevelBonus, int defenceLevelBonus, int damageLevelBonus)
        {
            _maxHpLevelBonus += maxHpLevelBonus;
            _attackLevelBonus += attackLevelBonus;
            _defenceLevelBonus += defenceLevelBonus;
            _damageLevelBonus += damageLevelBonus;
        }

        public virtual void ResetLevelsStats()
        {
            _maxHpLevelBonus = 0;
            _attackLevelBonus = 0;
            _defenceLevelBonus = 0;
            _damageLevelBonus = 0;
        }

        public virtual void UpdateItemsStats()
        {
            _attackItemBonus = AttachedPuppet.Weapon == null ? 0 : AttachedPuppet.Weapon.WeaponAtack;
            _damageItemBonus = AttachedPuppet.Weapon == null ? 0 : AttachedPuppet.Weapon.WeaponDamage;

            _defenceItemBonus = (AttachedPuppet.Chest == null ? 0 : AttachedPuppet.Chest.ArmorScore) + (AttachedPuppet.Head == null ? 0 : AttachedPuppet.Head.ArmorScore);

            _maxHpJewelryMult = AttachedPuppet.Jewelry == null ? 1 : AttachedPuppet.Jewelry.MaxHpMult;
            _attackJewelryMult = AttachedPuppet.Jewelry == null ? 1 : AttachedPuppet.Jewelry.MaxHpMult;
            _defenceJewelryMult = AttachedPuppet.Jewelry == null ? 1 : AttachedPuppet.Jewelry.MaxHpMult;
            _damageJewelryMult = AttachedPuppet.Jewelry == null ? 1 : AttachedPuppet.Jewelry.MaxHpMult;

            if (MaxHP < CurrentHp)
                CurrentHp = MaxHP;
            //_damageItemBonus = AttachedPuppet.Weapon.WeaponDamage ?? 0; //== null ? 0 : AttachedPuppet.Weapon.WeaponDamage;
        }
    }
}
