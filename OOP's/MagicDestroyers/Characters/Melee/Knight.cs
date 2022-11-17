using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Hammer;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Melee
{
    public class Knight
    {
        public int abilityPoints;
        public string? faction;
        public int healthPoints;
        public int level;
        public string name;
        public Chainlink bodyArmor;
        public Stun weapon;
        public void holyBlow() { }
        public void PurifySoul() { }
        public void RighteousWings() { }
    }
}
