using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        public class Controller
    {
            private Player P1, P2;
            private Broad Game;

            public Controller()
            {
                P1 = new Player("Cuong");
                P2 = new Player("Nam");
                Game = new Broad(3, 4, 6);
            }

            public void Playgame()
            {
                Game.PrintGame();
                while(true)
                {
                    Console.WriteLine(P1.Getname() + " luot 1 ");
                    P1.PickBall(Game);
                    if (Game.Gameover())
                    {
                        Console.WriteLine(P1.Getname() + "WIN");
                        Console.WriteLine(P2.Getname() + "LOSE");
                        break;
                    }

                    Console.WriteLine(P2.Getname() + " luot 1 ");
                    P1.PickBall(Game);
                    if (Game.Gameover())
                    {
                        Console.WriteLine(P2.Getname() + "WIN");
                        Console.WriteLine(P1.Getname() + "LOSE");
                        break;
                    }
                }

            }

    }
}
