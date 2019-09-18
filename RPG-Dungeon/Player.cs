using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    abstract class Player {

        //Properties
        private int hP = 40;
        private int maxHp = 40;
        private int level = 1;
        private int xP = 0;
        public int currentRoom {get;set;}
        private int raiseOnlyOnce = 0;
        private int levelUpStops = 1;
        private int numberOfPotions = 0;
        public int mP { get; set; }
        public int maxMp { get; set; }
        private String name;
        private String type;
        public String weapon { get; set; }
        public int strength { get; set; }
        public int agility { get; set; }
        public int intelligence { get; set; }
        public int weaponStrength { get; set; }
        public int weaponDefense { get; set; }
        public int attack { get; set; }
        public int defense { get; set; }
        //End properties

        public Player() { }

        public String getName() {return name;}

        public void setName(String name) {this.name = name;}

        public void showName() {
            Console.WriteLine("My name is " + name);
        }

        public String getStatus() {
            return "Name: " + this.name + "\n"
                  + "Class: " + this.GetType().Name + "\n"
                  + "Level: " + this.level + "\n"
                  + "HP: " + this.hP + "/" + this.maxHp + "\n"
                  + "MP: " + this.mP + "/" + this.maxMp + "\n"
                  + "XP: " + this.xP + "\n"
                  + "Weapon: " + this.weapon + "\n"
                  + "Attack: " + this.attack + "\tDefense: " + this.defense + "\n"
                  + "STR: " + this.strength + "\tAGI: " + this.agility + "\tINT: " + this.intelligence;
            }


    } //end Player class
}
