using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class Factory
    {
        public static ICombatantFactory GetFactory(Enum.Specification.CombatantType combatantType)
        {
            return combatantType switch
            {
                Enum.Specification.CombatantType.Player => new PlayerFactory(),
                Enum.Specification.CombatantType.Enemy => new EnemyFactory(),
                _ => new NullFactory(),
            };
        } 
    }
}
