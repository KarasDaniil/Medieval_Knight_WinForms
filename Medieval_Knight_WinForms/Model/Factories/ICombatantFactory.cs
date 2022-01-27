using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Medieval_Knight_WinForms.Model.Character;

namespace Medieval_Knight_WinForms.Model.Factories
{
    interface ICombatantFactory
    {
        ICombatant GetCombatant(string name, double powerMultipler);
    }
}
