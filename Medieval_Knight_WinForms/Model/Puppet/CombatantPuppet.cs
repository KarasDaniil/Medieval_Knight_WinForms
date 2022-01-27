using Medieval_Knight_WinForms.Model.Item;
namespace Medieval_Knight_WinForms.Model.Puppet
{
    class CombatantPuppet : ICombatantPuppet //"кукла персонажа" - удобный агрегатор екипированых предметов
    {
        //Затея со значением по умолчанию, нужна чтобы в клиентском коде не проверять на null поля этого класса,
        //а шаблон "Null object" мне не подходил.
        private IArmor _defaultChest;
        private IArmor _defaultHead;
        private IWeapon _defaultWeapon;
        private IJewelry _defaultJewelry;

        private IArmor _currentChest;
        private IArmor _currentHead;
        private IWeapon _currentWeapon;
        private IJewelry _currentJewelry;

        public virtual IArmor Chest
        {
            get => _currentChest; 
            set
            {
                if(value != null && value.ItemType == Enum.Specification.ItemType.ArmorChest)//
                {
                    _currentChest = value;
                }
                else
                {
                    _currentChest = _defaultChest;
                }
            }
        }
        public virtual IArmor Head
        {
            get => _currentHead;
            set
            {
                if (value != null && value.ItemType == Enum.Specification.ItemType.ArmorHead)
                {
                    _currentHead = value;
                }
                else
                {
                    _currentHead = _defaultHead;
                }
            }
        }
        public virtual IWeapon Weapon
        {
            get => _currentWeapon;
            set
            {
                if (value != null && value.ItemType == Enum.Specification.ItemType.Weapon)
                {
                    _currentWeapon = value;
                }
                else
                {
                    _currentWeapon = _defaultWeapon;
                }
            }
        }
        public virtual IJewelry Jewelry
        {
            get => _currentJewelry;
            set
            {
                if (value != null && value.ItemType == Enum.Specification.ItemType.Jewelry)
                {
                    _currentJewelry = value;
                }
                else
                {
                    _currentJewelry = _defaultJewelry;
                }
            }
        }

        public CombatantPuppet(IArmor defaultChest, IArmor defaultHead, IWeapon defaultWeapon, IJewelry defaultJewelry)
        {
            _defaultChest = defaultChest;
            _defaultHead = defaultHead;
            _defaultWeapon = defaultWeapon;
            _defaultJewelry = defaultJewelry;
            _currentChest = _defaultChest;
            _currentHead = _defaultHead;
            _currentWeapon = _defaultWeapon;
            _currentJewelry = _defaultJewelry;
        }
    }
}
