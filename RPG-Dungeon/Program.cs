using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Dungeon
{
    class Program
    {
        static void Main(string[] args)
        {
            ViewConsole view = new ViewConsole();
            ModelRPG model = new ModelRPG();
            Controller controller = new Controller(model, view);

            controller.initialize(controller);
            Console.ReadKey();
        }
    }
}
