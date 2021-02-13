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
        private static int difficultyLevelOptions = 3;
        private static int difficultyLevel = 1;

        public void InitializeInstance() => instance = this;
        public int GetScore() => score;
        public void AddPointsToScore(int amount) => score += amount;
        public void SetDifficultyLevel(int difficulty) => difficultyLevel = difficulty;
        public bool DifficultyIsRight() => difficultyLevel <= difficultyLevelOptions;
    }
}
