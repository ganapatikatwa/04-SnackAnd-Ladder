using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        public void SnakeNLadder()
        {
            int position1 = 0;
            int dieRoll=0;
            Console.WriteLine("Initial Position of Player 1:"+position1);

            Random random=new Random();
            dieRoll= random.Next(1,7);
            Console.WriteLine("Die Roll:"+dieRoll);
            position1 = dieRoll;
            Console.WriteLine("Position of Player after Die Roll:"+dieRoll);

        }
    }
}
