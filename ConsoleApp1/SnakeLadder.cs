using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    public class SnakeLadder
    {
        public const int Ladder = 1;
        public const int Snake = 2;

        public void SnakeNLadder()
        {
            int position1 = 0;
            int dieRoll=0;
            int dicecount = 0;
            Console.WriteLine("Initial Position of Player 1:"+position1);
            while(position1<100)
            { 

            Random random=new Random();
            dieRoll= random.Next(1,7);
                dicecount++;
            //Console.WriteLine("Die Roll:"+dieRoll);
            //position1 = dieRoll;
            //Console.WriteLine("Position of Player after Die Roll:"+dieRoll);

            int options = random.Next(0, 3);
            //Console.WriteLine("After Getting Random Option is:"+options);

                switch (options)
                {
                    case Ladder:
                        Console.WriteLine("In options if we getting Ladder");
                        position1 += dieRoll;
                        Console.WriteLine("New Position after getting Ladder:" + position1);
                        break;

                    case Snake:
                        Console.WriteLine("In options Player bit by Snake");
                        position1 -= dieRoll;
                        Console.WriteLine("New Position of player after bit by Snake:" + position1);

                        if (position1 < 0)
                        {
                            position1 = 0;
                            Console.WriteLine("New Position of player after bit by Snake:" + position1);
                        }
                        break;

                    default:
                        Console.WriteLine("In position we got No play:" + position1);
                        break;
                }
                Console.WriteLine("Current Position of Player:"+position1);
                if (position1 > 100)
                {
                    position1 -= dieRoll;
                    Console.WriteLine("Previous Position:" + position1);
                }

            }
            Console.WriteLine("Player position1 reaches 100 and the exact winning position is :" + position1);
            Console.WriteLine("player wins with a dice count of: " + dicecount);
          
        }
    }
}
