using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace ArcheageBot
{
    class Hero
    {

        public static bool trial = true;
        public static int healhp;
        public static int healmp;
        public static bool xywalking;
        public static int? currenthp;
        public static int? currentmp;
        public static bool mob;
        public static int ihp;
        public static int jhp;
        public static int? Health = null;
        public static int? Mana = null;
        public static int PositionX;
        public static int PositionY;
        public static string Direction;
        public static int NoUpdateDirectionIteration = 0;
        public static bool ForceUpdateDirection;
        public static bool Target = false;
        public static string Action = "Start ArcheageBot";


    }
}
