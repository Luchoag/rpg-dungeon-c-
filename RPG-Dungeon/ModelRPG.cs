using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class ModelRPG  {
        
        public ModelRPG() { }

        public String firstStory(Player player) {
            return "Welcome, " + player.getName() +". You have chosen the path of the " + player.GetType().Name
                +". Unfortunately, your future doesn't look very bright. You have engaged in a battle with a wizard much stronger than you, and though, you have been defeated. Luckily for you, the wizard is a reasonable man, and instead of killing you, he sends you with a magic spell to the entrance of a dungeon.\n" 
                + "...\n"
                + "From across the door, the wizard mumbles: 'In order to live, you'll have to defeat the numerous monsters that inhabit this dark place. Search the key. If you can obtain it, you are free to leave.'";
            }

        public String lookRoom(Player player) {
            switch (player.currentRoom) {
                case 1:
                    return "You are in a dark and filthy room, barely iluminated by a candle. Besides you is the exit to this dungeon, a locked door. To the north is the only visible path."; //Starting room
                    break;
                case 2:
                    return "This is the second room of the dungeon. Some more candles light this place and you can clearly see you have opening paths in all four directions. You can also see some human bones lying in the ground and realize that was the stench you've been smelling since you got here (you feel relieved that it wasn't your personal body odor).";
                    break;
                case 3:
                    return "A narrow hallway extends from west to east, and it gets darker and creepier every minute. You start to think that maybe fighting that wizard wasn't a great idea in the first place."; //Hallway
                    break;
                case 4:
                    return "This is the end of the hallway, but not the end of the road. You can hear someone screaming in the distance. Only two ways seem open: south, to continue forward, or west, to return to the hallway"; //End of Hallway
                    break;
                case 5:
                    return "Braverly, or stupidly, you decide to go on. The screaming here is louder and a chill runs down your spine when you look to the east from where the shouts seem to come. North is the way out.";
                    break;
                case 6:
                    return "You see a large cell filled with prisoners in terrible pain. Some of them fear you when you approach, some spit you and some ask you for help. Some of them are torturing the others. Only one person ignores you completely: a mysterious looking old man with his eyes closed."; //Cells room
                    break;
                case 7:
                    return "7";
                    break;
                case 8:
                    return "8";
                    break;
                case 9:
                    return "9";
                    break;
                case 10:
                    return "10";
                    break;
                case 11:
                    return "11";
                    break;
                case 12:
                    return "12";
                    break;
                case 13:
                    return "13";
                    break;
                default:
                    return "Error de room";
                }
        }
        //Probando algo otra vez
        public void directions(Controller controller, Player player, String op, out bool choice) {
            choice = false;
            switch (player.currentRoom) {
                case 1:
                    switch (op) {
                        case "1":
                            changeRoom(controller, player, 2);
                            choice = true;
                            break;
                        case "5":
                            choice = true;
                            controller.view.roomMenu(controller);
                            break;
                        default:
                            Console.WriteLine("You can't go that way");
                            choice = false;
                            break;
                        }
                    break;
                case 2:
                    switch (op) {
                        case "1":
                            changeRoom(controller, player, 10);
                            choice = true;
                            break;
                        case "2":
                            changeRoom(controller, player, 3);
                            choice = true;
                            break;
                        case "3":
                            changeRoom(controller, player, 1);
                            choice = true;
                            break;
                        case "4":
                            changeRoom(controller, player, 7);
                            choice = true;
                            break;
                        case "5":
                            choice = true;
                            controller.view.roomMenu(controller);
                            break;
                        default:
                            Console.WriteLine("You can't go that way");
                            choice = false;
                            break;
                    }
                    break;

            }
        }

        public void changeRoom(Controller controller, Player player, int newRoom) {
            player.currentRoom = newRoom;
            controller.view.print(lookRoom(player));
            controller.view.roomMenu(controller);
        }


    }    //end class ModelRPG
}
