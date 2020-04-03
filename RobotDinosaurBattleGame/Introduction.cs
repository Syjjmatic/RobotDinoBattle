using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobotDinosaurBattleGame
{
    class Introduction
    {
        public Introduction()
        {

        }

        public void Intro()
        {
            System.Threading.Thread.Sleep(300);
            Console.WriteLine("Welcome to Robot-Dinosaur Battle!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("\nPrepare for battle!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press [ENTER] to continue.");
            Console.ReadLine();
        }
    }
}
