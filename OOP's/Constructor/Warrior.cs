using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    public class Warrior
    {
        public int height { get; set; }

        public int weight { get; set; }

        public Warrior(int height, int weight) 
        {
            this.height = height;
            this.weight = weight;
        }
    }
}
