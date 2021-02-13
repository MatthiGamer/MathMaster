using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMaster
{
    class InputHandler
    {
        public static InputHandler instance;

        public void InitializeInstance() => instance = this;

        public int GetDifficultyLevel()
        {
            Console.WriteLine("What difficulty do you want to play with?");
            Console.WriteLine("1 = Beginner");
            Console.WriteLine("2 = Intermediate");
            Console.WriteLine("3 = Expert \n");
            return Console.Read() - '0';
        }
    }
}
