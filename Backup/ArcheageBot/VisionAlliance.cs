using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheageBot
{
    class VisionAlliance
    {
        public static List<List<VisionForm>> AllianceBars = new List<List<VisionForm>>();
        public static List<List<VisionForm>> ManaBars = new List<List<VisionForm>>();

        public static void LoadAllianceBars()
        {

            int ObjectMaxR = 140;
            int ObjectMinR = 30;
            int ObjectMaxG = 190;
            int ObjectMinG = 100;
            int ObjectMaxB = 100;
            int ObjectMinB = 20;

            /* полоса хп с не меняющимся цветом. Проверка идет попиксельно, поэтому определили только 1 пиксель */

            List<VisionForm> AllianceBar1 = new List<VisionForm>
            {
                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
            };

            VisionAlliance.AllianceBars.Add(AllianceBar1);

        }

        public static void LoadManaBars()
        {

            int ObjectMaxR = 70;
            int ObjectMinR = 25;
            int ObjectMaxG = 95;
            int ObjectMinG = 45;
            int ObjectMaxB = 160;
            int ObjectMinB = 110;

            /* полоса хп с не меняющимся цветом. Проверка идет попиксельно, поэтому определили только 1 пиксель */

            List<VisionForm> ManaBar1 = new List<VisionForm>
            {
                /* Полоска хп */
                new VisionForm(){
                    OffsetX = 1, 
                    OffsetY = 0, 
                    MaxR = ObjectMaxR,
                    MinR = ObjectMinR,
                    MaxG = ObjectMaxG,
                    MinG = ObjectMinG,
                    MaxB = ObjectMaxB,
                    MinB = ObjectMinB,
                    Object = true
                },
            };

            VisionAlliance.ManaBars.Add(ManaBar1);

        }
    }
}
