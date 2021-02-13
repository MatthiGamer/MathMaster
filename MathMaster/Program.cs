using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMaster
{
    class Program
    {
        private static Gamemanager gamemanagerInstance = new Gamemanager();
        private static InputHandler inputHandlerInstance = new InputHandler();

        static void Main(string[] args)
        {
            InitializeInstances();
        }

        private static void InitializeInstances()
        {
            gamemanagerInstance.InitializeInstance();
            inputHandlerInstance.InitializeInstance();
        }
    }
}
