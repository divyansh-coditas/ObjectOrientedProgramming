using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MagicDestroyers.Equipment.Weapons.Staff;
using MagicDestroyers.Equipment.Armors;

namespace MagicDestroyers.Characters.Spellcasters
{
    public class Mage
    {
        public int abilityPoints;
        public string? faction;
        public int healthPoints;
        public int level;
        public string name;
        public ClothRobe bodyArmor;
        public Empower weapon;
        public void ArcaneWrath() { }
        public void FireWall() { }
        public void Meditation() { }
    }
}
