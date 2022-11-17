using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Axe;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Melee
{
    public class Warrior
    {
        public int abilityPoints;
        public string? faction;
        public int healthPoints;
        public int level;
        public string name;
        public Chainlink bodyArmor;
        public HackNSlash weapon;

        public void Strike() { }
        public void Execute() { }
        public void SkinHarden() { }
    }
}
