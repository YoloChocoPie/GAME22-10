using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
        public class Player
    {
          private string playername;
          private string p;

          public Player(string p)
          {
              // TODO: Complete member initialization
              this.p = p;
          }
          
          public void PickBall(Broad Game)
          {
              Console.Write(" Chon nhom");
              int g = int.Parse(Console.ReadLine());
              Console.Write(" Chon so banh");
              int b = int.Parse(Console.ReadLine());
              Game.PickBall(g, b);
          }
          

            public string Getname()
          {
              return this.p;
          }
    }
}
