using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class Navigation
    {
        public static string CoordsToDirection(int ErrorRange, int x, int y)
        {
            string Direction = "";
            bool North = false;
            bool South = false;
            bool West = false;
            bool East = false;

            if ((Math.Abs(Hero.PositionX - x) <= 1) && (Math.Abs(Hero.PositionY - y) <= 1))
            {
                return "InPosition";
            }

            if (Hero.PositionY == y)
            {
                //InPosition

                if (Hero.PositionX == x) { /* InPosition */ }
                else if (Hero.PositionX > x)
                {
                    Direction = "West";
                    West = true;
                }
                else
                {
                    Direction = "East";
                    East = true;
                }
            }
            else if (Hero.PositionY < y)
            {
                Direction = "South";
                South = true;

                if (Hero.PositionX == x) { /* InPosition */ }
                else if (Hero.PositionX > x)
                {
                    Direction = Direction + "–West";
                    West = true;
                }
                else
                {
                    Direction = Direction + "–East";
                    East = true;
                }
            }
            else
            {
                Direction = "North";
                North = true;

                if(Hero.PositionX == x) { /* InPosition */ }
                else if (Hero.PositionX > x)
                {
                    Direction = Direction + "–West";
                    West = true;
                }
                else
                {
                    Direction = Direction + "–East";
                    East = true;
                }
            }

            if ((North == false) && (South == false) && (West == false) && (East == false))
            {
                return "InPosition";
            }
            else
            {
                return Direction;
            }
            
        }
    }
}
