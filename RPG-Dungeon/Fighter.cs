using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class Fighter : Player {
        public Fighter() {
            this.weapon = "Sword";
            this.strength = 8;
            this.agility = 7;
            this.intelligence = 6;
            this.mP = 15;
            this.maxMp = 15;
            this.weaponStrength = 12;
            this.weaponDefense = 4;
            this.attack = this.strength+this.weaponStrength;
            this.defense = this.strength/2 + this.agility+this.weaponDefense;
    }

        public static String aboutFighter()
        {
            return "Fighter: This is the stronger type of class in terms of strength, but knows no magic and lacks intelligence and agility.";
        }
    }
}
