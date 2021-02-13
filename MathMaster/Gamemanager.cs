using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathMaster
{
    class Gamemanager
    {
        public static Gamemanager instance;

        private static int score = 0;

        public void InitializeInstance() => instance = this;
        public int GetScore() => score;
        public void AddPointsToScore(int amount) => score += amount;
    }
}
