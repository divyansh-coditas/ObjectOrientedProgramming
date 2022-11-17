using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Sword;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Melee
{
    public class Assasin
    {
        public int abilityPoints;
        public string? faction;
        public int healthPoints;
        public int level;
        public string name;
        public LightLeatherVest bodyArmor;
        public BloodThirst weapon;
        public void Raze() { }
        public void BleedToDeath() { }
        public void Survival() { }
    }
}
