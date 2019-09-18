using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class Mage : Player {

        public Mage() {
            Console.WriteLine("Mage created!");        
        }

        public static String aboutMage() {
            return "Mage: Great at using magic to defeat enemies.";
        }
    }
}
