using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleGame
{
    class Game
    {
        public Game()
        {

        }

        public void Introduction()
        {
            Introduction introduction = new Introduction();
            introduction.Intro();
        }

        public void Initialize()
        {
            Introduction();

        }
    }
}
