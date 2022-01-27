using Medieval_Knight_WinForms.Model.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medieval_Knight_WinForms.Model.Factories
{
    class NullFactory : ICombatantFactory
    {
        public ICombatant GetCombatant(string name, double powerMultipler)
        {
            throw new NotImplementedException();
        }
    }
}
