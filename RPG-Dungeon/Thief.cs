using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class Thief : Player {

        public Thief() {
            Console.WriteLine("Thief created!");        
        }

        public static String aboutThief()
        {
            return "Thief: A very agile and intelligent thief than can steal enemies' possessions and has some magical powers.";
        }
    }
}
