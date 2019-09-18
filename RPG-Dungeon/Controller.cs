using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class Controller {
        public ModelRPG model {get; set;}
        public ViewConsole view { get; set; }
        private int option = 0;
        private String name;
        private Player player = null;

        public Controller(ModelRPG model, ViewConsole view)  {
            this.model = model;
            this.view = view;
            this.option = 0;
        }
 
        public void initialize (Controller controller) {
           view.mainMenu(controller);
           if (this.option==1) {
               view.startMenu(controller);
               startGame(controller);
           } else if (option==2) {
               //loadGame();
           } else {
               view.print("Error");
           }
        }

        public int getOption() {return option;}

        public void setOption(int option) {this.option = option;}

        public String getName() {return name;}

        public void setName(String name) {this.name = name;}

        public Player getPlayer() { return player; }

        public void createCharacter(out Player player) {
            switch (this.option) {
                case 1:
                    player = new Fighter();
                    break;
                case 2:
                    player = new Thief();
                    break;
                case 3:
                    player = new Mage();
                    break;
                default:
                    view.print("Error");
                    player = new Fighter();;
                    break;
            }

        }

        public void startGame(Controller controller) {
            createCharacter(out player);
            player.setName(name);
            player.showName();
            view.print(model.firstStory(player));
            player.currentRoom = 1;
            view.roomMenu(controller);
            //view.print(model.lookRoom(player));
        }

    }   //end Controller
}
