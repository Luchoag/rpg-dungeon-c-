using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon {
    class ViewConsole  {
        public ViewConsole() { }

        public void print (String str) {
            Console.WriteLine(str);
        }

        public void inputCursor() {
            Console.Write("> ");
        }
        
    public void mainMenu(Controller controller) {
        print("***************************************************");
        print("*                                                 *");
        print("*                    RPG Dungeon                  *");
        print("*                                                 *");
        print("***************************************************");
        print(" -------------      ------------       ------------");
        print("|1. Start Game|    |2. Load Game|     |3. Quit Game|");
        print(" -------------      ------------       ------------");
        bool choice=false;
        do {
            inputCursor();
            String op = Console.ReadLine();
            if (op == "1" || op == "start game" || op == "start") {
                controller.setOption(1);
                choice=true;
            } else if (op == "2" || op == "load game" || op == "load") {
                choice=true;
                controller.setOption(2);
                //function loadgame
            } else if (op =="3" || op == "quit game" || op == "quit") {
                choice=true;
                print("Hope you enjoyed it!");
                
            } else {
                print("Invalid choice. Try again.!!!");
            }            
        } while (!choice);
    }

    public void startMenu(Controller controller) {
        print("Please enter your name:");
        inputCursor();
        String name = Console.ReadLine();
        controller.setName(name);
        print(name);
        bool choice=true;
        do {
            print("Please enter your class:");
            print("1. Fighter");
            print("2. Thief");
            print("3. Mage");
            print("4. Info about classes");
            inputCursor();
            String option = Console.ReadLine();
            if (option =="1" || option.ToLower()=="fighter") {
                choice=true;
                controller.setOption(1);
            } else if (option =="2" || option.ToLower()=="thief") {
                choice=true;
                controller.setOption(2);
            } else if (option =="3" || option.ToLower()=="mage") {
                choice=true;
                controller.setOption(3);
            } else if (option =="4" || option.ToLower()=="info") {
                choice=false;
                print(Fighter.aboutFighter());
                print(Thief.aboutThief());
                print(Mage.aboutMage());
            } else {
                choice=false;
                print("Invalid choice. Try again.");
            }
        } while(!choice);

        }


        public void roomMenu(Controller controller) {
            bool choice=false;
            do
            {
                print("*****************");
                print("* 1. Move To    *");
                print("* 2. Look Room  *");
                print("* 3. Rest       *");
                print("* 4. Take       *");
                print("* 5. Inventory  *");
                print("* 6. Map        *");
                print("* 7. Status     *");
                print("* 8. Options    *");
                print("*****************");
                inputCursor();
                String op = Console.ReadLine();
                switch (op) {
                    case "1":
                    case "move":
                        moveMenu(controller);
                        choice = true;
                        break;
                    case "2":
                    case "look":
                        print(controller.model.lookRoom(controller.getPlayer()));
                        roomMenu(controller);
                        break;
                    case "7":
                    case "status":
                        print(controller.getPlayer().getStatus());
                        break;
                    default:
                        print("Invalid input. Try again.");
                        break;
                }
            } while (!choice);
        }

        public void moveMenu(Controller controller) {
            print("**************");
            print("* 1. North   *");
            print("* 2. East    *");
            print("* 3. West    *");
            print("* 4. South   *");
            print("* 5. Cancel  *");
            print("**************");
            bool choice = false;
            do {
                inputCursor();
                String op = Console.ReadLine();
                controller.model.directions(controller, controller.getPlayer(), op, out choice);
            } while (!choice);

        }

    }   //end class ViewConsole
  
}   
