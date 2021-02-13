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
        private static ErrorHandler errorHandlerInstance = new ErrorHandler();
        private static EquationCreator equationCreatorInstance = new EquationCreator();

        static void Main(string[] args)
        {
            // Initialize all singleton instances
            InitializeInstances();

            SetDifficulty();
            while (!Gamemanager.instance.DifficultyIsRight())
            {
                ErrorHandler.instance.WrongDifficultyError();
            }
        }

        private static void InitializeInstances()
        {
            gamemanagerInstance.InitializeInstance();
            inputHandlerInstance.InitializeInstance();
            errorHandlerInstance.InitializeInstance();
            equationCreatorInstance.InitializeInstance();
        }

        public static void SetDifficulty() => Gamemanager.instance.SetDifficultyLevel(InputHandler.instance.GetDifficultyLevel());
    }
}
