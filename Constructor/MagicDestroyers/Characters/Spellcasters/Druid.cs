﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Staff;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Druid
    {
        public int abilityPoints;
        public string? faction;
        public int healthPoints;
        public int level;
        public string name;
        public LightLeatherVest bodyArmor;
        public Empower weapon;
        public void Moonfire() { }
        public void Starburst() { }
        public void OneWithTheNature() { }
    }
}
