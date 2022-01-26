using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Knight_WinForms.Model.Item
{
    interface IWeapon : IItem
    {
        int WeaponAtack { get; }
        int WeaponDamage { get; }
    }
}
